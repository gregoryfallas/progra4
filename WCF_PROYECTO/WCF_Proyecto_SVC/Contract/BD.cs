using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using WCF_Proyecto_BLL.BD;
using WCF_Proyecto_DAL.BD;

namespace WCF_Proyecto_SVC.Contract
{
    public class BD : Interface.IBD
    {
        public DataTable CrearDTParametros()
        {
            DataTable dt = new DataTable("Parametros");

            dt.Columns.Add("NOM_PARAM");
            dt.Columns.Add("TIPO_DATO");
            dt.Columns.Add("VALOR");

            return dt;
        }

        public DataTable ListarFiltrarDatos(string sNombreSP, DataTable DT_Parametros, ref string sMsjError)
        {//public DataTable ListarFiltrarDatos(string sNombreSP, DataTable DT_Parametros, ref string sMsjError) Oscar Quiros
            Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
            Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();

            Obj_BD_DAL.sNombreSP = sNombreSP;            

            Obj_BD_BLL.ExecuteDataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                return Obj_BD_DAL.Ds.Tables[0];
            }
            else
            {
                sMsjError = Obj_BD_DAL.sMsjError;
                return null;
            }
        }

        public string Ins_Mod_Del_Datos(string sNombreSP, bool bBandera, DataTable DT_Parametros, ref string sMsjError)
        {
            Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
            Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();

            Obj_BD_DAL.sNombreSP = sNombreSP;
            Obj_BD_DAL.DtParametros = DT_Parametros;

            if (bBandera == false)
            {
                Obj_BD_BLL.ExecuteNonQuery(ref Obj_BD_DAL);
            }
            else
            {
                Obj_BD_BLL.ExecuteScalar(ref Obj_BD_DAL);
            }

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                return Obj_BD_DAL.sValorScalar;
            }
            else
            {
                sMsjError = Obj_BD_DAL.sMsjError;
                return string.Empty;
            }
        }
 
    }
}
