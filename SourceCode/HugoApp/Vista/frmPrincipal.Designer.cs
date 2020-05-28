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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddBusiness = new System.Windows.Forms.TextBox();
            this.rtbAddBusinessDesc = new System.Windows.Forms.RichTextBox();
            this.btnAddBusiness = new System.Windows.Forms.Button();
            this.btnAddBusinesClear = new System.Windows.Forms.Button();
            this.dgvBusiness = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbAddProductBusiness = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtAddProducName = new System.Windows.Forms.TextBox();
            this.btnAddPrdSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbRmvProdc = new System.Windows.Forms.ComboBox();
            this.btnRmProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvUserOrders)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gpbNegocio.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvBusiness)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HugoApp.Properties.Resources.Hugo_APP1_01;
            this.pictureBox1.Location = new System.Drawing.Point(216, 12);
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.dataGridView1);
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
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(552, 423);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Estadisticas";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddBusinesClear);
            this.groupBox2.Controls.Add(this.btnAddBusiness);
            this.groupBox2.Controls.Add(this.rtbAddBusinessDesc);
            this.groupBox2.Controls.Add(this.txtAddBusiness);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(6, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 147);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Negocio Nuevo";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(161, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Descripcion:";
            // 
            // txtAddBusiness
            // 
            this.txtAddBusiness.Location = new System.Drawing.Point(12, 54);
            this.txtAddBusiness.Name = "txtAddBusiness";
            this.txtAddBusiness.Size = new System.Drawing.Size(151, 23);
            this.txtAddBusiness.TabIndex = 2;
            // 
            // rtbAddBusinessDesc
            // 
            this.rtbAddBusinessDesc.Location = new System.Drawing.Point(248, 28);
            this.rtbAddBusinessDesc.Name = "rtbAddBusinessDesc";
            this.rtbAddBusinessDesc.Size = new System.Drawing.Size(286, 59);
            this.rtbAddBusinessDesc.TabIndex = 3;
            this.rtbAddBusinessDesc.Text = "";
            // 
            // btnAddBusiness
            // 
            this.btnAddBusiness.Location = new System.Drawing.Point(12, 98);
            this.btnAddBusiness.Name = "btnAddBusiness";
            this.btnAddBusiness.Size = new System.Drawing.Size(137, 33);
            this.btnAddBusiness.TabIndex = 4;
            this.btnAddBusiness.Text = "Guardar";
            this.btnAddBusiness.UseVisualStyleBackColor = true;
            this.btnAddBusiness.Click += new System.EventHandler(this.btnAddBusiness_Click);
            // 
            // btnAddBusinesClear
            // 
            this.btnAddBusinesClear.Location = new System.Drawing.Point(175, 98);
            this.btnAddBusinesClear.Name = "btnAddBusinesClear";
            this.btnAddBusinesClear.Size = new System.Drawing.Size(137, 33);
            this.btnAddBusinesClear.TabIndex = 5;
            this.btnAddBusinesClear.Text = "Limpiar";
            this.btnAddBusinesClear.UseVisualStyleBackColor = true;
            this.btnAddBusinesClear.Click += new System.EventHandler(this.btnAddBusinesClear_Click);
            // 
            // dgvBusiness
            // 
            this.dgvBusiness.AllowUserToAddRows = false;
            this.dgvBusiness.AllowUserToDeleteRows = false;
            this.dgvBusiness.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusiness.Location = new System.Drawing.Point(6, 179);
            this.dgvBusiness.Name = "dgvBusiness";
            this.dgvBusiness.ReadOnly = true;
            this.dgvBusiness.Size = new System.Drawing.Size(540, 238);
            this.dgvBusiness.TabIndex = 1;
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtAddProducName);
            this.groupBox4.Location = new System.Drawing.Point(249, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(198, 111);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Agregar Producto";
            // 
            // txtAddProducName
            // 
            this.txtAddProducName.Location = new System.Drawing.Point(18, 44);
            this.txtAddProducName.Name = "txtAddProducName";
            this.txtAddProducName.Size = new System.Drawing.Size(174, 23);
            this.txtAddProducName.TabIndex = 0;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(540, 192);
            this.dataGridView1.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnRmProduct);
            this.groupBox5.Controls.Add(this.cmbRmvProdc);
            this.groupBox5.Location = new System.Drawing.Point(6, 146);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(326, 73);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Elimine Producto";
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
            // btnRmProduct
            // 
            this.btnRmProduct.ForeColor = System.Drawing.Color.Red;
            this.btnRmProduct.Location = new System.Drawing.Point(224, 26);
            this.btnRmProduct.Name = "btnRmProduct";
            this.btnRmProduct.Size = new System.Drawing.Size(96, 31);
            this.btnRmProduct.TabIndex = 2;
            this.btnRmProduct.Text = "Eliminar";
            this.btnRmProduct.UseVisualStyleBackColor = true;
            this.btnRmProduct.Click += new System.EventHandler(this.button1_Click);
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
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvUserOrders)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.gpbNegocio.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvBusiness)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmbRmvProdc;
        private System.Windows.Forms.Button btnRmProduct;
    }
}