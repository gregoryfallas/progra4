﻿using System;
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
            {
                dtParametros = null;
                sNombSP = "SP_LISTAR_ESTADOS";
            }
            else
            {
                dtParametros = Obj_WCF_BD.CrearDTParametros();
                dtParametros.Rows.Add("@Nombre", "0", txt_filtroEstados.Text.Trim());
                sNombSP = "SP_FILTRAR_ESTADOS";
                // sNombSP = "SCH_GENERAL.SP_FILTRAR_ESTADOS";            
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
    }
}