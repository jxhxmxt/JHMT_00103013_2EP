using System.Data;
using Npgsql;

namespace HugoApp.Modelo
{
    public class Conexion
        {
            private static string host = "127.0.0.1",
                database = "hugo",
                userID = "postgres",
                password = "uca";

            private static string sConnection =
                $"Server={host};Port=5432;User Id={userID};Password={password};Database={database};";
            //$"sslmode=Regquire;Trust Server Certificate = true";
        
            public static DataTable query(string sql)
            {
                NpgsqlConnection conn = new NpgsqlConnection(sConnection);
                DataSet ds = new DataSet();
            
                conn.Open();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                da.Fill(ds);
                conn.Close();
            
                return ds.Tables[0];
            }

            public static void nonQuery(string sql)
            {
                NpgsqlConnection conn = new NpgsqlConnection(sConnection);
            
                conn.Open();
                NpgsqlCommand nc = new NpgsqlCommand(sql, conn);
                nc.ExecuteNonQuery();
                conn.Close();
            } 
        }
}