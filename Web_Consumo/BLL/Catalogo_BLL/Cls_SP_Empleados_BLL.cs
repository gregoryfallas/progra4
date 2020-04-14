using System;
using System.Data;
using DAL.Catalogo_DAL;
using BLL.WCF_Aerolinea_BD;



namespace BLL.Catalogo_BLL
{
    public class Cls_SP_Empleados_BLL
    {

        public DataTable ListarEmpleados(ref Cls_Empleados_DAL objDAL, DataTable DtParametros)
        {
            DataTable ds = new DataTable();
            string _sMensajeError = "";
            objDAL.SStoreProcedure = "SP_Listar_Empleados";
            BD Cliente = new BD();
         
           try
            {

                ds = Cliente.ListarFiltrarDatos(objDAL.SStoreProcedure, DtParametros, ref _sMensajeError);
            }
            finally
            {
                Cliente.Dispose();
            }
            return ds;
        }

        public DataTable FiltrarEmpleados(ref Cls_Empleados_DAL objDAL, DataTable DtParametros)
        {
            DataTable ds = new DataTable();
            string _sMensajeError = "";
            objDAL.SStoreProcedure = "SP_Listar_Empleados";
            BD Cliente = new BD();

            try
            {

                ds = Cliente.ListarFiltrarDatos(objDAL.SStoreProcedure, DtParametros, ref _sMensajeError);
            }
            finally
            {
                Cliente.Dispose();
            }
            return ds;
        }




    }
}
