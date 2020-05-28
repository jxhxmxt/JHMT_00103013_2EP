namespace HugoApp.Controlador
{
    public class BusinessxCantidad
    {
        public string Name { get; set; }
        public int Cantidad { get; set; }
        
        public BusinessxCantidad() { }

        public BusinessxCantidad(string pName, int pCantidad)
        {
            Name = pName;
            Cantidad = pCantidad;
        }
    }
}