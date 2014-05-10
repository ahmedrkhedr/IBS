function seasonCtrl($scope, $http) {
    $http.get('/Season/GetAllSeasons').success(function (data, status, headers, config) {
        $scope.seasons = data;
    });

    $http.get('/SeasonLockup/GetAllSeasonsLockups').success(function (data, status, headers, config) {
        $scope.SeasonLockups = data;
    });

    $scope.getStatusById = function (statusId) {
        return _.findWhere($scope.SeasonLockups, { Id: statusId });
    }

};



