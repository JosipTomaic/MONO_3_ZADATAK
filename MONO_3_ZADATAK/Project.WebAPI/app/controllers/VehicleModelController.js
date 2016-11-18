VehiclesApplication.controller('VehicleModelController', ['$scope', '$http', getModels]);
function getModels($scope, $http) {
    $scope.FetchVehicleModels = function () {
        $http.get("/api/VehicleModel/GetAllVModel")
        .then(function (response) {
            $scope.VehicleModels = response.data;
        });
    }

    $scope.sort = function (keyname) {
        $scope.sortKey = keyname;   //set the sortKey to the param passed
        $scope.reverse = !$scope.reverse; //if true make it false and vice versa
    }
};