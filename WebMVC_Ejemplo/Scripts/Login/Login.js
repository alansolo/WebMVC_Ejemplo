var app = angular.module("MyApp", []);

app.controller("MyController", function ($scope, $http, $window) {
    var hola = "Hola Mundo....";

    $scope.HolaMundo = "Hola Mundo...."; 
    $scope.usuario = "";
    $scope.password = "";
    $scope.mensaje = "";
    $scope.mostrarMensaje = false;
    $scope.deshabilitar = true;
    $scope.soloLectura = true;
    $scope.textoCambio = "";

    $scope.ValidarLogin = function (usuario, password) {

        $.ajax({
            type: "POST",
            url: "/Login/ValidarLogin",
            data: JSON.stringify(
                {
                    'usuario': usuario,
                    'password': password
                }),
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            success: function (datos) {

                if (datos === "OK") {
                    $scope.mostrarMensaje = false;
                    $window.location.href = "/Principal/Principal";
                }
                else {
                    $scope.mensaje = datos;
                    $scope.mostrarMensaje = true;
                }

                $scope.$apply();
            },
            error: function (error) {

                alert("Error");

            }
        });

    };

    $scope.EventoCambioTexto = function (text) {
        $scope.textoCambio = text;
    };

    $scope.funcionMostrarMensaje = function () {
        if ($scope.usuario === "alan") {
            return true;
        }
        else {
            return false;
        }
    };

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