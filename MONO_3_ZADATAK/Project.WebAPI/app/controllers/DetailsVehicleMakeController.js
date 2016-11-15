VehiclesApplication.controller('DetailsVehicleMakeController', ['$scope', '$http', '$stateParams', DetailsVehicleMakeController]);
function DetailsVehicleMakeController($scope, $http, $stateParams) {
    $http.get('/api/VehicleMake/GetVMake?id=' + $stateParams.id)
    .then(function (response) {
        $scope.VehicleMakes = response;
    });
};