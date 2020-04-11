using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Catalogo_DAL;
using BLL.WCF_Aerolinea_BD;

namespace BLL.Catalogo_BLL
{
    public class Cls_SP_Empleados_BLL
    {

        public DataTable ListarEmpleados(ref Cls_Empleados_DAL objDAL)
        {
            DataTable ds = new DataTable();
            string _sMensajeError = "";
            objDAL.SStoreProcedure = "SP_Listar_Empleados";


            try
            {
                WCF_Aerolinea_BD.BD Consulta = new BD();

                ds = Consulta.ListarDatos(objDAL.SStoreProcedure, ref _sMensajeError);


            }
            catch (Exception ex)
            {

                throw ex;
            }




            return ds;

        }

    }
}
