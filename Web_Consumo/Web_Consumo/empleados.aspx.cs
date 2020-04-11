using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web_Consumo.WCF;
using System.Data;
using System.Text;
using BLL.Catalogo_BLL;
using DAL.Catalogo_DAL;

namespace Web_Consumo
{
    public partial class empleados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            this.CargarDatos();

        }


        private void CargarDatos()
        {

            DAL.Catalogo_DAL.Cls_Empleados_DAL ObjDAL = new Cls_Empleados_DAL();
            BLL.Catalogo_BLL.Cls_SP_Empleados_BLL ObjBLL = new Cls_SP_Empleados_BLL();



            DataTable ObjListar = ObjBLL.ListarEmpleados(ref ObjDAL);
            TablaEmpleados.DataSource = ObjListar;
            StringBuilder sb = new StringBuilder();

            sb.Append("<table class=\"table table-striped\">");
            sb.Append("<thead>");
            sb.Append("<tr>");
            foreach (DataColumn column in ObjListar.Columns)
            {
                sb.Append("<th>" + column.ColumnName.ToString().ToUpper() + "</th>");
            }
            sb.Append("<th>OPCIONES</th>");
            sb.Append("</thead>");
            sb.Append("<body>");

            byte count = 0;
            foreach (DataRow row in ObjListar.Rows)
            {
                sb.Append("<tr id=\"row" + count + "\">");
                foreach (DataColumn column in ObjListar.Columns)
                {
                    sb.Append("<td>" + row[column.ColumnName].ToString() + "</td>");
                }
                sb.Append("<td>");
                sb.Append("<button id=\"openmodal\" type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#myModal\">");
                sb.Append("<i class=\"fas fa-bars\"> </i>");
                sb.Append("</button>");
                sb.Append("<td>");
                sb.Append("</tr>");
                count++;
            }
            sb.Append("</body>");
            sb.Append("</table>");

            labelTable.Text = sb.ToString();

        }
    }
}