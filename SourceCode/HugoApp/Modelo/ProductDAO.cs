using System;
using System.Collections.Generic;
using System.Data;
using HugoApp.Controlador;

namespace HugoApp.Modelo
{
    public class ProductDAO
    
    {
        public static List<Product> getLista()
        {
            string sql = "select * from product";

            DataTable dt = Conexion.query(sql);
            
            List<Product> lista = new List<Product>();
            foreach (DataRow fila in dt.Rows)
            {
                Product p = new Product();
                p.IdProduct = Convert.ToInt32(fila[0].ToString());
                p.IdBusiness = Convert.ToInt32(fila[1].ToString());
                p.Name = fila[2].ToString();
                
                lista.Add(p);
            }

            return lista;
        }
        
        public static List<Product> getLista(Business b)
        {
            string sql = String.Format("select * from product " +
                                       "where \"idBusiness\" = {0};",
                b.IdBusiness);

            DataTable dt = Conexion.query(sql);
            
            List<Product> lista = new List<Product>();
            foreach (DataRow fila in dt.Rows)
            {
                Product p = new Product();
                p.IdProduct = Convert.ToInt32(fila[0].ToString());
                p.IdBusiness = Convert.ToInt32(fila[1].ToString());
                p.Name = fila[2].ToString();
                
                lista.Add(p);
            }

            return lista;
        }
    }
}