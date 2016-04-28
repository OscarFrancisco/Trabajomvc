$(document).ready(function () {
    alert("algo");
    $.ajax({
        //Permite definir el tipo de llamado GET o POST siendo POST el mejor
        type: "POST",
        //Define la ruta al WebMethod existente en el code-behind
        url: "Formulario_Lista.aspx/Listar",
        //Permite pasar parametro en formato JSON (string) Hay Utilities como JSON2,
        //que permite serializar falcilmente a este fomato
        data: {},
        //Define el content type que viajara en los bloques HTTP
        contentType: "application/json; chartset:utf-8",
        //Define el tipo de datos que se va a manejar xml, json
        dataType: "json",
        //Esta sección permite definir una función anónima, la cual se encargará de
        //recibir los resultados provenientes del servidor,
        //en este caso serializados en formato JSON
        success:
            function (result) {
                if (result.d) {
                    alert("asas");
                    /*var table = $("<table></table>");
                    table.append($("<tr style='background:#EBEBEB;'></tr>").append("<td>Código</td><td>Nombre</td>"))
                    $(result.d).each(function () {
                        table.append($("<tr></tr>").append("<td>" + this.Id + "</td><td>" + this.Name + "</td>"));
                    });
                    $("#DivPersons").append(table);*/
                }
            },
        //Esta función permite definir una función anónima que
        //se encargara de gestionar los posibles erroes.
        error:
        function (XmlHttpError, error, description) {
            
        },
        async: true
    });
});
 /*
function sendDataAjax(nombre, apellido) {
    var actionData = "{'nombre': '" + nombre + "',
    'apellido': '" + apellido + "'}";
           
$.ajax(
{
    url: "jqAjax.aspx/GetDataAjax",
    data: actionData,
    dataType: "json",
    type: "POST",
    contentType: "application/json; charset=utf-8",
    success: function(msg) { alert(msg.d); },
    error: function(result) {
        alert("ERROR " + result.status + ' ' + result.statusText);
    }
});        
};*/