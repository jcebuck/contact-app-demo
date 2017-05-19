(function () {
    'use strict';

    angular.module('app', []).controller('mainController', ['$scope', '$http', function ($scope, $http) {
        var ctrl = this;
        loadContacts();

        function loadContacts() {
            $http.get('../Home/GetContacts').then(function (response) {
                ctrl.allContacts = response.data;
            });
        }
    }]);

})();