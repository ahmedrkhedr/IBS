function seasonCtrl($scope, $http) {
    $http.get('/FleetMaster/GetFleetByFleetNumber').success(function (data, status, headers, config) {
        $scope.seasons = data;
    });
};



