using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using WCF_Proyecto_DAL.BD;


namespace WCF_Proyecto_BLL.BD
{
    public class Cls_BD_BLL
    {        
        public void ExecuteDataAdapter(ref Cls_BD_DAL Obj_BD_DAL)
        {            
            try
            {
                Obj_BD_DAL.ObjSqlCnx = new SqlConnection(ConfigurationManager.ConnectionStrings["Sql_aut"].ToString());

                if (Obj_BD_DAL.ObjSqlCnx.State == ConnectionState.Closed)
                {
                    Obj_BD_DAL.ObjSqlCnx.Open();
                }

                Obj_BD_DAL.ObjSqlDap = new SqlDataAdapter(Obj_BD_DAL.sNombreSP, Obj_BD_DAL.ObjSqlCnx);

                Obj_BD_DAL.ObjSqlDap.SelectCommand.CommandType = CommandType.StoredProcedure;

                Obj_BD_DAL.Ds = new DataSet();

                //ESTA LINEA LO QUE HACE ES EJECUTAR EL SQLDATATAPTER PREVIEMANTE CONSTRUIDO
                Obj_BD_DAL.ObjSqlDap.Fill(Obj_BD_DAL.Ds);

                Obj_BD_DAL.sMsjError = string.Empty;
            }
            catch (SqlException ex)
            {
                Obj_BD_DAL.sMsjError = ex.Message.ToString();
                Obj_BD_DAL.Ds = new DataSet();
            }   
            finally
            {
                if (Obj_BD_DAL.ObjSqlCnx != null)
                {
                    if (Obj_BD_DAL.ObjSqlCnx.State == ConnectionState.Open)
                    {
                        Obj_BD_DAL.ObjSqlCnx.Close();
                    }

                    Obj_BD_DAL.ObjSqlCnx.Dispose();
                }
            }                     
        }
                
        public void ExecuteNonQuery(ref Cls_BD_DAL Obj_BD_DAL)
        {
            try
            {
                Obj_BD_DAL.ObjSqlCnx = new SqlConnection(ConfigurationManager.ConnectionStrings["Sql_aut"].ToString());

                if (Obj_BD_DAL.ObjSqlCnx.State == ConnectionState.Closed)
                {
                    Obj_BD_DAL.ObjSqlCnx.Open();
                }

                Obj_BD_DAL.ObjSqlCmd = new SqlCommand(Obj_BD_DAL.sNombreSP, Obj_BD_DAL.ObjSqlCnx);

                #region DEFINICIÓN DE PARAMETROS

                if ((Obj_BD_DAL.DtParametros != null) && (Obj_BD_DAL.DtParametros.Rows.Count >= 1))
                {
                    SqlDbType DBType = SqlDbType.VarChar;

                    foreach (DataRow DR in Obj_BD_DAL.DtParametros.Rows)
                    {
                        switch (DR[1].ToString())
                        {
                            case "1":
                                DBType = SqlDbType.NVarChar;
                                break;
                            case "2":
                                DBType = SqlDbType.Int;
                                break;
                            case "3":
                                DBType = SqlDbType.DateTime;
                                break;
                            case "4":
                                DBType = SqlDbType.Decimal;
                                break;
                            case "5":
                                DBType = SqlDbType.Char;
                                break;

                            default:
                                break;
                        }

                        Obj_BD_DAL.ObjSqlCmd.Parameters.Add(DR[0].ToString(), DBType).Value = DR[2].ToString();
                    }
                }

                #endregion

                Obj_BD_DAL.ObjSqlCmd.CommandType = CommandType.StoredProcedure;

                Obj_BD_DAL.Ds = new DataSet();

                Obj_BD_DAL.ObjSqlCmd.ExecuteNonQuery();

                Obj_BD_DAL.sMsjError = string.Empty;
            }
            catch (SqlException ex)
            {
                Obj_BD_DAL.sMsjError = ex.Message.ToString();
                Obj_BD_DAL.Ds = new DataSet();
            }
            finally
            {
                if (Obj_BD_DAL.ObjSqlCnx != null)
                {
                    if (Obj_BD_DAL.ObjSqlCnx.State == ConnectionState.Open)
                    {
                        Obj_BD_DAL.ObjSqlCnx.Close();
                    }

                    Obj_BD_DAL.ObjSqlCnx.Dispose();
                }
            }
        }

        public void ExecuteScalar(ref Cls_BD_DAL Obj_BD_DAL)
        {
            try
            {
                Obj_BD_DAL.ObjSqlCnx = new SqlConnection(ConfigurationManager.ConnectionStrings["Sql_aut"].ToString());

                if (Obj_BD_DAL.ObjSqlCnx.State == ConnectionState.Closed)
                {
                    Obj_BD_DAL.ObjSqlCnx.Open();
                }

                Obj_BD_DAL.ObjSqlCmd = new SqlCommand(Obj_BD_DAL.sNombreSP, Obj_BD_DAL.ObjSqlCnx);

                #region DEFINICIÓN DE PARAMETROS

                if ((Obj_BD_DAL.DtParametros != null) && (Obj_BD_DAL.DtParametros.Rows.Count >= 1))
                {
                    SqlDbType DBType = SqlDbType.VarChar;

                    foreach (DataRow DR in Obj_BD_DAL.DtParametros.Rows)
                    {
                        switch (DR[1].ToString())
                        {
                            case "1":
                                DBType = SqlDbType.NVarChar;
                                break;
                            case "2":
                                DBType = SqlDbType.Int;
                                break;
                            case "3":
                                DBType = SqlDbType.DateTime;
                                break;
                            case "4":
                                DBType = SqlDbType.Decimal;
                                break;
                            default:
                                break;
                        }

                        Obj_BD_DAL.ObjSqlCmd.Parameters.Add(DR[0].ToString(), DBType).Value = DR[2].ToString();
                    }
                }

                #endregion

                Obj_BD_DAL.ObjSqlCmd.CommandType = CommandType.StoredProcedure;

                Obj_BD_DAL.Ds = new DataSet();

                Obj_BD_DAL.sValorScalar = Obj_BD_DAL.ObjSqlCmd.ExecuteScalar().ToString();

                Obj_BD_DAL.sMsjError = string.Empty;
            }
            catch (SqlException ex)
            {
                Obj_BD_DAL.sMsjError = ex.Message.ToString();
                Obj_BD_DAL.sValorScalar = "-1";
                Obj_BD_DAL.Ds = new DataSet();
            }
            finally
            {
                if (Obj_BD_DAL.ObjSqlCnx != null)
                {
                    if (Obj_BD_DAL.ObjSqlCnx.State == ConnectionState.Open)
                    {
                        Obj_BD_DAL.ObjSqlCnx.Close();
                    }

                    Obj_BD_DAL.ObjSqlCnx.Dispose();
                }
            }

            
        }
    }
}
