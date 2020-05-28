using System.ComponentModel;

namespace HugoApp.Vista
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvUserOrders = new System.Windows.Forms.DataGridView();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddAddr = new System.Windows.Forms.Button();
            this.cmbUsOrderAddr = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbNegocio = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUsOrderBussines = new System.Windows.Forms.ComboBox();
            this.cmbUsOrderProduct = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvBusiness = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddBusinesClear = new System.Windows.Forms.Button();
            this.btnAddBusiness = new System.Windows.Forms.Button();
            this.rtbAddBusinessDesc = new System.Windows.Forms.RichTextBox();
            this.txtAddBusiness = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnRmProduct = new System.Windows.Forms.Button();
            this.cmbRmvProdc = new System.Windows.Forms.ComboBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnAddPrdSave = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtAddProducName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbAddProductBusiness = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmbAlterAppuser = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtAdminUserFull = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtAdminUserName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvAdminOrders = new System.Windows.Forms.DataGridView();
            this.chbAdmin = new System.Windows.Forms.CheckBox();
            this.cmbRemoveBusiness = new System.Windows.Forms.ComboBox();
            this.btnRemoveBusiness = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvUserOrders)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gpbNegocio.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvBusiness)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvProducts)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvAdminOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HugoApp.Properties.Resources.Hugo_APP1_01;
            this.pictureBox1.Location = new System.Drawing.Point(268, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 84);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 451);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dgvUserOrders);
            this.tabPage1.Controls.Add(this.btnPlaceOrder);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.gpbNegocio);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(552, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ordenes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(169, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pedidos realizados";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvUserOrders
            // 
            this.dgvUserOrders.AllowUserToAddRows = false;
            this.dgvUserOrders.AllowUserToDeleteRows = false;
            this.dgvUserOrders.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserOrders.Location = new System.Drawing.Point(10, 200);
            this.dgvUserOrders.Name = "dgvUserOrders";
            this.dgvUserOrders.ReadOnly = true;
            this.dgvUserOrders.Size = new System.Drawing.Size(533, 217);
            this.dgvUserOrders.TabIndex = 8;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(453, 27);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(91, 96);
            this.btnPlaceOrder.TabIndex = 7;
            this.btnPlaceOrder.Text = "Hacer Pedido";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddAddr);
            this.groupBox1.Controls.Add(this.cmbUsOrderAddr);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(246, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 134);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione direccion";
            // 
            // btnAddAddr
            // 
            this.btnAddAddr.Location = new System.Drawing.Point(17, 85);
            this.btnAddAddr.Name = "btnAddAddr";
            this.btnAddAddr.Size = new System.Drawing.Size(168, 31);
            this.btnAddAddr.TabIndex = 5;
            this.btnAddAddr.Text = "Agregar Dirrecion";
            this.btnAddAddr.UseVisualStyleBackColor = true;
            this.btnAddAddr.Click += new System.EventHandler(this.btnAddAddr_Click);
            // 
            // cmbUsOrderAddr
            // 
            this.cmbUsOrderAddr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsOrderAddr.FormattingEnabled = true;
            this.cmbUsOrderAddr.Location = new System.Drawing.Point(69, 28);
            this.cmbUsOrderAddr.Name = "cmbUsOrderAddr";
            this.cmbUsOrderAddr.Size = new System.Drawing.Size(126, 23);
            this.cmbUsOrderAddr.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Direccion:";
            // 
            // gpbNegocio
            // 
            this.gpbNegocio.Controls.Add(this.label2);
            this.gpbNegocio.Controls.Add(this.label1);
            this.gpbNegocio.Controls.Add(this.cmbUsOrderBussines);
            this.gpbNegocio.Controls.Add(this.cmbUsOrderProduct);
            this.gpbNegocio.Location = new System.Drawing.Point(6, 6);
            this.gpbNegocio.Name = "gpbNegocio";
            this.gpbNegocio.Size = new System.Drawing.Size(234, 134);
            this.gpbNegocio.TabIndex = 3;
            this.gpbNegocio.TabStop = false;
            this.gpbNegocio.Text = "Seleccione un podructo";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Producto:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Negocio:";
            // 
            // cmbUsOrderBussines
            // 
            this.cmbUsOrderBussines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsOrderBussines.FormattingEnabled = true;
            this.cmbUsOrderBussines.Location = new System.Drawing.Point(73, 33);
            this.cmbUsOrderBussines.Name = "cmbUsOrderBussines";
            this.cmbUsOrderBussines.Size = new System.Drawing.Size(154, 23);
            this.cmbUsOrderBussines.TabIndex = 0;
            this.cmbUsOrderBussines.SelectedIndexChanged +=
                new System.EventHandler(this.cmbUsOrderBussines_SelectedIndexChanged);
            // 
            // cmbUsOrderProduct
            // 
            this.cmbUsOrderProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsOrderProduct.FormattingEnabled = true;
            this.cmbUsOrderProduct.Location = new System.Drawing.Point(73, 93);
            this.cmbUsOrderProduct.Name = "cmbUsOrderProduct";
            this.cmbUsOrderProduct.Size = new System.Drawing.Size(154, 23);
            this.cmbUsOrderProduct.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRemoveBusiness);
            this.tabPage2.Controls.Add(this.cmbRemoveBusiness);
            this.tabPage2.Controls.Add(this.dgvBusiness);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(552, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Negocios";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvBusiness
            // 
            this.dgvBusiness.AllowUserToAddRows = false;
            this.dgvBusiness.AllowUserToDeleteRows = false;
            this.dgvBusiness.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusiness.Location = new System.Drawing.Point(6, 266);
            this.dgvBusiness.Name = "dgvBusiness";
            this.dgvBusiness.ReadOnly = true;
            this.dgvBusiness.Size = new System.Drawing.Size(540, 151);
            this.dgvBusiness.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddBusinesClear);
            this.groupBox2.Controls.Add(this.btnAddBusiness);
            this.groupBox2.Controls.Add(this.rtbAddBusinessDesc);
            this.groupBox2.Controls.Add(this.txtAddBusiness);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(6, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 147);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Negocio Nuevo";
            // 
            // btnAddBusinesClear
            // 
            this.btnAddBusinesClear.Location = new System.Drawing.Point(175, 98);
            this.btnAddBusinesClear.Name = "btnAddBusinesClear";
            this.btnAddBusinesClear.Size = new System.Drawing.Size(136, 33);
            this.btnAddBusinesClear.TabIndex = 5;
            this.btnAddBusinesClear.Text = "Limpiar";
            this.btnAddBusinesClear.UseVisualStyleBackColor = true;
            this.btnAddBusinesClear.Click += new System.EventHandler(this.btnAddBusinesClear_Click);
            // 
            // btnAddBusiness
            // 
            this.btnAddBusiness.Location = new System.Drawing.Point(12, 98);
            this.btnAddBusiness.Name = "btnAddBusiness";
            this.btnAddBusiness.Size = new System.Drawing.Size(136, 33);
            this.btnAddBusiness.TabIndex = 4;
            this.btnAddBusiness.Text = "Guardar";
            this.btnAddBusiness.UseVisualStyleBackColor = true;
            this.btnAddBusiness.Click += new System.EventHandler(this.btnAddBusiness_Click);
            // 
            // rtbAddBusinessDesc
            // 
            this.rtbAddBusinessDesc.Location = new System.Drawing.Point(248, 28);
            this.rtbAddBusinessDesc.Name = "rtbAddBusinessDesc";
            this.rtbAddBusinessDesc.Size = new System.Drawing.Size(286, 59);
            this.rtbAddBusinessDesc.TabIndex = 3;
            this.rtbAddBusinessDesc.Text = "";
            // 
            // txtAddBusiness
            // 
            this.txtAddBusiness.Location = new System.Drawing.Point(12, 54);
            this.txtAddBusiness.Name = "txtAddBusiness";
            this.txtAddBusiness.Size = new System.Drawing.Size(151, 23);
            this.txtAddBusiness.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(161, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Descripcion:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.dgvProducts);
            this.tabPage3.Controls.Add(this.btnAddPrdSave);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(552, 423);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Productos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnRmProduct);
            this.groupBox5.Controls.Add(this.cmbRmvProdc);
            this.groupBox5.Location = new System.Drawing.Point(6, 147);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(325, 73);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Elimine Producto";
            // 
            // btnRmProduct
            // 
            this.btnRmProduct.ForeColor = System.Drawing.Color.Red;
            this.btnRmProduct.Location = new System.Drawing.Point(224, 27);
            this.btnRmProduct.Name = "btnRmProduct";
            this.btnRmProduct.Size = new System.Drawing.Size(96, 31);
            this.btnRmProduct.TabIndex = 2;
            this.btnRmProduct.Text = "Eliminar";
            this.btnRmProduct.UseVisualStyleBackColor = true;
            this.btnRmProduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbRmvProdc
            // 
            this.cmbRmvProdc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRmvProdc.FormattingEnabled = true;
            this.cmbRmvProdc.Location = new System.Drawing.Point(15, 31);
            this.cmbRmvProdc.Name = "cmbRmvProdc";
            this.cmbRmvProdc.Size = new System.Drawing.Size(180, 23);
            this.cmbRmvProdc.TabIndex = 1;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(6, 225);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.Size = new System.Drawing.Size(540, 192);
            this.dgvProducts.TabIndex = 3;
            // 
            // btnAddPrdSave
            // 
            this.btnAddPrdSave.Location = new System.Drawing.Point(463, 24);
            this.btnAddPrdSave.Name = "btnAddPrdSave";
            this.btnAddPrdSave.Size = new System.Drawing.Size(83, 100);
            this.btnAddPrdSave.TabIndex = 2;
            this.btnAddPrdSave.Text = "Guardar";
            this.btnAddPrdSave.UseVisualStyleBackColor = true;
            this.btnAddPrdSave.Click += new System.EventHandler(this.btnAddPrdSave_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtAddProducName);
            this.groupBox4.Location = new System.Drawing.Point(248, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(198, 111);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Agregar Producto";
            // 
            // txtAddProducName
            // 
            this.txtAddProducName.Location = new System.Drawing.Point(17, 44);
            this.txtAddProducName.Name = "txtAddProducName";
            this.txtAddProducName.Size = new System.Drawing.Size(174, 23);
            this.txtAddProducName.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbAddProductBusiness);
            this.groupBox3.Location = new System.Drawing.Point(6, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 111);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seleccione un negocio";
            // 
            // cmbAddProductBusiness
            // 
            this.cmbAddProductBusiness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddProductBusiness.FormattingEnabled = true;
            this.cmbAddProductBusiness.Location = new System.Drawing.Point(15, 44);
            this.cmbAddProductBusiness.Name = "cmbAddProductBusiness";
            this.cmbAddProductBusiness.Size = new System.Drawing.Size(180, 23);
            this.cmbAddProductBusiness.TabIndex = 0;
            this.cmbAddProductBusiness.SelectedIndexChanged +=
                new System.EventHandler(this.cmbAddProductBusiness_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(552, 425);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Estadisticas";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dgvAdminOrders);
            this.tabPage5.Controls.Add(this.groupBox7);
            this.tabPage5.Controls.Add(this.groupBox6);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(552, 423);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Mantenimiento";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.cmbAlterAppuser);
            this.groupBox6.Location = new System.Drawing.Point(6, 29);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(228, 140);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Administrar Usuarios";
            // 
            // cmbAlterAppuser
            // 
            this.cmbAlterAppuser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlterAppuser.FormattingEnabled = true;
            this.cmbAlterAppuser.Location = new System.Drawing.Point(14, 23);
            this.cmbAlterAppuser.Name = "cmbAlterAppuser";
            this.cmbAlterAppuser.Size = new System.Drawing.Size(199, 23);
            this.cmbAlterAppuser.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.chbAdmin);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.txtAdminUserName);
            this.groupBox7.Controls.Add(this.button2);
            this.groupBox7.Controls.Add(this.txtAdminUserFull);
            this.groupBox7.Location = new System.Drawing.Point(252, 29);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(286, 140);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Agregar Usuarios";
            // 
            // txtAdminUserFull
            // 
            this.txtAdminUserFull.Location = new System.Drawing.Point(88, 23);
            this.txtAdminUserFull.Name = "txtAdminUserFull";
            this.txtAdminUserFull.Size = new System.Drawing.Size(192, 23);
            this.txtAdminUserFull.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(14, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(132, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtAdminUserName
            // 
            this.txtAdminUserName.Location = new System.Drawing.Point(88, 58);
            this.txtAdminUserName.Name = "txtAdminUserName";
            this.txtAdminUserName.Size = new System.Drawing.Size(192, 23);
            this.txtAdminUserName.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Full Name";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Nick Name";
            // 
            // dgvAdminOrders
            // 
            this.dgvAdminOrders.AllowUserToAddRows = false;
            this.dgvAdminOrders.AllowUserToDeleteRows = false;
            this.dgvAdminOrders.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminOrders.Location = new System.Drawing.Point(6, 192);
            this.dgvAdminOrders.Name = "dgvAdminOrders";
            this.dgvAdminOrders.ReadOnly = true;
            this.dgvAdminOrders.Size = new System.Drawing.Size(532, 225);
            this.dgvAdminOrders.TabIndex = 3;
            // 
            // chbAdmin
            // 
            this.chbAdmin.Location = new System.Drawing.Point(22, 98);
            this.chbAdmin.Name = "chbAdmin";
            this.chbAdmin.Size = new System.Drawing.Size(104, 24);
            this.chbAdmin.TabIndex = 7;
            this.chbAdmin.Text = "Admin";
            this.chbAdmin.UseVisualStyleBackColor = true;
            // 
            // cmbRemoveBusiness
            // 
            this.cmbRemoveBusiness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRemoveBusiness.FormattingEnabled = true;
            this.cmbRemoveBusiness.Location = new System.Drawing.Point(18, 207);
            this.cmbRemoveBusiness.Name = "cmbRemoveBusiness";
            this.cmbRemoveBusiness.Size = new System.Drawing.Size(150, 23);
            this.cmbRemoveBusiness.TabIndex = 2;
            // 
            // btnRemoveBusiness
            // 
            this.btnRemoveBusiness.ForeColor = System.Drawing.Color.Red;
            this.btnRemoveBusiness.Location = new System.Drawing.Point(240, 201);
            this.btnRemoveBusiness.Name = "btnRemoveBusiness";
            this.btnRemoveBusiness.Size = new System.Drawing.Size(136, 33);
            this.btnRemoveBusiness.TabIndex = 6;
            this.btnRemoveBusiness.Text = "Eliminar";
            this.btnRemoveBusiness.UseVisualStyleBackColor = true;
            this.btnRemoveBusiness.Click += new System.EventHandler(this.btnRemoveBusiness_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(584, 547);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hugo App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvUserOrders)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.gpbNegocio.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvBusiness)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvProducts)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvAdminOrders)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox cmbUsOrderProduct;
        private System.Windows.Forms.ComboBox cmbUsOrderBussines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpbNegocio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUsOrderAddr;
        private System.Windows.Forms.Button btnAddAddr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.DataGridView dgvUserOrders;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddBusiness;
        private System.Windows.Forms.RichTextBox rtbAddBusinessDesc;
        private System.Windows.Forms.Button btnAddBusiness;
        private System.Windows.Forms.Button btnAddBusinesClear;
        private System.Windows.Forms.ComboBox cmbAddProductBusiness;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvBusiness;
        private System.Windows.Forms.TextBox txtAddProducName;
        private System.Windows.Forms.Button btnAddPrdSave;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmbRmvProdc;
        private System.Windows.Forms.Button btnRmProduct;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ComboBox cmbAlterAppuser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtAdminUserName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAdminUserFull;
        private System.Windows.Forms.DataGridView dgvAdminOrders;
        private System.Windows.Forms.CheckBox chbAdmin;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.ComboBox cmbRemoveBusiness;
        private System.Windows.Forms.Button btnRemoveBusiness;
    }
}