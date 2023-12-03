using System;
using System.Data.SqlClient;

namespace Gendarmerie.Models{
    public class Connect
    {
        public SqlConnection connect(){
        //parameter
            string connString ="Server=tcp:sqlisma.database.windows.net,1433;Initial Catalog=Statistique;Persist Security Info=False;User ID=Ismael;Password=Isma1912;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        
        //connection
            SqlConnection conn = new SqlConnection(connString);
            return conn;
            
        }
    }
}

