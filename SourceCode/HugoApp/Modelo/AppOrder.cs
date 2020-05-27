using System;

namespace HugoApp.Modelo
{
    public class AppOrder
    {
        public int IdUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int IdProduct { get; set; }
        public int IdAddress { get; set; }

        public AppOrder() { }

        public AppOrder(int pIdUser, DateTime pCreateDate, int pIdProduct, 
            int pIdAddress)
        {
            IdUser = pIdUser;
            CreateDate = pCreateDate;
            IdProduct = pIdProduct;
            IdAddress = pIdAddress;
        }
    }
}