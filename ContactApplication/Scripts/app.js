(function () {
    'use strict';

    angular.module('app', []).controller('mainController', ['$scope', '$http', function ($scope, $http) {
        var ctrl = this;
        ctrl.allContacts = loadContacts();

        function loadContacts() {
            var contacts = [
              'Marina Augustine',
              'Oddr Sarno',
              'Nick Giannopoulos',
              'Narayana Garner',
              'Anita Gros',
              'Megan Smith',
              'Tsvetko Metzger',
              'Hector Simek',
              'Some-guy withalongalastaname'
            ];

            return contacts.map(function (c, index) {
                var cParts = c.split(' ');
                var email = cParts[0][0].toLowerCase() + '.' + cParts[1].toLowerCase() + '@example.com';
                var hash = CryptoJS.MD5(email);

                var contact = {
                    name: c,
                    email: email,
                    image: '//www.gravatar.com/avatar/' + hash + '?s=50&d=retro'
                };
                contact._lowername = contact.name.toLowerCase();
                return contact;
            });
        }
    }]);

})();