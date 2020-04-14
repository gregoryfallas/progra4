using System;
using System.Data;
using BLL.Catalogo_BLL;
using BLL.Metodos;
using DAL.Catalogo_DAL;
using System.Text;
using System.Web.UI;
using BLL.WCF_Aerolinea_BD;
using System.Web.UI.WebControls;

namespace Web_Consumo
{
    public partial class empleados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            this.CargarDatos('L');
            this.LlenarSelectEstado();

        }

        protected void btn_Editar_Click(object sender, EventArgs e)
        {
            string sidEmpleado = inp_ID_Empleado.Value.ToString();
            string sCedula  =   inp_Cedula.Value.ToString();
            string sNomb    =   inp_Nombre.Value.ToString();
            string sApell   =   inp_Apellidos.Value.ToString();
            string sDirec   =   inp_Direccion.Value.ToString();
            string sEdad    =   inp_Edad.Value.ToString();
            string sTelCasa =   inp_TelCasa.Value.ToString();
            string sTelRef  =   inp_TelReferencia.Value.ToString();
            string sCelu    =   inp_Celular.Value.ToString();
            string sSalario =   inp_Salario.Value.ToString();
            int iTipoEmpleado = Convert.ToInt32(slc_ID_Tipo_Empleado.ToString());
            int iID_Aerlinea =  Convert.ToInt32(slc_ID_Aerolinea.ToString());
            char cEstado =      Convert.ToChar(Slc_ID_Estado.Value.ToString());

            if (sidEmpleado != "" && sCedula != "" && sNomb != "" && sApell != "" && sDirec != "" && sEdad != "" 
                && sTelCasa != "" && sTelRef != "" && sCelu != "" && sSalario != ""  
                && iTipoEmpleado != 0 && iID_Aerlinea != 0 &&  cEstado != '0')
            {
                BD listarDatos = new BD(); 
                String sMensajeError = "";
                DataTable parametros = new DataTable();
                DataTable ObjListar = new DataTable();

                parametros = listarDatos.CrearDTParametros();
                parametros.Rows.Add("@IdEmpleado", "1", sidEmpleado);
                parametros.Rows.Add("@Cedula", "1", sCedula);
                parametros.Rows.Add("@Nombre", "1", sNomb);
                parametros.Rows.Add("@Apellidos", "1", sApell);
                parametros.Rows.Add("@Direccion", "1", sDirec);
                parametros.Rows.Add("@Edad", "2", sEdad);
                parametros.Rows.Add("@Telefono_Casa", "1", sTelCasa);
                parametros.Rows.Add("@Telefono_Referencia", "1", sTelRef);
                parametros.Rows.Add("@Celular", "1", sCelu);
                parametros.Rows.Add("@Salario", "4", sSalario);
                parametros.Rows.Add("@IdTipoEmpleado", "2", inp_ID_Empleado);
                parametros.Rows.Add("@idAerolinea", "2", iID_Aerlinea);
                parametros.Rows.Add("@IdEstado", "3", cEstado);

                listarDatos.Ins_Mod_Eli_Datos("SP_Modificar_Empleados", false, false, parametros, ref sMensajeError);
                

                if (sMensajeError != string.Empty)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('OCURRIO UN ERROR AL MODIFICAR EL ITEM [" + sNomb + "], ERROR: [" + sMensajeError + "]');", true);
                }
                else
                {
                    CargarDatos('L');
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('SE MODIFICO CORRECTAMENTE');", true);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('PARA MODIFICAR UN ITEM SE DEBEN LLENAR TODOS LOS CAMPOS');", true);
            }
        }

        protected void btn_Eliminar_Click(object sender, EventArgs e)
        {
            string sIdEmp = inp_ID_Empleado.Value.ToString();
            string sDesc =  inp_DESCR_ELIM.Value.ToString();
     
            if (sIdEmp != "" && sDesc != "")
            {

                BD listarDatos = new BD();
                String sMensajeError = "";
                DataTable parametros = new DataTable();
                DataTable ObjListar = new DataTable();


                parametros = listarDatos.CrearDTParametros();
                parametros.Rows.Add("@IdEmpleado", "2", sIdEmp);

                listarDatos.Ins_Mod_Eli_Datos("SP_Borrar_Empleados", false, false, parametros, ref sMensajeError);

                if (sMensajeError != string.Empty)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('OCURRIO UN ERROR AL ELIMINAR EL ITEM [" + sDesc + "], ERROR: [" + sMensajeError + "]');", true);
                }
                else
                {
                    CargarDatos('L');
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('SE ELIMINO CORRECTAMENTE');", true);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('OCURRIO UN ERROR AL LEER LO VALORES, FAVOR INTENTARLO NUEVAMENTE');", true);
            }


        }

        protected void btn_Filtrar_Click(object sender, EventArgs e)
        {

            string sFiltrar = inp_Filtrar.Value.ToString();

            if (sFiltrar == "")
            {
                CargarDatos('L');
            }
            else
            {
                CargarDatos('F');
            }

        }

        protected void btn_Agregar_Click(object sender, EventArgs e)
        {


            string sidEmpleado = inp_IdEmpleadoAG.Value.ToString();
            string sCedula = inp_Cedula.ToString();
            string sNomb = inp_NombreAG.Value.ToString();
            string sApell = inp_ApellidosAG.Value.ToString();
            string sDirec = inp_DireccionAG.Value.ToString();
            string sEdad = inp_EdadAG.Value.ToString();
            string sTelCasa = inp_TelCasaAG.Value.ToString();
            string sTelRef = inp_TelRefAG.Value.ToString();
            string sCelu = inp_CelularAG.Value.ToString();
            string sSalario = inp_SalarioAG.Value.ToString();
            int iTipoEmpleado = Convert.ToInt32(Slc_IdTipoEmpleadoAG.ToString());
            int iID_Aerlinea = Convert.ToInt32(Slc_IdAerolineaAG.ToString());
            char cEstado = Convert.ToChar(slc_IdEstado_AG.Value.ToString());

            if (sidEmpleado != "" && sCedula != "" && sNomb != "" && sApell != "" && sDirec != "" && sEdad != ""
                        && sTelCasa != "" && sTelRef != "" && sCelu != "" && sSalario != ""
                        && iTipoEmpleado != 0 && iID_Aerlinea != 0 && cEstado != '0')
            {
                BD listarDatos = new BD();
                String sMensajeError = "";
                DataTable parametros = new DataTable();
                DataTable ObjListar = new DataTable();

                parametros = listarDatos.CrearDTParametros();
                parametros.Rows.Add("@IdEmpleado", "1", sidEmpleado);
                parametros.Rows.Add("@Cedula", "1", sCedula);
                parametros.Rows.Add("@Nombre", "1", sNomb);
                parametros.Rows.Add("@Apellidos", "1", sApell);
                parametros.Rows.Add("@Direccion", "1", sDirec);
                parametros.Rows.Add("@Edad", "2", sEdad);
                parametros.Rows.Add("@Telefono_Casa", "1", sTelCasa);
                parametros.Rows.Add("@Telefono_Referencia", "1", sTelRef);
                parametros.Rows.Add("@Celular", "1", sCelu);
                parametros.Rows.Add("@Salario", "4", sSalario);
                parametros.Rows.Add("@IdTipoEmpleado", "2", inp_ID_Empleado);
                parametros.Rows.Add("@idAerolinea", "2", iID_Aerlinea);
                parametros.Rows.Add("@IdEstado", "3", cEstado);

                listarDatos.Ins_Mod_Eli_Datos("SP_Modificar_Empleados", true, true, parametros, ref sMensajeError);

                if (sMensajeError != string.Empty)
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('OCURRIO UN ERROR AL AGREGAR EL NUEVO ITEM, ERROR: [" + sMensajeError + "]');", true);
                }
                else
                {
                    CargarDatos('L');
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('SE AGREGO CORRECTAMENTE');", true);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('PARA AGREGAR UN NUEVO ITEM SE DEBEN LLENAR TODOS LOS CAMPOS');", true);
            }

        }


        private void CargarDatos(char tipo)
        {
            //Declaracion de objetos

            BD listarDatos = new BD();
            String sMensajeError = "";
            DataTable parametros = new DataTable();
            DataTable ObjListar = new DataTable();

            if (tipo == 'F')
            {
                parametros = listarDatos.CrearDTParametros();
                parametros.Rows.Add("@filtro", "1", inp_Filtrar.Value.ToString());

                ObjListar = listarDatos.ListarFiltrarDatos("SP_Filtrar_Empleados", parametros, ref sMensajeError);
            }
            else
            {
                parametros = null;
                ObjListar = listarDatos.ListarFiltrarDatos("SP_Listar_Empleados", parametros, ref sMensajeError);
            }

            if (sMensajeError != string.Empty)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('OCURRIO UN ERROR AL CARGAR LOS DATOS, ERROR: [" + sMensajeError + "]');", true);
            }
            else
            {


                //Formateo de Tabla
                Cls_Metodos_BLL ObjBLLMet = new Cls_Metodos_BLL();
                labelTable.Text = ObjBLLMet.FormatearTablaListarEmpleados(ObjListar);
            }
        }

        private void LlenarSelectEstado()
        {
            BD listarDatos = new BD();
            String sMensajeError = "";

            DataTable ObjListar = listarDatos.ListarFiltrarDatos("SP_Listar_Estados", null, ref sMensajeError);

            if (sMensajeError != string.Empty)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('OCURRIO UN ERROR AL CARGAR LOS DATOS DE LOS SELECTS');", true);
            }
            else
            {
                foreach (DataRow row in ObjListar.Rows)
                {
                    //AGREGAMOS LA LISTA DE DATOS AL SELECT, EL PRIMER PARAMETRO ES EL TEXTO Y EL SEGUNDO ES EL VALUE
                    Slc_ID_Estado.Items.Add(new ListItem(row.ItemArray[1].ToString(), row.ItemArray[0].ToString()));
                    slc_IdEstado_AG.Items.Add(new ListItem(row.ItemArray[1].ToString(), row.ItemArray[0].ToString()));
                }
            }
        }


    }
}