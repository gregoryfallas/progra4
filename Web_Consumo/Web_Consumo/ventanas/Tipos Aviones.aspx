<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tipos Aviones.aspx.cs" Inherits="Web_Consumo.ventanas.Tipos_Aviones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form name="formTipoAviones" id="formTipoAviones"></form>
    <fieldset id="titulo">
        <h2>Tipos de Aviones</h2>
    </fieldset>
    <br>
    <br>
    <fieldset id="dtAvion">
        <legend>Datos del Tipo Avion</legend>
        <label>Id Tipo de Avion: <input type="text" id="IdTipoAvion" name="IdTipoAvion" /></label>
                <label  for="IdEstado">Estado:</label>
               <select  id="IdEstado" name="IdEstado">
                   <option value="01- Disponible">01- Disponible</option>
                   <option value="02- No Disponible">02- No Disponible</option>
               </select>
               <br>
               <br>
               <label>Nombre Tipo Avion: <input class="controls" type="text" id="Nombre" name="Nombre" /></label>
    </fieldset >
    <br>
    <br>
    <fieldset id="decAvion">
        <label>Capacidad de Pasajeros: <input type="number" id="CapPasajero" name="CapPasajero" min="0" /></label>
        <label>Capacidad de Peso: <input type="number" id="CapPeso" name="CapPeso" min="0" /></label>

        <br>
    <br>
        <legend>Descripcion del Avion</legend>
        <label>Descripcion</label>
        <textarea  name="Descripcion" rows=5 cols=40>
            Introduzca descripción del Avion
        </textarea>
    </fieldset >
    <br>
    <br>
    <FIELdset>
        <legend>Tipos de Aviones </legend>
        <table style="width: 100%; text-align: center;">
            <tr>
                <th>Id Tipo Avion</th>
                <th>Nombre Tipo Avion</th>
                <th>Cantidad de Pasajeros</th>
                <th>Cantidad de Peso</th>
                <th>Descripcion</th>
                <th>Estado</th>
              </tr>
              <tr>
                  <td>Av01</td>
                  <td>Avro RJ100</td>
                  <td>130</td>
                  <td>12490 kg</td>
                  <td>Tipo Regional</td>
                  <td>Disponible</td>
              </tr>
              <tr>
                <td>Av02</td>
                <td>Avro RJ85</td>
                <td>114</td>
                <td>1636 kg</td>
                <td>Tipo Regional</td>
                <td>Disponible</td>
            </tr>
            <tr>
                <td>Av03</td>
                <td>CRJ-1000</td>
                <td>104</td>
                <td>88490 kg</td>
                <td>Tipo Regional</td>
                <td>Disponible</td>
            </tr>
            <tr>
                <td>Av04</td>
                <td>CRJ-100ER</td>
                <td>50</td>
                <td></td>
                <td>Tipo Regional</td>
                <td>No Disponible</td>
            </tr>
            <tr>
                <td>Av05</td>
                <td>CRJ-700</td>
                <td>78</td>
                <td></td>
                <td>Tipo Regional</td>
                <td>No Disponible</td>
            </tr>
            <tr>
                <td>Av06</td>
                <td>Ebraer 20ER</td>
                <td>30</td>
                <td></td>
                <td>Tipo Turbohelice</td>
                <td>No Disponible</td>
            </tr>
        </table>
    </FIELdset>
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
