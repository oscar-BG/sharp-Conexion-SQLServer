using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace conexionSQLserver
{
    class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection nc = new SqlConnection("SERVER=LAPTOP-2CE4BE9L;DATABASE=visualStudio;Integrated security=true");
            nc.Open();
            return nc;
        }
    }
}
