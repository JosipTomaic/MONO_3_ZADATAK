VehiclesApplication.controller('VehicleMakeController', ['$scope', '$http', getMakers]);

function getMakers($scope, $http) {

    $scope.FetchVehicleMakers = function () {
        $http.get("/api/VehicleMake/GetAllVMake")
        .then(function (response) {
            $scope.VehicleMakes = response.data;
        });
    }

    $scope.sort = function (keyname) {
        $scope.sortKey = keyname;   //set the sortKey to the param passed
        $scope.reverse = !$scope.reverse; //if true make it false and vice versa
    }
};