using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WCF_Proyecto_DAL.BD
{
    public class Cls_BD_DAL
    {
        #region VARIABLES PRIVADAS

            private string _sMsjError, _sCadenaConexion, 
                           _sValorScalar, _sNombreSP;

            private SqlCommand _Obj_SqlCmd;
            private SqlDataAdapter _Obj_SqlDap;
            private SqlConnection _Obj_SqlCnx;

            private DataSet _Ds;

            private DataTable _DtParametros;

        #endregion

        #region CONSTRUCTORES O VARIABES PUBLICAS

            public string sMsjError
            {
                get
                {
                    return _sMsjError;
                }

                set
                {
                    _sMsjError = value;
                }
            }

            public string sCadenaConexion
            {
                get
                {
                    return _sCadenaConexion;
                }

                set
                {
                    _sCadenaConexion = value;
                }
            }

            public string sValorScalar
            {
                get
                {
                    return _sValorScalar;
                }

                set
                {
                    _sValorScalar = value;
                }
            }

            public SqlCommand ObjSqlCmd
            {
                get
                {
                    return _Obj_SqlCmd;
                }

                set
                {
                    _Obj_SqlCmd = value;
                }
            }

            public SqlDataAdapter ObjSqlDap
            {
                get
                {
                    return _Obj_SqlDap;
                }

                set
                {
                    _Obj_SqlDap = value;
                }
            }

            public SqlConnection ObjSqlCnx
            {
                get
                {
                    return _Obj_SqlCnx;
                }

                set
                {
                    _Obj_SqlCnx = value;
                }
            }

            public DataSet Ds
            {
                get
                {
                    return _Ds;
                }

                set
                {
                    _Ds = value;
                }
            }

            public DataTable DtParametros
            {
                get
                {
                    return _DtParametros;
                }

                set
                {
                    _DtParametros = value;
                }
            }

            public string sNombreSP
            {
                get
                {
                    return _sNombreSP;
                }

                set
                {
                    _sNombreSP = value;
                }
            }


        #endregion
    }
}
