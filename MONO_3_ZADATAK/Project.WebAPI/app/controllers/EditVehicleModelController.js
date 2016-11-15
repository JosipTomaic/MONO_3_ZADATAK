VehiclesApplication.controller('EditVehicleModelController', ['$scope', '$http', '$window', '$stateParams', UpdateModel]);
function UpdateModel($scope, $http, $window, $stateParams) {
    $scope.getModel = function () {
        $http.get('/api/VehicleModel/GetVModel?id=' + $stateParams.id).then(function (response) {
            $scope.updateModel = response;
        })
    }

    $scope.VehicleModelUpdate = function () {
        if ($scope.updateModel.Model != null || $scope.updateModel.Abrv != null) {
            var model = {
                Model: $scope.updateModel.Model,
                Abrv: $scope.updateModel.Abrv,
                VehicleMakeId: $scope.updateModel.data.VehicleMakeId,
                VehicleModelId: $scope.updateModel.data.VehicleModelId
            }

            $http.put('/api/VehicleModel/EditVModel', model).then(function () {
                $window.alert("Done!");
            })
        }
        else $window.alert("Please input all required data.");
    }
}