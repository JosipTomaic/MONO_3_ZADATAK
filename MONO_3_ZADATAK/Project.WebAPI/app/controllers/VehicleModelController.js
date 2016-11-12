var app = angular.module('vehiclesApplication');
app.controller('vehicleModelController', function ($scope, $http) {
    $http.get("/api/VehicleModel/GetAllVModel")
    .then(function (response) {
        $scope.VehicleModels = response.data;
    });
});