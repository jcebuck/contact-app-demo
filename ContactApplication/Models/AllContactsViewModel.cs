using System.Collections.Generic;
using System.Xml.Serialization;

namespace ContactApplication.Models
{
    [XmlRoot("Contacts")]
    public class AllContactsViewModel
    {
        public AllContactsViewModel()
        {
            Contacts = new List<ContactViewModel>();
        }

        [XmlElement("Contact")]
        public List<ContactViewModel> Contacts { get; set; }
    }
}