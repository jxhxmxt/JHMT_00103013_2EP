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
        public static void addProd(Product p)
        {
            string sql = String.Format(
                "insert into product" + 
                "where \"idProduct\" = {0};",
                p.IdProduct);
                
            Conexion.nonQuery(sql);
        }
        public static void rmProd(Product p)
        {
            string sql = String.Format(
                "delete from product" + 
                "(\"idBusiness\", name)" +
                "values ('{0}', {1});",
                p.IdBusiness, p.Name);
                
            Conexion.nonQuery(sql);
        }
    }
}