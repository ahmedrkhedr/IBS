'use strict';

/* App Module */

var phonecatApp = angular.module('phonecatApp', [
  'ngRoute',
  'phonecatControllers'
]);

phonecatApp.config(['$routeProvider',
  function ($routeProvider) {
      $routeProvider.
        when('/Phonecat', {
            templateUrl: '~/Content/partials/phone-list.html',
            controller: 'PhoneListCtrl'
        }).
        when('/Phonecat/:phoneId', {
            templateUrl: '~/Content/partials/phone-detail.html',
            controller: 'PhoneDetailCtrl'
        }).
        otherwise({
            redirectTo: '/Phonecat'
        });
  }]);