﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HugoApp.Controlador;
using HugoApp.Modelo;
using LiveCharts;
using LiveCharts.Wpf;
using CartesianChart = LiveCharts.WinForms.CartesianChart;


namespace HugoApp.Vista
{
    public partial class frmPrincipal : Form
    {
        private Appuser user;
        private CartesianChart graficoProductos;
        
        public frmPrincipal(Appuser u)
        {
            InitializeComponent();
            user = u;
            
            //inicializar grafico
            graficoProductos = new CartesianChart();
            this.Controls.Add(graficoProductos);
            graficoProductos.Parent = tabControl1.TabPages[3];
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if(user.UserType)
            {
                // Los administradores si tienen acceso a esta informacion
                tabControl1.TabPages[0].Parent = null;
                configurarGrafico();
                actualizarControles();
            }
            else
            {
                // Los usuarios NO administradores no tienen permiso de acceder a estas pestanas
                tabControl1.TabPages[1].Parent = null;
                tabControl1.TabPages[1].Parent = null;
                tabControl1.TabPages[1].Parent = null;
                actualizarControlesUsuario();
            }
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
            frmAddAddress ventana = new frmAddAddress(user);
            ventana.ShowDialog();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            try
            {
                Address a = (Address) cmbUsOrderAddr.SelectedItem;
                Product p = (Product) cmbUsOrderProduct.SelectedItem;
                
                AppOrderDAO.addOrder(DateTime.Now, p.IdProduct, a.IdAddress);
                
                MessageBox.Show("Pedido agregado exitosamente", "Hugo App",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Actualizar el data grid view (la tabla)
                actualizarControlesUsuario();

            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message, "Hugo App",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void configurarGrafico()
        {
            //posicion y tamanio
            graficoProductos.Top = 10;
            graficoProductos.Left = 10;
            graficoProductos.Width = graficoProductos.Parent.Width - 20;
            graficoProductos.Height = graficoProductos.Parent.Height - 20;

            //configuracion de seres, ejes y leyendas
            graficoProductos.Series = new SeriesCollection
            {
                new ColumnSeries()
                    {Title = "Demanda por negocios", Values = new ChartValues<int>(), DataLabels = true}
            };
            graficoProductos.AxisX.Add(new Axis() {Labels = new List<string>()});
            graficoProductos.AxisX[0].Separator = new Separator() {Step = 1, IsEnabled = false};
            graficoProductos.AxisX[0].LabelsRotation = 15;
            graficoProductos.LegendLocation = LegendLocation.Top;
        }
        private void actualizarControles()
        {
            //tabla negocios
            dgvBusiness.DataSource = null;
            dgvBusiness.DataSource = BusinessDAO.getLista();
            //dgvProducts
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = ProductDAO.getLista();
            //cmbRemoveBusiness
            cmbRemoveBusiness.DataSource = null;
            cmbRemoveBusiness.ValueMember = "IdBusiness";
            cmbRemoveBusiness.DisplayMember = "Name";
            cmbRemoveBusiness.DataSource = BusinessDAO.getLista();
            //cmbAddProductBusiness
            cmbAddProductBusiness.DataSource = null;
            cmbAddProductBusiness.ValueMember = "IdBusiness";
            cmbAddProductBusiness.DisplayMember = "Name";
            cmbAddProductBusiness.DataSource = BusinessDAO.getLista();
            
            //cmbRmvProdc
            Business b = (Business) cmbAddProductBusiness.SelectedItem;
            cmbRmvProdc.DataSource = null;
            cmbRmvProdc.ValueMember = "IdProduct";
            cmbRmvProdc.DisplayMember = "Name";
            cmbRmvProdc.DataSource = ProductDAO.getLista(b);
            //cmbAlterAppuser
            cmbAlterAppuser.DataSource = null;
            cmbAlterAppuser.ValueMember = "IdUser";
            cmbAlterAppuser.DisplayMember = "Username";
            cmbAlterAppuser.DataSource = AppuserDAO.getLista();
            //dgvAdminOrders
            dgvAdminOrders.DataSource = null;
            dgvAdminOrders.DataSource = AppuserDAO.getLista();
            
            poblarGrafico();
        }

        private void actualizarControlesUsuario()
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
            cmbUsOrderAddr.ValueMember = "IdAddress";
            cmbUsOrderAddr.DisplayMember = "Addr";
            cmbUsOrderAddr.DataSource = AddressDAO.getLista(user);
            //tabla
            dgvUserOrders.DataSource = null;
            dgvUserOrders.DataSource = AppOrderDAO.getLista(user);
        }
        private void poblarGrafico()
        {
            graficoProductos.Series[0].Values.Clear();
            graficoProductos.AxisX[0].Labels.Clear();
            
            foreach (BusinessxCantidad unNegocio in BusinessDAO.businxcantidad())
            {
                graficoProductos.Series[0].Values.Add(unNegocio.Cantidad);
                graficoProductos.AxisX[0].Labels.Add(unNegocio.Name);
            }
        }

        private void btnAddBusiness_Click(object sender, EventArgs e)
        {
            Business b = new Business();
            b.Name = txtAddBusiness.Text;
            b.Description = rtbAddBusinessDesc.Text;
            
            try
            {
                BusinessDAO.addBusiness(b);
                
                MessageBox.Show("Negocio agregado exitosamente", "Hugo App",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Limpiar la vista, los eventos se pueden invocar desde codigo
                btnAddBusinesClear_Click(sender, e);
                
                // Actualizar la vista, los ComboBox de la primer pestana
                actualizarControles();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message, "Hugo App",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddBusinesClear_Click(object sender, EventArgs e)
        {
            txtAddProducName.Clear();
            rtbAddBusinessDesc.Clear();
        }

        private void cmbAddProductBusiness_SelectedIndexChanged(object sender, EventArgs e)
        {
            Business b = (Business) cmbAddProductBusiness.SelectedItem;
            
            //cmbRmvProdc
            cmbRmvProdc.DataSource = null;
            cmbRmvProdc.ValueMember = "IdProduct";
            cmbRmvProdc.DisplayMember = "Name";
            cmbRmvProdc.DataSource = ProductDAO.getLista(b);
        }

        private void btnAddPrdSave_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            Business b = (Business) cmbAddProductBusiness.SelectedItem;
            p.Name = txtAddProducName.Text;
            p.IdBusiness = b.IdBusiness;
            
            try
            {
                ProductDAO.addProd(p);
                
                MessageBox.Show("Producto agregado exitosamente", "Hugo App",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualizar la vista, los ComboBox de la primer pestana
                actualizarControles();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message, "Hugo App",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product p = (Product) cmbRmvProdc.SelectedItem;
            
            if (MessageBox.Show("¿Seguro que desea eliminar el producto ?", 
                "Hugo App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ProductDAO.rmProd(p.IdProduct);
                
                MessageBox.Show("¡Producto eliminado exitosamente!", 
                    "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                configurarGrafico();
                poblarGrafico();
                actualizarControles();
            }
        }
        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir, " + user.Username + "?", 
                "Hugo App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Necesario porque el frmInicioSesion está escondido
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Appuser u = (Appuser) cmbAlterAppuser.SelectedItem;
            
            if (MessageBox.Show("¿Seguro que desea eliminar al usuario ?", 
                "Hugo App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AppuserDAO.delete(u.IdUser);
                
                MessageBox.Show("¡Usuario eliminado exitosamente!", 
                    "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            actualizarControles();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Appuser u = new Appuser();

            u.Fullname = txtAdminUserFull.Text;
            u.Username = txtAdminUserName.Text;
            u.Password = "password";
            u.UserType = chbAdmin.Checked;
            
            if (MessageBox.Show("¿Seguro que desea agregar al usuario ?", 
                "Hugo App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AppuserDAO.addAppuser(u);
                
                MessageBox.Show("¡Usuario agregado exitosamente; la contrasena es password!", 
                    "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            actualizarControles();
        }
        

        private void btnRemoveBusiness_Click(object sender, EventArgs e)
        {
            Business b = (Business) cmbRemoveBusiness.SelectedItem;
            
            if (MessageBox.Show("¿Seguro que desea eliminar el negocio ?", 
                "Hugo App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BusinessDAO.delete(b.IdBusiness);
                
                MessageBox.Show("¡Negocio eliminado exitosamente!", 
                    "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            actualizarControles();
        }
    }
}