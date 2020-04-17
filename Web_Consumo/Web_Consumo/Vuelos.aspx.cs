﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;//SE IMPORTA LA LIBRERIA

namespace Web_Consumo
{
    public partial class Vuelos : System.Web.UI.Page
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

            if (txt_filtroVuelos.Text == string.Empty)
            {//ESTE LISTA LA INFORMACION DE LA TABLA
                dtParametros = null;
                sNombSP = "SP_Listar_Vuelos";//TOMA EL SP
            }
            else
            {   //ESTE PROCESO  REALIZA EL FILTRADO
                dtParametros = Obj_WCF_BD.CrearDTParametros();
                dtParametros.Rows.Add("@filtro", "1", txt_filtroVuelos.Text.Trim());
                sNombSP = "SP_Filtrar_Vuelos";

            }

            dt = Obj_WCF_BD.ListarFiltrarDatos(sNombSP, dtParametros, ref sMsjError);

            DGV_DATOSV.DataSource = null;
            DGV_DATOSV.DataSource = dt;
            DGV_DATOSV.DataBind();

        }

        protected void btn_FiltrarVuelos_Click(object sender, EventArgs e)
        {

        }
    }
}