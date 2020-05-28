using System;
using System.Windows.Forms;
using HugoApp.Modelo;

namespace HugoApp.Vista
{
    public partial class frmAddAddress : Form
    {
        private Appuser user;
        public frmAddAddress(Appuser u)
        {
            InitializeComponent();
            user = u;
        }

        private void frmAddAddress_Load(object sender, EventArgs e)
        {
            cmbUpdateAddr.DataSource = null;
            cmbUpdateAddr.ValueMember = "IdAddress";
            cmbUpdateAddr.DisplayMember = "Addr";
            cmbUpdateAddr.DataSource = AddressDAO.getLista(user);
        }
        private void cmbUpdateAddr_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAddrUpdate.Text = cmbUpdateAddr.Text;
        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            Address a = (Address) cmbUpdateAddr.SelectedItem;
            
            if (MessageBox.Show("¿Seguro que desea editar la direccion ?", 
                "Hugo App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AddressDAO.updateAddress(a, user, txtAddrUpdate.Text);
                
                MessageBox.Show("¡Direccion editada exitosamente!", 
                    "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnAddrDelete_Click(object sender, EventArgs e)
        {
            Address a = (Address) cmbUpdateAddr.SelectedItem;
            
            if (MessageBox.Show("¿Seguro que desea eliminar la direccion ?", 
                "Hugo App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AddressDAO.removeAddress(a, user);
                
                MessageBox.Show("¡Direccion eliminada exitosamente!", 
                    "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddrCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}