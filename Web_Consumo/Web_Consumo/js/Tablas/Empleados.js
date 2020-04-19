
$(document).ready(function () {
    $("#inp_ID_Empleado").val("");
    $("#inp_Cedula").val("");
    $("#inp_Nombre").val("");
    $("#inp_Apellidos").val("");
    $("#inp_Direccion").val("");
    $("#inp_Edad").val("");
    $("#inp_TelCasa").val("");
    $("#inp_TelReferencia").val("");
    $("#inp_Celular").val("");
    $("#inp_Salario").val("");
    $("#slc_ID_Tipo_Empleado").val("");
    $("#slc_ID_Aerolinea").val("");
    $("#Slc_ID_Estado").val("");
   

    $("#inp_ID_Emp_Elim").val("");
    $("#inp_Nomb_Emp_Elim").val("");
    $("#inp_Apell_Elim").val("");



    $("#inp_IdEmpleadoAG").val("");
    $("#inp_CedulaAG").val("");
    $("#inp_NombreAG").val("");
    $("#inp_ApellidosAG").val("");
    $("#inp_DireccionAG").val("");
    $("#inp_EdadAG").val("");
    $("#inp_TelCasaAG").val("");
    $("#inp_TelRefAG").val("");
    $("#inp_CelularAG").val("");
    $("#inp_SalarioAG").val("");
    $("#Slc_IdTipoEmpleadoAG").val("0");
    $("#Slc_IdAerolineaAG").val("0");
    $("#slc_IdEstado_AG").val("0");
});

function EDITAR_MD(vIdEmp, vCed, vNomb, vApell, vDirecc,
                vEdad, vTelCasa, vTel_Ref, vCel,
                vSalario, vId_TipEmp,vIdAero,vIdEstado) {
    //ASIGNO LOS VALORES A LOS INPUT
    $("#inp_ID_Empleado").val(vIdEmp);
    $("#inp_Cedula").val(vCed);
    $("#inp_Nombre").val(vNomb);
    $("#inp_Apellidos").val(vApell);
    $("#inp_Direccion").val(vDirecc);
    $("#inp_Edad").val(vEdad);
    $("#inp_TelCasa").val(vTelCasa);
    $("#inp_TelReferencia").val(vTel_Ref);
    $("#inp_Celular").val(vCel);
    $("#inp_Salario").val(vSalario);
    $("#slc_ID_Tipo_Empleado").val(vId_TipEmp);
    $("#slc_ID_Aerolinea").val(vIdAero);
    $("#Slc_ID_Estado").val(vIdEstado);
    $("#ModalEditar").show();
}


function ELIMINAR_MD(vIdEmp, vNomb, vApell) {
    $("#inp_ID_Emp_Elim").val(vIdEmp);
    $("#inp_Nomb_Emp_Elim").val(vNomb);
    $("#inp_Apell_Elim").val(vApell);
    $("#ModalEliminar").show();
}

function AGREGAR_MD() {
    $("#ModalAgregar").modal();
}
