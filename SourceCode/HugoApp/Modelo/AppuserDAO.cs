using System;
using System.Collections.Generic;
using System.Data;

namespace HugoApp.Modelo
{
    public class AppuserDAO
    {
    public static List<Appuser> getLista()
        {
            string sql = "select * from appuser";

            DataTable dt = Conexion.query(sql);
            
            List<Appuser> lista = new List<Appuser>();
            foreach (DataRow fila in dt.Rows)
            {
                Appuser u = new Appuser();
                u.IdUser = Convert.ToInt32(fila[0].ToString());
                u.Fullname = fila[1].ToString();
                u.Username = fila[2].ToString();
                u.Password = fila[3].ToString();
                u.UserType = Convert.ToBoolean(fila[4].ToString());
                
                lista.Add(u);
            }

            return lista;
        }
        
        public static List<Appuser> getLista(Appuser usu)
        {
            string sql = String.Format("select * from appuser " +
                                       "where \"idUser\" = {0};",
                usu.IdUser);

            DataTable dt = Conexion.query(sql);
            
            List<Appuser> lista = new List<Appuser>();
            foreach (DataRow fila in dt.Rows)
            {
                Appuser u = new Appuser();
                u.IdUser = Convert.ToInt32(fila[0].ToString());
                u.Fullname = fila[1].ToString();
                u.Username = fila[2].ToString();
                u.Password = fila[3].ToString();
                u.UserType = Convert.ToBoolean(fila[4].ToString());
                
                lista.Add(u);
            }

            return lista;
        }

        public static void addAppuser(Appuser u)
        {
            string sql = String.Format(
                "insert into appuser" + 
                "(fullname, username, password, userType)" +
                "values ('{0}', '{1}', '{2}', '{3}');",
                u.Fullname, u.Username, u.Password, u.UserType.ToString());
                
            Conexion.nonQuery(sql);
        }
        
        public static void updateAppuser(int idUser, string newPassword)
        {
            string sql = String.Format(
                "update appuser set password='{0}' where \"idUser\"={1};",
                newPassword, idUser);
            
            Conexion.nonQuery(sql);
        }
        public static void updateAppuserType(int idUser, bool userType)
        {
            string sql = String.Format(
                "update appuser set userType={0} where \"idUser\" ='{1}';",
                userType ? "true" : "false", idUser);
            
            Conexion.nonQuery(sql);
        }

        public static void delete(int idUser)
        {
            string sql = String.Format(
                "delete from registro where \"idusuario\" ='{0}'; " +
                "delete from pedidos where \"idUsuario\" ='{0}'; " +
                "delete from appuser where \"idUser\"='{0}';",
                idUser);
            
            Conexion.nonQuery(sql);
        }
    }
}
