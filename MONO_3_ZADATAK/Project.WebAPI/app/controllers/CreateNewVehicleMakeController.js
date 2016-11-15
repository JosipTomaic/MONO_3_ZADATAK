VehiclesApplication.controller('createNewVehicleMakeController', ['$scope', '$http', '$window', AddMaker]);
function AddMaker($scope, $http, $window){
    $scope.AddVehicleMake = function () {
        if ($scope.Name == null || $scope.Abrv == null) {
            $window.alert("You must fill all required data.");
        }
        else {
            var maker = {
                Name: $scope.Name,
                Abrv: $scope.Abrv
            };

            $http.post('/api/VehicleMake/AddVMake', maker).then(function (data) {
                $scope.Response = data;
                console.log(data);
            })
        }
    }
}