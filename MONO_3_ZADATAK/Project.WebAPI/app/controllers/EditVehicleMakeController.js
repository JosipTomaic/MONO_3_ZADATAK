VehiclesApplication.controller('EditVehicleMakeController', ['$scope', '$http', '$window', '$stateParams', UpdateMaker]);
function UpdateMaker($scope, $http, $window, $stateParams) {
    $scope.getMaker = function () {
        $http.get('/api/VehicleMake/GetVMake?id=' + $stateParams.id).then(function (response) {
            $scope.updateMaker = response;
        })
    }

    $scope.VehicleMakeUpdate = function () {
        if ($scope.updateMaker.Name != null || $scope.updateMaker.Abrv != null) {
            var maker = {
                Name: $scope.updateMaker.Name,
                Abrv: $scope.updateMaker.Abrv,
                VehicleMakeId: $scope.updateMaker.data.VehicleMakeId
            }

            $http.put('/api/VehicleMake/EditVMake', maker).then(function () {
                $window.alert("Done!");
            })
        }
        else $window.alert("Please input all required data.");
    }
}