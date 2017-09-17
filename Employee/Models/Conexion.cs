using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Employee.Models
{
    public  class Conexion
    {
        private static volatile IDbConnection instance;
        private static object syncRoot = new object();
        private Conexion()
        {
        }
        public static IDbConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new SqlConnection(ConfigurationManager.ConnectionStrings["ModelEmployee"].ConnectionString);
                    }
                }
                
                return instance;
            }
        }
    }
}