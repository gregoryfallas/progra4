using System;
using System.Data;
using DAL.Catalogo_DAL;
using BLL.WCF_BD;


/*namespace BLL.Catalogo_BLL
{
    public class Cls_SP_Destinos_BLL
    {

        public class Cls_SP_Empleados_BLL
        {

            public DataTable ListarFiltrar_Destinos(ref Cls_Destinos_DAL objDAL, char tipo)
            {
                Cls_Metodos_BLL BLL_Met = new Cls_Metodos_BLL();
                DataTable parametros = new DataTable();
                DataTable ds = new DataTable();
                parametros = BLL_Met.CrearDtParametros();
                string sMsjError = objDAL.SMsjError;

                BD Cliente = new BD();

                if (tipo == 'L')
                {
                    try
                    {
                        objDAL.SStoreProcedure = "SP_Listar_Destinos";
                        parametros = null;
                        ds = Cliente.ListarFiltrarDatos(objDAL.SStoreProcedure, parametros, ref sMsjError);
                    }
                    finally
                    {
                        Cliente.Dispose();
                    }

                }
                else
                {
                    try
                    {
                        objDAL.SStoreProcedure = "SP_Listar_Destinos";
                        parametros.Rows.Add("@filtro", "1", objDAL.SFiltro);
                        ds = Cliente.ListarFiltrarDatos(objDAL.SStoreProcedure, parametros, ref sMsjError);
                    }
                    finally
                    {
                        Cliente.Dispose();
                    }
                }

                return ds;
            }


           public string EditarDestinos(ref Cls_Destinos_DAL objDAL)
            {

                Cls_Metodos_BLL BLL_Met = new Cls_Metodos_BLL();
                DataTable parametros = new DataTable();
                parametros = BLL_Met.CrearDtParametros();
                objDAL.SStoreProcedure = "SP_Modificar_Destinos";
                string sMsjError = objDAL.SMsjError;
                BD Cliente = new BD();

                try
                {
                    if (objDAL.SIdDestino != "" && objDAL.IIdAerolinea != 0 &&
                        objDAL.SNomDestino != "" && objDAL.IPaisSalida != 0 &&
                        objDAL.IPaisLlegada != 0 && objDAL.CIdEstado != ' ')
                    {

                        parametros.Rows.Add("@IdEmpleado", "1", objDAL.SIdEmpleado);
                        parametros.Rows.Add("@Cedula", "1", objDAL.SCedula);
                        parametros.Rows.Add("@Nombre", "1", objDAL.SNombre);
                        parametros.Rows.Add("@Apellidos", "1", objDAL.SApellidos);
                        parametros.Rows.Add("@Direccion", "1", objDAL.SDireccion);
                        parametros.Rows.Add("@Edad", "2", objDAL.IEdad);
                        parametros.Rows.Add("@Telefono_Casa", "1", objDAL.STelefonoCasa);
                        parametros.Rows.Add("@Telefono_Referencia", "1", objDAL.STelefonoReferencia);
                        parametros.Rows.Add("@Celular", "1", objDAL.SCelular);
                        parametros.Rows.Add("@Salario", "4", objDAL.DSalario);
                        parametros.Rows.Add("@IdTipoEmpleado", "2", objDAL.IIdTipoEmpleado);
                        parametros.Rows.Add("@idAerolinea", "2", objDAL.IIdAerolinea);
                        parametros.Rows.Add("@IdEstado", "3", objDAL.CIdEstado);

                        Cliente.Ins_Mod_Eli_Datos(objDAL.SStoreProcedure, false, false, parametros, ref sMsjError);
                        objDAL.SMsjError = "CAMPO MODIFICADO CORRECTAMENTE";
                        objDAL.SFiltro = "OK";

                    }
                    else
                    {
                        objDAL.SMsjError = "PARA MODIFICAR UN ITEM SE DEBEN LLENAR TODOS LOS CAMPOS ";
                        objDAL.SFiltro = "NO";

                    }
                }
                finally
                {
                    Cliente.Dispose();
                }

                return objDAL.SMsjError;
            }

            public string EliminarEmpleado(ref Cls_Empleados_DAL objDAL)
            {
                string sMsjError = objDAL.SMsjError;
                Cls_Metodos_BLL BLL_Met = new Cls_Metodos_BLL();
                DataTable parametros = new DataTable();
                DataTable ds = new DataTable();
                parametros = BLL_Met.CrearDtParametros();
                objDAL.SStoreProcedure = "SP_Borrar_Empleados";
                BD Cliente = new BD();

                try
                {
                    parametros.Rows.Add("@IdEmpleado", "1", objDAL.SIdEmpleado);
                    objDAL.SMsjError = Cliente.Ins_Mod_Eli_Datos(objDAL.SStoreProcedure, false, false, parametros, ref sMsjError);
                }
                catch (Exception Ex)
                {
                    objDAL.SMsjError = Ex.Message;
                }
                finally
                {
                    Cliente.Dispose();

                }

                return objDAL.SMsjError;


            }

            public string AgregarEmpleado(ref Cls_Empleados_DAL objDAL)
            {
                Cls_Metodos_BLL BLL_Met = new Cls_Metodos_BLL();
                DataTable parametros = new DataTable();
                parametros = BLL_Met.CrearDtParametros();
                objDAL.SStoreProcedure = "SP_Insertar_Empleados";
                string sMsjError = objDAL.SMsjError;
                BD Cliente = new BD();

                try
                {
                    if (objDAL.SIdEmpleado != "" && objDAL.SCedula != "" && objDAL.SNombre != ""
                        && objDAL.SApellidos != "" && objDAL.SDireccion != "" && objDAL.IEdad != 0
                        && objDAL.STelefonoCasa != "" && objDAL.STelefonoReferencia != "" && objDAL.SCelular != ""
                        && objDAL.DSalario != 0 && objDAL.IIdTipoEmpleado != 0 && objDAL.IIdAerolinea != 0
                        && objDAL.CIdEstado != '0')
                    {

                        parametros.Rows.Add("@IdEmpleado", "1", objDAL.SIdEmpleado);
                        parametros.Rows.Add("@Cedula", "1", objDAL.SCedula);
                        parametros.Rows.Add("@Nombre", "1", objDAL.SNombre);
                        parametros.Rows.Add("@Apellidos", "1", objDAL.SApellidos);
                        parametros.Rows.Add("@Direccion", "1", objDAL.SDireccion);
                        parametros.Rows.Add("@Edad", "2", objDAL.IEdad);
                        parametros.Rows.Add("@Telefono_Casa", "1", objDAL.STelefonoCasa);
                        parametros.Rows.Add("@Telefono_Referencia", "1", objDAL.STelefonoReferencia);
                        parametros.Rows.Add("@Celular", "1", objDAL.SCelular);
                        parametros.Rows.Add("@Salario", "4", objDAL.DSalario);
                        parametros.Rows.Add("@IdTipoEmpleado", "2", objDAL.IIdTipoEmpleado);
                        parametros.Rows.Add("@idAerolinea", "2", objDAL.IIdAerolinea);
                        parametros.Rows.Add("@IdEstado", "3", objDAL.CIdEstado);

                        Cliente.Ins_Mod_Eli_Datos(objDAL.SStoreProcedure, false, false, parametros, ref sMsjError);
                        objDAL.SMsjError = "CAMPO AGREGADO CORRECTAMENTE";
                        objDAL.SFiltro = "OK";

                    }
                    else
                    {
                        objDAL.SMsjError = "PARA AGREGAR UN ITEM SE DEBEN LLENAR TODOS LOS CAMPOS ";
                        objDAL.SFiltro = "NO";

                    }
                }
                finally
                {
                    Cliente.Dispose();
                }

                return objDAL.SMsjError;
            }


            public DataTable ListaEstados()
            {
                DataTable ds = new DataTable();
                DataTable nula = new DataTable();
                nula = null;
                string Msj = "";

                BD Cliente = new BD();


                ds = Cliente.ListarFiltrarDatos("SP_Listar_Estados", nula, ref Msj);


                return ds;

            }


            public DataTable ListaAerolineas()
            {
                DataTable ds = new DataTable();
                DataTable nula = new DataTable();
                nula = null;
                string Msj = "";

                BD Cliente = new BD();


                ds = Cliente.ListarFiltrarDatos("SP_Listar_Aerolineas", nula, ref Msj);


                return ds;

            }

            public DataTable ListaTipoEmpleado()
            {
                DataTable ds = new DataTable();
                DataTable nula = new DataTable();
                nula = null;
                string Msj = "";

                BD Cliente = new BD();


                ds = Cliente.ListarFiltrarDatos("SP_Listar_TiposEmpleados", nula, ref Msj);


                return ds;

            }



        }
    }*/
