using System;
using System.Collections.Generic;
using System.Data;

namespace HugoApp.Modelo
{
    public class AppOrderDAO
    {
        public static List<AppOrder> getLista()
        {
            string sql = "select * from apporder order by \"idOrder\" desc";

            DataTable dt = Conexion.query(sql);
            
            List<AppOrder> lista = new List<AppOrder>();
            foreach (DataRow fila in dt.Rows)
            {
                AppOrder a = new AppOrder();
                a.IdOrder = Convert.ToInt32(fila[0].ToString());
                a.CreateDate = Convert.ToDateTime(fila[1].ToString());
                a.IdProduct = Convert.ToInt32(fila[2].ToString());
                a.IdAddress = Convert.ToInt32(fila[3].ToString());

                lista.Add(a);
            }

            return lista;
        }
        public static List<AppOrder> getLista(Appuser user)
        {
            string sql = String.Format("select \"ao.idOrder\", \"ao.createDate\", \"ao.idProduct\",  " +
                                       "\"ao.idAddress\" from apporder ao, address ad, product pr, appuser au " +
                                       "where \"ao.idProduct\" = \"pr.idProduct\" " +
                                       "and \"ao.idAddress\" = \"ad.idAddress\" " +
                                       "and \"ad.idUser\" = \"au.idUser\" " +
                                       "and \"au.idUser\" = {0};", user.IdUser);

            DataTable dt = Conexion.query(sql);
            
            List<AppOrder> lista = new List<AppOrder>();
            foreach (DataRow fila in dt.Rows)
            {
                AppOrder a = new AppOrder();
                a.IdOrder = Convert.ToInt32(fila[0].ToString());
                a.CreateDate = Convert.ToDateTime(fila[1].ToString());
                a.IdProduct = Convert.ToInt32(fila[2].ToString());
                a.IdAddress = Convert.ToInt32(fila[3].ToString());

                lista.Add(a);
            }

            return lista;
        }
        public static void addOrder(DateTime fecha, int idProduct, int idAddress)
        {
            string sFecha = fecha.ToString("yyyy/MM/dd");
            
            string sql = String.Format(
                "insert into apporder" + 
                "(\"createDate\", \"idProduct\", \"idAddress\", " +
                "cantidad) values '({0}', {1}, {2});",
                sFecha, idProduct, idAddress);
                
            Conexion.nonQuery(sql);
        }
    }
}