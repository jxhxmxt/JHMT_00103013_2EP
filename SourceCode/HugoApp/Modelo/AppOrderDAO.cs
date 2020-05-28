using System;
using System.Collections.Generic;
using System.Data;
using HugoApp.Controlador;

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
        public static List<FormatAppOrder> getLista(Appuser user)
        {
            string sql = String.Format("SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address  " +
                                       "FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au " +
                                       "WHERE ao.idProduct = pr.idProduct " +
                                       "AND ao.idAddress = ad.idAddress " +
                                       "AND ad.idUser = au.idUser " +
                                       "AND au.idUser = {0};", user.IdUser);

            DataTable dt = Conexion.query(sql);
            
            List<FormatAppOrder> lista = new List<FormatAppOrder>();
            foreach (DataRow fila in dt.Rows)
            {
                FormatAppOrder a = new FormatAppOrder();
                a.IdOrder = Convert.ToInt32(fila[0].ToString());
                a.CreateDate = Convert.ToDateTime(fila[1].ToString());
                a.Name = fila[2].ToString();
                a.Fullname = fila[3].ToString();
                a.Address = fila[4].ToString();

                lista.Add(a);
            }

            return lista;
        }
        public static void addOrder(DateTime fecha, int idProduct, int idAddress)
        {
            string sFecha = fecha.ToString("yyyy-MM-dd");
            
            string sql = String.Format(
                "INSERT INTO APPORDER(createDate, idProduct, idAddress)" + 
                "values ('{0}', {1}, {2});",
                sFecha, idProduct, idAddress);
                
            Conexion.nonQuery(sql);
        }
    }
}