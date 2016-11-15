VehiclesApplication.controller('createNewVehicleModelController', ['$scope', '$http', '$window', CreateModel]);
function CreateModel($scope, $http, $window) {
    $scope.FetchVehicleMakers = function () {
        $http.get("/api/VehicleMake/GetAllVMake")
        .then(function (response) {
            $scope.VehicleMakes = response.data;
        });
    }
    $scope.AddVehicleModel = function () {
        if ($scope.VehicleMakes.VehicleMakeId = null || $scope.Model == null || $scope.Abrv == null) {
            $window.alert("You must fill/select all required data.");
        }
        else {
            var model = {
                Model: $scope.Model,
                Abrv: $scope.Abrv,
                VehicleMakeId: $scope.VehicleMakeId
            };

            $http.post('/api/VehicleModel/AddVModel', model).then(function (data) {
                $scope.Response = data;
                $window.alert("Done!");
            })
        }
    }
}