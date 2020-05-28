using System;
using System.Windows.Forms;
using HugoApp.Controlador;
using HugoApp.Modelo;

namespace HugoApp.Vista
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }
        private void poblarControles()
        {
            // Actualizar ComboBox
            cmbUsuario.DataSource = null;
            cmbUsuario.ValueMember = "Password";
            cmbUsuario.DisplayMember = "Username";
            cmbUsuario.DataSource = AppuserDAO.getLista();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (Encriptador.CompararMD5(txtContrasena.Text, cmbUsuario.SelectedValue.ToString()))
            {
                Appuser u = (Appuser) cmbUsuario.SelectedItem;
                
                MessageBox.Show("¡Bienvenido!", 
                    "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                frmPrincipal ventana = new frmPrincipal(u);
                ventana.Show();
                this.Hide();
            }
            else
                MessageBox.Show("¡Contraseña incorrecta!", "Hugo App",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        
        private void txtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnIniciarSesion_Click(sender, e);
        }

        private void btnCambiarContra_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}