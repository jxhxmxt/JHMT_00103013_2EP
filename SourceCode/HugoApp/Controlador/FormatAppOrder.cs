using System;

namespace HugoApp.Controlador
{
    public class FormatAppOrder
    {
        public int IdOrder { get; set; }
        public DateTime CreateDate { get; set; }
        public string Name { get; set; }
        public string Fullname { get; set; }
        public string Address { get; set; }
        
        public FormatAppOrder() { }

        public FormatAppOrder(int pIdOrder, DateTime pCreateDate, string pName, string pFullname, string pAddress)
        {
            IdOrder = pIdOrder;
            CreateDate = pCreateDate;
            Name = pName;
            Fullname = pFullname;
            Address = pAddress;
        }
    }
}