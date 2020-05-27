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
    }
}