using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjectICT
{
    class ClassDBConnect
    {
        public MySqlConnection connectDB;

     
        public ClassDBConnect()
        {
            
            String host = "localhost";
            String port = "3306";
            String user = "root";
            String pass = "";
            String database = "shop database";
            String strConnet = "datasource=" + host + ";port=" + port + ";username=" + user + ";password=" + pass + ";database=" + database + ";";

            connectDB = new MySqlConnection(strConnet);
        }
    }
}
