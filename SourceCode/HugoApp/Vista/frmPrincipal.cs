using System.Windows.Forms;
using HugoApp.Modelo;

namespace HugoApp.Vista
{
    public partial class frmPrincipal : Form
    {
        private Appuser user;
        public frmPrincipal(Appuser u)
        {
            InitializeComponent();
            user = u;
        }
    }
}