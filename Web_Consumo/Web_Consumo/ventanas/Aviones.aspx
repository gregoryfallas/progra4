<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Aviones.aspx.cs" Inherits="Web_Consumo.ventanas.Aviones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
   <form name="Aviones" id="Aviones">
        <fieldset id="titulo">
            <h2>Aviones</h2>
        </fieldset>
        <br>
        <br>
        <fieldset>
            <legend>Datos del  Avion</legend>
            <label>Id del Avion: <input type="text" id="IdAvion" name="IdAvion" /></label>
                <label  for="IdEstado">Estado:</label>
               <select  id="IdEstado" name="IdEstado">
                   <option value="01- Disponible">01- Disponible</option>
                   <option value="02- No Disponible">02- No Disponible</option>
               </select>
               <br>
               <br>
               <label>Nombre Avion: <input class="controls" type="text" id="Nombre" name="Nombre" /></label>
               <br>
               <br>
               <label for="IdAerolinea">Id Aerolinea:</label>
               <select id="IdAerolinea" name="IdAerolinea">
                   <option value="01- Air Costa Rica">01- Air Costa Rica</option>
                   <option value="02- Avianca">02- Avianca</option>
                   <option value="03- Nature Air">03- Nature Air</option>
                   <option value="04 SANSA">04 SANSA</option>
                   <option value="05 Volaris">05 Volaris</option>
               </select> 

               <label for="IdTipoAvion">Id Tipo Avion:</label>
               <select id="IdTipoAvion" name="IdAerolinea">
                   <option value="Av01-Avro RJ100">Av01-Avro RJ100"</option>
                   <option value="Av02- Avr RJ85">Av02- Avr RJ85</option>
                   <option value="Av03- CRJ-1000">Av03- CRJ-1000</option>
                   <option value="Av04- CRJ-100ER">Av04- CRJ-100ER</option>
                   <option value="Av05- CRJ-700">Av05- CRJ-700</option>
                   <option value="Av06- Ebraer 20ER">Av06- Ebraer 20ER</option>
               </select> 
               <br>
               <br>
               <label>Descripcion</label>
               <textarea  name="Descripcion" rows=5 cols=40>
                Introduzca descripción del Avion
              </textarea>
    </fieldset >
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
