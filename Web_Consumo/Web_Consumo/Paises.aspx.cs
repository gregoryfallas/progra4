using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Web_Consumo
{
    public partial class Paises : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDatos();
            LimpiarInputs();
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

            if (txt_buscar.Value == string.Empty)
            {
                dtParametros = null;
                sNombSP = "dbo.SP_Listar_Paises";
            }
            else
            {
                dtParametros = Obj_WCF_BD.CrearDTParametros();
                dtParametros.Rows.Add("@filtro", "0", txt_buscar.Value.Trim());
                sNombSP = "dbo.SP_Filtrar_Paises";
            }

            dt = Obj_WCF_BD.ListarFiltrarDatos(sNombSP, dtParametros, ref sMsjError);

            DGV_DATOS.DataSource = null;
            DGV_DATOS.DataSource = dt;
            DGV_DATOS.DataBind();
        }
        private void LimpiarInputs()
        {
            txt_buscar.Value = string.Empty;
            TXT_ID_ESTADO.Value = string.Empty;
            TXT_NOMBRE_PAIS.Value = string.Empty;
            TXT_COD.Value = string.Empty;
            TXT_ID_PAIS.Value = string.Empty;
            TXT_COD_AREA.Value = string.Empty;
        }
        protected void BTN_INSERT_Click(object sender, EventArgs e)
        {
            #region VARIABLES LOCALES

            DataTable dtParametros = new DataTable();
            WCF_BD.BDClient Obj_WCF_BD = new WCF_BD.BDClient();

            string sNombSP = string.Empty;
            string sMsjError = string.Empty;

            #endregion

            dtParametros = Obj_WCF_BD.CrearDTParametros();
            dtParametros.Rows.Add("@NombrePais", "1", TXT_NOMBRE_PAIS.Value.Trim());
            dtParametros.Rows.Add("@CodigoISOPais", "3", TXT_COD.Value.Trim());
            dtParametros.Rows.Add("@CodigoAreaPais", "3", TXT_COD_AREA.Value.Trim());
            dtParametros.Rows.Add("@IdEstado", "3", TXT_ID_ESTADO.Value.Trim());

            sNombSP = "dbo.SP_Insertar_Paises";

            Obj_WCF_BD.Ins_Mod_Eli_Datos(sNombSP, false, dtParametros, ref sMsjError);

            txt_buscar.Value = string.Empty;
            TXT_ID_ESTADO.Value = string.Empty;
            TXT_NOMBRE_PAIS.Value = string.Empty;

            CargarDatos();
            LimpiarInputs();
        }

        protected void BTN_MODIFICAR_Click(object sender, EventArgs e)
        {
            #region VARIABLES LOCALES

            DataTable dtParametros = new DataTable();
            WCF_BD.BDClient Obj_WCF_BD = new WCF_BD.BDClient();

            string sNombSP = string.Empty;
            string sMsjError = string.Empty;

            #endregion

            dtParametros = Obj_WCF_BD.CrearDTParametros();
            dtParametros.Rows.Add("@IdPais", "2", TXT_ID_PAIS.Value.Trim());
            dtParametros.Rows.Add("@NombrePais", "1", TXT_NOMBRE_PAIS.Value.Trim());
            dtParametros.Rows.Add("@CodigoISOPais", "3", TXT_COD.Value.Trim());
            dtParametros.Rows.Add("@CodigoAreaPais", "3", TXT_COD_AREA.Value.Trim());
            dtParametros.Rows.Add("@IdEstado", "3", TXT_ID_ESTADO.Value.Trim());

            sNombSP = "dbo.SP_Modificar_Paises";

            Obj_WCF_BD.Ins_Mod_Eli_Datos(sNombSP, false, dtParametros, ref sMsjError);


            LimpiarInputs();
            CargarDatos();
        }
        protected void btn_Eliminar_Click(object sender, EventArgs e)
        {
            #region VARIABLES LOCALES

            DataTable dtParametros = new DataTable();
            WCF_BD.BDClient Obj_WCF_BD = new WCF_BD.BDClient();

            string sNombSP = string.Empty;
            string sMsjError = string.Empty;

            #endregion

            dtParametros = Obj_WCF_BD.CrearDTParametros();
            dtParametros.Rows.Add("@IdPais", "2", TXT_ID_PAIS.Value.Trim());
            sNombSP = "dbo.SP_Borrar_Paises";

            Obj_WCF_BD.Ins_Mod_Eli_Datos(sNombSP, false, dtParametros, ref sMsjError);

            txt_buscar.Value = string.Empty;
            LimpiarInputs();
            CargarDatos();
        }

        protected void btn_Buscar_Click(object sender, EventArgs e)
        {
            CargarDatos();


        }
    }
}