var myApp = angular.module('myApp', []);
myApp.factory('Data',function(){
    return {text: "Integral Business Solutions"}
})

function HelloController($scope,Data) {
    $scope.greeting = Data;
}

