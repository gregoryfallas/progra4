using System;
using System.Data;
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
           WCF_Aerolinea_BD.BD Cliente = new BD();


            try
            {
                
                ds = Cliente.ListarDatos(objDAL.SStoreProcedure, ref _sMensajeError);
            }
            finally
            {
               Cliente.Dispose();
            }


          

            return ds;

        }



   

    }
}
