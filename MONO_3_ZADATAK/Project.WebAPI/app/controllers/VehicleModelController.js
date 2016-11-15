VehiclesApplication.controller('VehicleModelController', ['$scope', '$http', getModels]);
function getModels($scope, $http) {
    $http.get("/api/VehicleModel/GetAllVModel")
    .then(function (response) {
        $scope.VehicleModels = response.data;
    });
};