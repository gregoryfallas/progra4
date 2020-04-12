using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace WCF_Proyecto_SVC.Interface
{        
    [ServiceContract]
    public interface IBD
    {
        [OperationContract]
        DataTable CrearDTParametros();


        [OperationContract]

        DataTable ListarFiltrarDatos(string sNombreSP, DataTable DT_Parametros, ref string sMsjError);
                       

        [OperationContract]
        string Ins_Mod_Del_Datos(string sNombreSP, bool bBandera, DataTable DT_Parametros, ref string sMsjError);
              
    }
}
