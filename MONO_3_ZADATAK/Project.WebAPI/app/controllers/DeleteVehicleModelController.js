VehiclesApplication.controller('DeleteVehicleModelController', ['$scope', '$http', '$stateParams', '$window', DeleteVehicleModelController]);
function DeleteVehicleModelController($scope, $http, $stateParams, $window) {
    $scope.DeleteModel = function (modelId) {
        if ($window.confirm("Delete selected item?")) {
            $http.delete('/api/VehicleModel/DeleteVModel?id=' + modelId)
            .then(function (response) {
                $scope.Response = response.data;
                $window.location.reload();
            })
        };
    }
};