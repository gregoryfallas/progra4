<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Empleados.aspx.cs" Inherits="Web_Consumo.Empleados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
         <form name="formEmpleado" id="formempelado" method="get">
            <fieldset id="titulo">
                <h2>Empleados</h2>
            </fieldset>
            <br>
            <fieldset id="dtInternos">
                <legend>Datos Internos</legend>
                <label>Id Empleado: <input type="number" id="IdEmpleado" name="IdEmpleado" /></label>
                <label  for="IdEstado">Escoja el Estado Correpondiente:</label>
               <select  id="IdEstado" name="IdEstado">
                   <option value="01- Activo">01- Activo</option>
                   <option value="02- Inactivo">02- Inactivo</option>
               </select>
              </fieldset>
              <br>
              <fieldset id="dtPersonales">
                <legend>Datos Personales</legend>
                <label>Cedula: <input class="controls" type="number" id="Cedula" name="Cedula" /></label>
                <label>Nombre: <input class="controls" type="text" id="Nombre" name="Nombre" /></label>
                <label>Apellido: <input class="controls" type="text" id="Apellido" name="Apellido" /></label>
                <label>Edad: <input class="controls" type="number" id="Edad" name="Edad" /></label>
                <br />
                <br />
                <label>Telefono Casa: <input class="controls" type="tel" id="TelCasa" name="Teléfono Casa" /></label>
                <label>Telefono Referecia: <input class="controls" type="tel" id="TelReferencia " name="TelReferencia" /></label>
                <label>Celular: <input class="controls" type="tel" id="CelNumber" name="Celular" /></label>
                <br />
                <br />
                <label>Direccion:
                    <input class="auto-style1" type="text" id="Dirección" name="Dirección" /></label>
    
              </fieldset>
              <br>
              <fieldset>
                  <legend>Datos de la Empresa</legend>
                  <label>Salario:<input class="controls" type="number" id="Salario" name="Salario" /></label>
                  <label for="IdTipoEmpleado">Id Empleado:</label>
                  <select id="TipoEmpleado" name="TipoEmpleado">
                      <option value="01- Oficial de seguridad">01- Oficial de seguridad</option>
                      <option value="02- Recepcionista">02- Recepcionista</option>
                      <option value="03- Pistero">03- Pistero</option>
                      <option value="04 SobreCargo">04 SobreCargo</option>
                      <option value="05 Piloto">05 Piloto</option>
                  </select>
                  <label for="IdAerolinea">Id Aerolinea:</label>
                  <select id="IdAerolinea" name="IdAerolinea">
                      <option value="01- Air Costa Rica">01- Air Costa Rica</option>
                      <option value="02- Avianca">02- Avianca</option>
                      <option value="03- Nature Air">03- Nature Air</option>
                      <option value="04 SANSA">04 SANSA</option>
                      <option value="05 Volaris">05 Volaris</option>
                  </select> 
              </fieldset>
              <br />
              <br />
              <fieldset>
                <button type="button" id="btnGuardar" class="btn btn-default">Guardar</button>

                <button type="button" id="btnAgregar" class="btn btn-default">Agregar</button>

                <button type="button" id="btnConsultar" class="btn btn-default">Consultar</button>

                <button type="button" id="btnModificar" class="btn btn-default">Modificar</button>

                <button type="button" id="btnCancelar" class="btn btn-default">Cancelar</button>
              
              </fieldset>
             
        </form>
</body>
</html>