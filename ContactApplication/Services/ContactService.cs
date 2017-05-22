using ContactApplication.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace ContactApplication.Services
{
    public class ContactService
    {
        public IEnumerable<ContactViewModel> GetAllContacts()
        {
            var serializer = new XmlSerializer(typeof(AllContactsViewModel));

            using (var fs = new FileStream(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "contacts.xml"), FileMode.Open))
            {
                var contacts = (AllContactsViewModel)serializer.Deserialize(fs);

                using (var md5 = System.Security.Cryptography.MD5.Create())
                {
                    foreach (var contact in contacts.Contacts)
                    {
                        // give each contact a randomly generated avatar from their email hash
                        var emailNormalized = contact.Email.Trim().ToLowerInvariant();
                        var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(emailNormalized));
                        var hashString = BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();
                        contact.Avatar = string.Format("https://www.gravatar.com/avatar/{0}?s=50&d=retro", hashString);
                    }
                }

                return contacts.Contacts;
            }
        }

        public ContactViewModel GetContactByEmail(string email)
        {
            return GetAllContacts().FirstOrDefault(c => c.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }
    }
}