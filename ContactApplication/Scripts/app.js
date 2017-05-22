(function () {
    'use strict';

    var app = angular.module('app', []);

    app.filter('escape', function () {
        return window.encodeURIComponent;
    });
    
    app.controller('mainController', ['$scope', '$http', function ($scope, $http) {
        var ctrl = this;
        ctrl.orderByReverse = 'false';
        loadContacts();

        function loadContacts() {
            $http.get('../Home/GetContacts').then(function (response) {
                ctrl.allContacts = response.data;
            });
        }

        ctrl.orderByReverseGet = function () {
            return ctrl.orderByReverse === 'true';
        };
    }]);

})();