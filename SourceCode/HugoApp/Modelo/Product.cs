namespace HugoApp.Modelo
{
    public class Product
    {
        public int IdProduct { get; set; }
        public int IdBusiness { get; set; }
        public string Name { get; set; }

        public Product() { }

        public Product(int pIdProduct, int pIdBusiness, string pName)
        {
            IdProduct = pIdProduct;
            IdBusiness = pIdBusiness;
            Name = pName;
        }
    }
}