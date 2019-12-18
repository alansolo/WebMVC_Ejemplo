var app = angular.module("MyApp", []);

app.controller("MyController", function ($scope, $http, $window) {
    var hola = "Hola Mundo....";

    $scope.HolaMundo = "Hola Mundo...."; 

    $scope.MostrarMensaje = function (mensaje) {
        //alert(mensaje);

        /*$.ajax({
            type: "GET",
            url: "/Login/EjemploGet",
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            success: function (datos) {

                alert(datos.usuario);

            },
            error: function (error) {

                alert("Error");

            }
        });*/

        $.get("/Login/EjemploGet", function (data, status) {
            alert("Data: " + data.usuario + "\nStatus: " + status);
        });

    };

});