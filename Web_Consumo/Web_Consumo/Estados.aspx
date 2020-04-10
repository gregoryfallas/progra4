<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Estados.aspx.cs" Inherits="Web_Consumo.Estados" %>

<!DOCTYPE html>

<html class="no-js" lang="zxx">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <asp:Label ID="Label1" runat="server" Text="Filtro : "></asp:Label>
              <asp:TextBox ID="txt_filtroEstados" runat="server" Width="477px" OnTextChanged="txt_filtroEstados_TextChanged"></asp:TextBox>  
              <asp:Button ID="btn_FiltrarEstados" runat="server" Text="Filtrar" OnClick="btn_FiltrarEstados_Click"/>
              <asp:Button ID="btn_EliminarEstados" runat="server" Text="Eliminar"/>
               <div>
                   <p>


                   </p>
                   <asp:GridView ID="DGV_DATOS" runat="server"></asp:GridView>
                   <p>


                   </p>

               </div>        
        </div>
    </form>
</body>
</html>
