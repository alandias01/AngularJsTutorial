'use strict';

angular.module("app").config(function ($routeProvider, $locationProvider) {
    $routeProvider.when("/", {
        templateUrl: 'main.html'
    })
    .when('/details', {
        templateUrl: "details.html"
    });

    // use the HTML5 History API
    $locationProvider.html5Mode(true);


});

