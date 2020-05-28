using System;

namespace HugoApp.Modelo
{
    public class AppOrder
    {
        public int IdOrder { get; set; }
        public DateTime CreateDate { get; set; }
        public int IdProduct { get; set; }
        public int IdAddress { get; set; }

        public AppOrder() { }

        public AppOrder(int pIdOrder, DateTime pCreateDate, int pIdProduct, 
            int pIdAddress)
        {
            IdOrder = pIdOrder;
            CreateDate = pCreateDate;
            IdProduct = pIdProduct;
            IdAddress = pIdAddress;
        }
    }
}