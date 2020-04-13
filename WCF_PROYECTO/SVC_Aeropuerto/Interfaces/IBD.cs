using System;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVC_Aeropuerto.Interfaces
{
    [ServiceContract]
    interface IBD
    {
        [OperationContract]
        DataTable CrearDTParametros();

        [OperationContract]
        DataTable ListarFiltrarDatos(string sNombreSP, DataTable DT_Parametros, ref string sMsjError);

        [OperationContract]
        String Ins_Mod_Eli_Datos(string sNombreSP, bool bBandera, DataTable DT_Parametros, ref string sMsjError);
    }
}
