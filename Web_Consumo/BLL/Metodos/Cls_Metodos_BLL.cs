using System.Data;
using System.Text;
using BLL.WCF_Aerolinea_BD;

namespace BLL.Metodos
{
    public class Cls_Metodos_BLL
    {
        public string FormatearTablaGeneral(DataTable ObjListar)
        {
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

            return sb.ToString();
        }


        public string FormatearTablaListarEmpleados(DataTable ObjListar)
        {

            StringBuilder sb = new StringBuilder();

            sb.Append("<table class=\"table table-striped\">");
            sb.Append("<thead>");
            sb.Append("<tr>");
            foreach (DataColumn column in ObjListar.Columns)
            {
                sb.Append("<th>" + column.ColumnName.ToString().ToUpper() + "</th>");
            }
            sb.Append("<th>EDITAR</th>");
            sb.Append("<th>ELIMINAR</th>");
            sb.Append("</tr></thead>");
            sb.Append("<tbody>");

            byte count = 0;
            foreach (DataRow row in ObjListar.Rows)
            {
                sb.Append("<tr id=\"row" + count + "\">");

                foreach (DataColumn column in ObjListar.Columns)
                {
                    sb.Append("<td>" + row[column.ColumnName].ToString() + "</td>");
                }
                sb.Append("<td>");
                sb.Append("<button type=\"button\" class=\"btn btn-primary\" onclick=\"EDITAR(" + row.ItemArray[0] + ",'" + row.ItemArray[1] + "','" + row.ItemArray[2] + "')\" >");
                sb.Append("<i class=\"fas fa-edit\"> </i></button>");
                sb.Append("</td>");

                sb.Append("<td>");
                sb.Append("<button type=\"button\" class=\"btn btn-danger\" onclick=\"ELIMINAR_MD(" + row.ItemArray[0] + ",'" + row.ItemArray[1] + "')\" >");
                sb.Append("<i class=\"fas fa-trash\"> </i></button>");
                sb.Append("</td>");

                sb.Append("</tr>");
                count++;
            }
            sb.Append("</tbody>");
            sb.Append("</table>");

            return sb.ToString();
        }

        public DataTable CrearDtParametros()
        {
            DataTable ds = new DataTable();
            BD Cliente = new BD();
            try
            {
                ds = Cliente.CrearDTParametros();
            }
            finally
            {
                Cliente.Dispose();         
            }


            return ds;

        }
    }
}
