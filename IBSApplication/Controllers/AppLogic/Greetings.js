var myApp = angular.module('myApp', []);
myApp.factory('Data',function(){
    return {text: "Integrated Transportation Systems"}
})

function HelloController($scope,Data) {
    $scope.greeting = Data;
}

