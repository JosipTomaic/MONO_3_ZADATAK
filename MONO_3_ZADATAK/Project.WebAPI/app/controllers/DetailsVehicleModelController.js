VehiclesApplication.controller('DetailsVehicleModelController', ['$scope', '$http', '$stateParams', DetailsVehicleModelController]);
function DetailsVehicleModelController($scope, $http, $stateParams) {
    $http.get('/api/VehicleModel/GetVModel?id=' + $stateParams.id)
    .then(function (response) {
        $scope.VehicleModels = response;
    });
};