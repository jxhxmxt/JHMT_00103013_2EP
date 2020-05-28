using System;
using System.Collections.Generic;
using System.Data;

namespace HugoApp.Modelo
{
    public class AddressDAO
    
    {
        public static List<Address> getLista()
        {
            string sql = "select * from address";

            DataTable dt = Conexion.query(sql);
            
            List<Address> lista = new List<Address>();
            foreach (DataRow fila in dt.Rows)
            {
                Address a = new Address();
                a.IdAddress = Convert.ToInt32(fila[0].ToString());
                a.IdUser = Convert.ToInt32(fila[1].ToString());
                a.Addr = fila[2].ToString();
                
                lista.Add(a);
            }

            return lista;
        }
        
        public static List<Product> getLista(Appuser appuser)
        {
            string sql = String.Format("select * from address " +
                                       "where \"idUser\" = {0};",
                appuser.IdUser);

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
        public static void updateAddress(Address a,Appuser u, string addr)
        {
            string sql = String.Format(
                "update address " +
                "SET address={0} " +
                "WHERE \"idAddress\"={1} " +
                "AND \"idUser\"={2};",
                addr , a.IdAddress , u.IdUser);
                
            Conexion.nonQuery(sql);
        }
        public static void removeAddress(Address a,Appuser u)
        {
            string sql = String.Format(
                "delete from address " +
                "WHERE \"idAddress\"={0} " +
                "AND \"idUser\"={1};",
                a.IdAddress , u.IdUser);
                
            Conexion.nonQuery(sql);
        }
    }
}