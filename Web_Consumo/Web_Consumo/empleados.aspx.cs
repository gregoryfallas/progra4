using System;
using System.Data;
using BLL.Catalogo_BLL;
using BLL.Metodos;
using DAL.Catalogo_DAL;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Consumo
{
    public partial class empleados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            CargarDatos('L');
            LlenarSelectEstado();
            LlenarSelectIdAerolinea();
            LlenarSelectId_Tipo_Empleado();

        }

        protected void btn_Editar_Click(object sender, EventArgs e)
        {
            Cls_Empleados_DAL objDal = new Cls_Empleados_DAL();
            Cls_SP_Empleados_BLL objBLL = new Cls_SP_Empleados_BLL();

            objDal.SIdEmpleado = inp_ID_Empleado.Value.ToString();
            objDal.SCedula = inp_Cedula.Value.ToString();
            objDal.SNombre = inp_Nombre.Value.ToString();
            objDal.SApellidos = inp_Apellidos.Value.ToString();
            objDal.SDireccion = inp_Direccion.Value.ToString();
            objDal.IEdad = Convert.ToInt32(inp_Edad.Value);
            objDal.STelefonoCasa = inp_TelCasa.Value.ToString();
            objDal.STelefonoReferencia = inp_TelReferencia.Value.ToString();
            objDal.SCelular = inp_Celular.Value.ToString();
            objDal.DSalario = Convert.ToDecimal(inp_Salario.Value);
            objDal.IIdTipoEmpleado = Convert.ToInt32(slc_ID_Tipo_Empleado.ToString());
            objDal.IIdAerolinea = Convert.ToInt32(slc_ID_Aerolinea.ToString());
            objDal.CIdEstado = Convert.ToChar(Slc_ID_Estado.Value.ToString());

            try
            {
                objBLL.EditarEmpleados(ref objDal);

                switch (objDal.SFiltro)
                {
                    case "OK":
                        CargarDatos('L');
                        ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert([" + objDal.SMsjError + "]);", true);
                        break;
                    case "NO":
                        ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert([" + objDal.SMsjError + "]);", true);
                        break;

                    default:
                        break;

                        
                }

            }
            catch (Exception ex)
            {

                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('OCURRIO UN ERROR[" + ex.Message + "] AL AGREGAR EL NUEVO ITEM);", true);

            }

           
            
        }

        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
            Cls_Empleados_DAL objDal = new Cls_Empleados_DAL();
            Cls_SP_Empleados_BLL objBLL = new Cls_SP_Empleados_BLL();

            objDal.SIdEmpleado           = inp_IdEmpleadoAG.Value.ToString();
            objDal.SCedula               = inp_CedulaAG.Value.ToString();
            objDal.SNombre               = inp_NombreAG.Value.ToString();
            objDal.SApellidos            = inp_ApellidosAG.Value.ToString();
            objDal.SDireccion            = inp_DireccionAG.Value.ToString();
            objDal.IEdad                 = Convert.ToInt32(inp_EdadAG.Value.ToString());
            objDal.STelefonoCasa         = inp_TelCasaAG.Value.ToString();
            objDal.STelefonoReferencia   = inp_TelRefAG.Value.ToString();
            objDal.SCelular              = inp_CelularAG.Value.ToString();
            objDal.DSalario              = Convert.ToDecimal(inp_SalarioAG.Value.ToString());
            objDal.IIdTipoEmpleado       = Convert.ToInt32(Slc_IdTipoEmpleadoAG.Value.ToString());
            objDal.IIdAerolinea          = Convert.ToInt32(Slc_IdAerolineaAG.Value.ToString());
            objDal.CIdEstado             = Convert.ToChar(slc_IdEstado_AG.Value.ToString());

            try
            {
                objBLL.AgregarEmpleado(ref objDal);
                switch (objDal.SFiltro)
                {
                    case "OK":
                        CargarDatos('L');
                        ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert([" + objDal.SMsjError + "]);", true);
                        break;
                    case "NO":
                        ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert([" + objDal.SMsjError + "]);", true);
                        break;

                    default:
                        break;


                }

            }
            catch (Exception ex)
            {

                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('OCURRIO UN ERROR["+ex.Message+"] AL AGREGAR EL NUEVO ITEM);", true);

            }

            



        }

        protected void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Cls_Empleados_DAL objDal = new Cls_Empleados_DAL();
            Cls_SP_Empleados_BLL objBLL = new Cls_SP_Empleados_BLL();
            objDal.SIdEmpleado = inp_ID_Emp_Elim.Value.ToString();
           

            objBLL.EliminarEmpleado(ref objDal);
            CargarDatos('L');
            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert([" + objDal.SMsjError + "]);", true);

        }

        protected void btn_Filtrar_Click(object sender, EventArgs e)
        {
     
            CargarDatos('F');
            
        }

   

        private void CargarDatos(char tipo)
        {
            //Declaracion de objetos

            Cls_Empleados_DAL objDAL = new Cls_Empleados_DAL();
            Cls_SP_Empleados_BLL objBLL = new Cls_SP_Empleados_BLL();
            DataTable ObjListar = new DataTable();

            if (tipo == 'F')
            {
                objDAL.SFiltro = inp_Filtrar.Value.ToString();
                ObjListar = objBLL.ListarFiltrar_Empleados(ref objDAL, tipo);
            }
            else
            {
                objDAL.SFiltro = "";
                ObjListar = objBLL.ListarFiltrar_Empleados(ref objDAL, tipo);

            }
            
            //Formateo de Tabla
            Cls_Metodos_BLL ObjBLLMet = new Cls_Metodos_BLL();
            labelTable.Text = ObjBLLMet.FormatearTablaListarEmpleados(ObjListar);

        }


        private void LlenarSelectEstado()
        {

            Cls_SP_Empleados_BLL objBLL = new Cls_SP_Empleados_BLL();
            DataTable ObjListar = new DataTable();
            ObjListar = objBLL.ListaEstados();

            {
                foreach (DataRow row in ObjListar.Rows)
                {
                    //AGREGAMOS LA LISTA DE DATOS AL SELECT, EL PRIMER PARAMETRO ES EL TEXTO Y EL SEGUNDO ES EL VALUE
                    Slc_ID_Estado.Items.Add(new ListItem(row.ItemArray[1].ToString(), row.ItemArray[0].ToString()));
                    slc_IdEstado_AG.Items.Add(new ListItem(row.ItemArray[1].ToString(), row.ItemArray[0].ToString()));
                }
            }
        }

        private void LlenarSelectIdAerolinea()
        {
            Cls_SP_Empleados_BLL objBLL = new Cls_SP_Empleados_BLL();
            DataTable ObjListar = new DataTable();
            ObjListar = objBLL.ListaAerolineas();

            
                foreach (DataRow row in ObjListar.Rows)
                {
                    //AGREGAMOS LA LISTA DE DATOS AL SELECT, EL PRIMER PARAMETRO ES EL TEXTO Y EL SEGUNDO ES EL VALUE
                    slc_ID_Aerolinea.Items.Add(new ListItem(row.ItemArray[1].ToString(), row.ItemArray[0].ToString()));
                    Slc_IdAerolineaAG.Items.Add(new ListItem(row.ItemArray[1].ToString(), row.ItemArray[0].ToString()));
                }
            
        }


        private void LlenarSelectId_Tipo_Empleado()
        {
            Cls_SP_Empleados_BLL objBLL = new Cls_SP_Empleados_BLL();
            DataTable ObjListar = new DataTable();
            ObjListar = objBLL.ListaTipoEmpleado();


            foreach (DataRow row in ObjListar.Rows)
            {
                //AGREGAMOS LA LISTA DE DATOS AL SELECT, EL PRIMER PARAMETRO ES EL TEXTO Y EL SEGUNDO ES EL VALUE

                slc_ID_Tipo_Empleado.Items.Add(new ListItem(row.ItemArray[1].ToString(), row.ItemArray[0].ToString()));
                Slc_IdTipoEmpleadoAG.Items.Add(new ListItem(row.ItemArray[1].ToString(), row.ItemArray[0].ToString()));

              
            }

        }

    }
}