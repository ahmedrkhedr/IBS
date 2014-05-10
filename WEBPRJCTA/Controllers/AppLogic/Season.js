function seasonCtrl($scope, $http) {
    $http.get('/Season/GetAllSeasons').success(function (data, status, headers, config) {
        $scope.seasons = data;
    });

    $http.get('/SeasonStatusLockups/GetAllSeasonStatusLockups').success(function (data, status, headers, config) {
        $scope.sslockups = data;
    });

    $scope.getStatusById = function (statusId) {
        return _.findWhere($scope.sslockups, { Id: statusId });
    }

};



