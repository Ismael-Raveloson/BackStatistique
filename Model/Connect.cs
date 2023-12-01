using System;
using System.Data.SqlClient;

namespace Gendarmerie.Models{
    public class Connect
    {
        public SqlConnection connect(){
        //parameter
            string connString = "Server=(localdb)\\MSSQLLocalDB;Database=statistique;Trusted_Connection=True;";
        
        //connection
            SqlConnection conn = new SqlConnection(connString);
            return conn;
            
        }
    }
}

