namespace HugoApp.Modelo
{
    public class Appuser
    {
        public int IdUser { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool UserType { get; set; }

        public Appuser() { }

        public Appuser(int pID, string pFullname, string pUsername, 
            string pPassword, bool pUserType)
        {
            IdUser = pID;
            Fullname = pFullname;
            Username = pUsername;
            Password = pPassword;
            UserType = pUserType;
        }
    }
}