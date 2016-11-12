var app = angular.module('vehiclesApplication', []);
app.controller('vehicleMakeController', function ($scope, $http) {
    $http.get("/api/VehicleMake/GetAllVMake")
    .then(function (response) {
        $scope.VehicleMakes = response.data;
    });
});