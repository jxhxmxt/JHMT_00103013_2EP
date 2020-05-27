using System;
using System.Windows.Forms;
using HugoApp.Controlador;
using HugoApp.Modelo;

namespace HugoApp.Vista
{
    public partial class frmCambiarContra : Form
    {
        public frmCambiarContra()
        {
            InitializeComponent();
        }

        private void frmCambiarContra_Load(object sender, EventArgs e)
        {
            poblarControles();
        }
        private void poblarControles()
        {
            // Actualizar ComboBox
            cmbUsuario.DataSource = null;
            cmbUsuario.ValueMember = "Password";
            cmbUsuario.DisplayMember = "Username";
            cmbUsuario.DataSource = AppuserDAO.getLista();
        }

        private void btnCambiarContra_Click(object sender, EventArgs e)
        {
            bool actualIgual = Encriptador.CompararMD5(txtActual.Text, cmbUsuario.SelectedValue.ToString());
            bool nuevaIgual = txtNueva.Text.Equals(txtRepetir.Text);
            bool nuevaValida = txtNueva.Text.Length > 0;
            if (actualIgual && nuevaIgual && nuevaValida)
            {
                try
                {
                    Appuser u = (Appuser) cmbUsuario.SelectedItem;
                    
                    AppuserDAO.updateAppuser(u.IdUser, txtNueva.Text);
                    
                    MessageBox.Show("¡Contraseña actualizada exitosamente!", 
                        "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("¡Contraseña no actualizada! Favor intente mas tarde.", 
                        "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("¡¡Favor verifique que los datos sean correctos!", 
                    "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}