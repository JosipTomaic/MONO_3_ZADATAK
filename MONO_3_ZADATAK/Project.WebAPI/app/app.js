var VehiclesApplication = angular.module("VehiclesApplication", ['ui.router', 'angularUtils.directives.dirPagination']);

VehiclesApplication.config(function ($stateProvider, $urlRouterProvider) {

    $stateProvider
        .state('VehicleMake', {
            url: '/VehicleMake',
            templateUrl: 'app/views/VehicleMake/Index.html'
        })
        .state('VehicleModel', {
            url: '/VehicleModel',
            templateUrl: 'app/views/VehicleModel/Index.html'
        })
        .state('VehicleMake/Details/:id', {
            url: '/VehicleMake/Details/:id',
            templateUrl: 'app/views/VehicleMake/Details.html'
        })
        .state('VehicleModel/Details/:id', {
            url: '/VehicleModel/Details/:id',
            templateUrl: 'app/views/VehicleModel/Details.html'
        })
        .state('VehicleMake/CreateNew', {
            url: '/VehicleMake/CreateNew',
            templateUrl: 'app/views/VehicleMake/CreateNew.html'
        })
        .state('VehicleModel/CreateNew', {
            url: '/VehicleModel/CreateNew',
            templateUrl: 'app/views/VehicleModel/CreateNew.html'
        })
        .state('VehicleMake/Edit/:id', {
            url: '/VehicleMake/Edit/:id',
            templateUrl: 'app/views/VehicleMake/Edit.html'
        })
        .state('VehicleModel/Edit/:id', {
            url: '/VehicleModel/Edit/:id',
            templateUrl: 'app/views/VehicleModel/Edit.html'
        })
});