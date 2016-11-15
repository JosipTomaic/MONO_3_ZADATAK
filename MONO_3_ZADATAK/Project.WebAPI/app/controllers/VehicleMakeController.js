VehiclesApplication.controller('VehicleMakeController', ['$scope', '$http', getMakers]);

function getMakers($scope, $http) {

    $scope.FetchVehicleMakers = function () {
        $http.get("/api/VehicleMake/GetAllVMake")
        .then(function (response) {
            $scope.VehicleMakes = response.data;
        });
    }
};