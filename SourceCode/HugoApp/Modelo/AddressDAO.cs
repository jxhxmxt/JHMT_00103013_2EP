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
        
        public static List<Address> getLista(Appuser appuser)
        {
            string sql = String.Format("SELECT ad.idAddress, ad.address FROM ADDRESS ad WHERE idUser = {0};",
                appuser.IdUser);

            DataTable dt = Conexion.query(sql);
            
            List<Address> lista = new List<Address>();
            foreach (DataRow fila in dt.Rows)
            {
                Address a = new Address();
                a.IdAddress = Convert.ToInt32(fila[0].ToString());
                a.IdUser = appuser.IdUser;
                a.Addr = fila[1].ToString();
                
                lista.Add(a);
            }

            return lista;
        }
        public static void addAddress(int idUser,string addr)
        {
            string sql = String.Format(
                "insert into address (idUser, address) " +
                "values({0}, '{1}');",
                idUser , addr);
                
            Conexion.nonQuery(sql);
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
        public static void removeAddress(Address a)
        {
            string sql = String.Format(
                "DELETE FROM ADDRESS WHERE idAddress = {0};",
                a.IdAddress);
                
            Conexion.nonQuery(sql);
        }
    }
}