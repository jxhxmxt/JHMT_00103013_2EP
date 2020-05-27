using System.ComponentModel;

namespace HugoApp.Vista
{
    partial class UserOrder
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbUsOrderBussines = new System.Windows.Forms.ComboBox();
            this.cmbUsOrderProduct = new System.Windows.Forms.ComboBox();
            this.gpbNegocio = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddAddr = new System.Windows.Forms.Button();
            this.cmbUsOrderAddr = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.dgvUserOrders = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.gpbNegocio.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvUserOrders)).BeginInit();
            this.SuspendLayout();
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
            // gpbNegocio
            // 
            this.gpbNegocio.Controls.Add(this.label2);
            this.gpbNegocio.Controls.Add(this.label1);
            this.gpbNegocio.Controls.Add(this.cmbUsOrderBussines);
            this.gpbNegocio.Controls.Add(this.cmbUsOrderProduct);
            this.gpbNegocio.Location = new System.Drawing.Point(3, 3);
            this.gpbNegocio.Name = "gpbNegocio";
            this.gpbNegocio.Size = new System.Drawing.Size(234, 134);
            this.gpbNegocio.TabIndex = 2;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddAddr);
            this.groupBox1.Controls.Add(this.cmbUsOrderAddr);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(244, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 134);
            this.groupBox1.TabIndex = 3;
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
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(451, 23);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(91, 96);
            this.btnPlaceOrder.TabIndex = 6;
            this.btnPlaceOrder.Text = "Hacer Pedido";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // dgvUserOrders
            // 
            this.dgvUserOrders.AllowUserToAddRows = false;
            this.dgvUserOrders.AllowUserToDeleteRows = false;
            this.dgvUserOrders.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserOrders.Location = new System.Drawing.Point(9, 189);
            this.dgvUserOrders.Name = "dgvUserOrders";
            this.dgvUserOrders.ReadOnly = true;
            this.dgvUserOrders.Size = new System.Drawing.Size(533, 217);
            this.dgvUserOrders.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(161, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pedidos realizados";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvUserOrders);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbNegocio);
            this.Name = "UserOrder";
            this.Size = new System.Drawing.Size(552, 423);
            this.Load += new System.EventHandler(this.UserOrder_Load);
            this.gpbNegocio.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvUserOrders)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gpbNegocio;
        private System.Windows.Forms.ComboBox cmbUsOrderBussines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnAddAddr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvUserOrders;
        private System.Windows.Forms.ComboBox cmbUsOrderProduct;
        private System.Windows.Forms.ComboBox cmbUsOrderAddr;
    }
}