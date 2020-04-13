using System;
using System.Data;
using DAL.Catalogo_DAL;
using BLL.WCF_Aerolinea_BD;
using BLL.WCF_BD;


namespace BLL.Catalogo_BLL
{
    public class Cls_SP_Empleados_BLL
    {

        public DataTable ListarEmpleados(ref Cls_Empleados_DAL objDAL)
        {
            DataTable ds = new DataTable();
            string _sMensajeError = "";
            objDAL.SStoreProcedure = "SP_Listar_Empleados";
           WCF_BD.BDClient Cliente = new BDClient();
            DataTable parametros = new DataTable();
            parametros = null;

            try
            {

                ds = Cliente.ListarFiltrarDatos(objDAL.SStoreProcedure, parametros, ref _sMensajeError);
            }
            finally
            {
               Cliente.Close();
            }


          

            return ds;

        }



   

    }
}
