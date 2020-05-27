using System;
using System.Windows.Forms;
using HugoApp.Controlador;
using HugoApp.Modelo;

namespace HugoApp.Vista
{
    public partial class UserOrder : UserControl
    {
        public UserOrder()
        {
            InitializeComponent();
        }

        private void UserOrder_Load(object sender, EventArgs e)
        {
            actualizarControles();
        }

        private void cmbUsOrderBussines_SelectedIndexChanged(object sender, EventArgs e)
        {
            Business b = (Business) cmbUsOrderBussines.SelectedItem;
            // cmbUsOrderProduct
            cmbUsOrderProduct.DataSource = null;
            cmbUsOrderProduct.ValueMember = "IdProduct";
            cmbUsOrderProduct.DisplayMember = "Name";
            cmbUsOrderProduct.DataSource = ProductDAO.getLista(b);
        }

        private void btnAddAddr_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        
        private void actualizarControles()
        {
            // cmbUsOrderBussines
            cmbUsOrderBussines.DataSource = null;
            cmbUsOrderBussines.ValueMember = "IdBusiness";
            cmbUsOrderBussines.DisplayMember = "Name";
            cmbUsOrderBussines.DataSource = BusinessDAO.getLista();
            // cmbUsOrderProduct
            cmbUsOrderProduct.DataSource = null;
            cmbUsOrderProduct.ValueMember = "IdProduct";
            cmbUsOrderProduct.DisplayMember = "Name";
            cmbUsOrderProduct.DataSource = ProductDAO.getLista();
            // cmbUsOrderAddr
            cmbUsOrderAddr.DataSource = null;
            cmbUsOrderAddr.ValueMember = "IdUsuario";
            cmbUsOrderAddr.DisplayMember = "Nombres";
            cmbUsOrderAddr.DataSource = AddressDAO.getLista();
            /*// cmbProductoPedido
            cmbProductoPedido.DataSource = null;
            cmbProductoPedido.ValueMember = "IdProducto";
            cmbProductoPedido.DisplayMember = "Nombres";
            cmbProductoPedido.DataSource = InventarioDAO.getLista();
            // Menu desplegable (combo box)
            cmbUsuario.DataSource = null;
            cmbUsuario.ValueMember = "IdUsuario";
            cmbUsuario.DisplayMember = "Nombres";
            cmbUsuario.DataSource = UsuarioDAO.getLista();
            // cmbProdMantenimiento
            cmbProdMantenimiento.DataSource = null;
            cmbProdMantenimiento.ValueMember = "IdProducto";
            cmbProdMantenimiento.DisplayMember = "Nombres";
            cmbProdMantenimiento.DataSource = InventarioDAO.getLista();
            //nudStockMantenimiento
            Inventario i = (Inventario) cmbProdMantenimiento.SelectedItem;
            nudStockMantenimiento.Value = i.Stock;
            nudPrecioMantenimiento.Value = Convert.ToDecimal(i.Precio);*/
        }
    }
}