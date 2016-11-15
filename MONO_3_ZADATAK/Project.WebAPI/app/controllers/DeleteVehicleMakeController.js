VehiclesApplication.controller('DeleteVehicleMakeController', ['$scope', '$http', '$stateParams', '$window', DeleteVehicleMakeController]);
function DeleteVehicleMakeController($scope, $http, $stateParams, $window) {
    
    $scope.DeleteMaker = function (makerId) {
        if ($window.confirm("Delete selected item?")) {
            $http.delete('/api/VehicleMake/DeleteVMake?id=' + makerId)
            .then(function (response) {
                $scope.Response = response;
                $window.location.reload();
            })
        };
    }
};