namespace HugoApp.Modelo
{
    public class Address
    {
        public int IdAddress { get; set; }
        public int IdUser { get; set; }
        public string Addr { get; set; }

        public Address() { }

        public Address(int pIdAddress, int pIdUser, string pAddress)
        {
            IdAddress = pIdAddress;
            IdUser = pIdUser;
            Addr = pAddress;
        }
    }
}