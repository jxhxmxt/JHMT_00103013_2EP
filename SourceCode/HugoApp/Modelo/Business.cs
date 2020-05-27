namespace HugoApp.Controlador
{
    public class Business
    {
        public int IdBusiness { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Business() { }

        public Business(int pIdBusiness, string pName, string pDescription)
        {
            IdBusiness = pIdBusiness;
            Name = pName;
            Description = pDescription;
        }
    }
}