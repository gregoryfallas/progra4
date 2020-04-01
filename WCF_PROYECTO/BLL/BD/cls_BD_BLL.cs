using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using DAL.BD;

namespace BLL.BD
{
    public class cls_BD_BLL
    {
        public string ConectarBD()
        {
            try
            {
                cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

                //leo el app config
                Obj_BD_DAL.sCadenaConec = ConfigurationManager.ConnectionStrings[0].ToString();

                //creo el objeto sqlconnection
                Obj_BD_DAL.Obj_SQL_CNX = new SqlConnection(Obj_BD_DAL.sCadenaConec);

                //abrir la cnx
                if (Obj_BD_DAL.Obj_SQL_CNX.State == ConnectionState.Closed)
                {
                    Obj_BD_DAL.Obj_SQL_CNX.Open();
                }

                return string.Empty;
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();                
            }
        }

    }
}
