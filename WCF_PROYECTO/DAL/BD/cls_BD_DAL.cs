using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL.BD
{
    public class cls_BD_DAL
    {
        #region Variables Privadas

            private string _sMsjError, _sCadenaConec;

        #endregion

        #region Variables Públicas

            public string sCadenaConec
            {
                get
                {
                    return _sCadenaConec;
                }

                set
                {
                    _sCadenaConec = value;
                }
            }

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

            public SqlConnection Obj_SQL_CNX;

            public SqlDataAdapter Obj_SQL_DAP;

            public SqlCommand Obj_SQL_CMD;

        #endregion

    }
}
