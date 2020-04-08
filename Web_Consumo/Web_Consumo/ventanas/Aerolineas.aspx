<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Aerolineas.aspx.cs" Inherits="Web_Consumo.ventanas.Aerolineas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form name="formAerolineas" id="formAerolineas" method="get">
        <fieldset id="titulo">
            <h2>Aerolineas</h2>
        </fieldset>
        <br>
        <br>

            <fieldset id="dtAerolinea">
                <legend>Datos Aerolinea</legend>
                <label>Id Aerolinea: <input type="text" id="IdAerolinea" name="IdAerolinea" /></label>
                <label  for="IdEstado">Estado:</label>
               <select  id="IdEstado" name="IdEstado">
                   <option value="01- Activo">01- Activo</option>
                   <option value="02- Inactivo">02- Inactivo</option>
               </select>
               <br>
               <br>
               <label>Nombre Aerolinea: <input class="controls" type="text" id="Nombre" name="Nombre" /></label>
              </fieldset>
              <br>
              <br>
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
