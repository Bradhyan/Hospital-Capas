﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Cdatos
{
    public class CDConexion
    {
        public SqlConnection conectar(String Cnx)
        {
            try
            {
                SqlConnection oconectar = new SqlConnection(ConfigurationSettings.AppSettings[Cnx].ToString());
                oconectar.Open();
                return oconectar;
            }
            catch (Exception err)

            {

                throw new Exception(err.Message);
            }
        }

            
    }
}
