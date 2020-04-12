using System;
using System.Data;
using BLL.Catalogo_BLL;
using BLL.Metodos;
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
            //Declaracion de objetos

            DAL.Catalogo_DAL.Cls_Empleados_DAL ObjDAL = new Cls_Empleados_DAL();
            BLL.Catalogo_BLL.Cls_SP_Empleados_BLL ObjBLL = new Cls_SP_Empleados_BLL();
            BLL.Metodos.Cls_Metodos_BLL ObjBLLMet = new Cls_Metodos_BLL();

            //Asignacion de datos a DT
            DataTable ObjListar = ObjBLL.ListarEmpleados(ref ObjDAL);
            TablaEmpleados.DataSource = ObjListar;

            //Formateo de Tabla
            labelTable.Text = ObjBLLMet.FormatearTabla(ObjListar);

        }
    }
}