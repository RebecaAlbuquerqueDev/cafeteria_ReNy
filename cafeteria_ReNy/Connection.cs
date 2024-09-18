using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace cafeteria_ReNy
{
    internal class Connection
    {
        private SqlConnection con;
        private string DataBase = "PR2CJ3022528BDRenyCafeteria";
        private string Server = "sqlexpress";
        private string Username = "aluno";
        private string Password = "aluno";

        public Connection ()
        {
            string stringConnection = @"Data Sourse = " + Server
                + "; Initial Catalog = " + DataBase
                + "; User Id = " + Username
                + "; Password = " + Password
                + "; Encrypt = false";

            con = new SqlConnection(stringConnection);
            con.Open();
        }

        public void CloseConnection() 
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
         
        public SqlConnection ReturnConnection()
        {
            return con;
        }
    }
}
