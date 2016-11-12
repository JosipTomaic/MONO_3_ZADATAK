//var app = angular.module('vehiclesApplication', []);
angular.module('vehiclesApplication', []).controller('DetailsVehicleMakeController', function ($scope, $http, $param) {
    $http.get('/api/vehiclemake/GetVMake?id=' + $param.id).then(function (response) {
        $scope.VehicleMakes = response.data;
    });
});