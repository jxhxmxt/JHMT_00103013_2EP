using System;
using System.Collections.Generic;
using System.Data;
using HugoApp.Controlador;

namespace HugoApp.Modelo
{
    public class BusinessDAO
    {
        public static List<Business> getLista()
        {
            string sql = "select * from business";

            DataTable dt = Conexion.query(sql);
            
            List<Business> lista = new List<Business>();
            foreach (DataRow fila in dt.Rows)
            {
                Business b = new Business();
                b.IdBusiness = Convert.ToInt32(fila[0].ToString());
                b.Name = fila[1].ToString();
                b.Description = fila[2].ToString();
                
                lista.Add(b);
            }

            return lista;
        }
        public static List<BusinessxCantidad> businxcantidad()
        {
            string sql = "select \"b.name\" as negocio, sum(cp.cant) as \"total\" " +
                         "from business b, (select \"p.idBusiness\", \"p.name\", count(\"ap.idProduct\") " +
                         "AS \"cant\" from product p, apporder ap where \"p.idProduct\" = \"ap.idProduct\" " +
                         "group by \"p.idProduct\" order by \"p.name\" asc) as cp where \"b.idBusiness\" = " +
                         "\"cp.idBusiness\" group by \"b.idBusiness\"; ";

            DataTable dt = Conexion.query(sql);
            
            List<BusinessxCantidad> lista = new List<BusinessxCantidad>();
            foreach (DataRow fila in dt.Rows)
            {
                BusinessxCantidad b = new BusinessxCantidad();
                b.Name = fila[0].ToString();
                b.Cantidad = Convert.ToInt32(fila[1].ToString());
                
                lista.Add(b);
            }

            return lista;
        }
        
        public static void addBusiness(Business b)
        {
            string sql = String.Format(
                "insert into business" + 
                "(name, description)" +
                "values ('{0}', '{1}');",
                b.Name, b.Description);
                
            Conexion.nonQuery(sql);
        }
    }
}