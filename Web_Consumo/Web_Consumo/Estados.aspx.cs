using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Web_Consumo
{
     public partial class Estados : System.Web.UI.Page
    //public partial class Estados : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            #region VARIABLES LOCALES

            DataTable dt = new DataTable();
            DataTable dtParametros = new DataTable();
            WCF_BD.BDClient Obj_WCF_BD = new WCF_BD.BDClient();

            string sNombSP = string.Empty;
            string sMsjError = string.Empty;

            #endregion

            if (txt_filtroEstados.Text == string.Empty)
            {//ESTE LISTA LA INFORMACION DE LA TABLA
                dtParametros = null;
                sNombSP = "SP_Listar_Estados";
            }
            else
            {   //ESTE PROCESO  REALIZA EL FILTRADO
                dtParametros = Obj_WCF_BD.CrearDTParametros();
                dtParametros.Rows.Add("@filtro", "2", txt_filtroEstados.Text.Trim());
                sNombSP = "SP_Filtrar_Estados";
         
            }

            dt = Obj_WCF_BD.ListarFiltrarDatos(sNombSP, dtParametros, ref sMsjError);

            DGV_DATOS.DataSource = null;
            DGV_DATOS.DataSource = dt;
            DGV_DATOS.DataBind();
           
        }

        protected void btn_FiltrarEstados_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        protected void txt_filtroEstados_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        protected void btn_Insertar_Click(object sender, EventArgs e)
        {
            #region VARIABLES LOCALES

            DataTable dtParametros = new DataTable();
            WCF_BD.BDClient Obj_WCF_BD = new WCF_BD.BDClient();

            string sNombSP = string.Empty;
            string sMsjError = string.Empty;

            #endregion

            dtParametros = Obj_WCF_BD.CrearDTParametros();
            dtParametros.Rows.Add("@IdEstado", "3", txt_ID_Estados.Text.Trim());
            dtParametros.Rows.Add("@Descripcion", "1", txt_Nombre_Estado.Text.Trim());
            sNombSP = "SP_Insertar_Estados";

            Obj_WCF_BD.Ins_Mod_Eli_Datos(sNombSP, false, dtParametros, ref sMsjError);

            //ESTO MUESTRA UN ERROR EN PANTALLA AL USUARIO
            if (sMsjError != string.Empty)
            {   //DEFINE EL MENSAJE A MOSTRAR
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Se presento un error a la hora de insertar el estado.');", true);
            }

            txt_filtroEstados.Text = string.Empty;
            txt_ID_Estados.Text = string.Empty;
            txt_Nombre_Estado.Text = string.Empty;

            CargarDatos();
        }
    }
}