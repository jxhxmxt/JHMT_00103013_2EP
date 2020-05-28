using System.ComponentModel;

namespace HugoApp.Vista
{
    partial class frmAddAddress
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
            this.cmbUpdateAddr = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddrUpdate = new System.Windows.Forms.TextBox();
            this.btnAddSave = new System.Windows.Forms.Button();
            this.btnAddrDelete = new System.Windows.Forms.Button();
            this.btnAddrCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HugoApp.Properties.Resources.Hugo_APP1_01;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmbUpdateAddr
            // 
            this.cmbUpdateAddr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUpdateAddr.FormattingEnabled = true;
            this.cmbUpdateAddr.Location = new System.Drawing.Point(213, 133);
            this.cmbUpdateAddr.Name = "cmbUpdateAddr";
            this.cmbUpdateAddr.Size = new System.Drawing.Size(349, 23);
            this.cmbUpdateAddr.TabIndex = 1;
            this.cmbUpdateAddr.SelectedIndexChanged += new System.EventHandler(this.cmbUpdateAddr_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(244, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione la dirreccion a actualizar/borrar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 60);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dirrecion:";
            // 
            // txtAddrUpdate
            // 
            this.txtAddrUpdate.Location = new System.Drawing.Point(104, 208);
            this.txtAddrUpdate.Name = "txtAddrUpdate";
            this.txtAddrUpdate.Size = new System.Drawing.Size(459, 23);
            this.txtAddrUpdate.TabIndex = 4;
            // 
            // btnAddSave
            // 
            this.btnAddSave.Location = new System.Drawing.Point(57, 325);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(145, 42);
            this.btnAddSave.TabIndex = 5;
            this.btnAddSave.Text = "Guardar";
            this.btnAddSave.UseVisualStyleBackColor = true;
            this.btnAddSave.Click += new System.EventHandler(this.btnAddSave_Click);
            // 
            // btnAddrDelete
            // 
            this.btnAddrDelete.ForeColor = System.Drawing.Color.Red;
            this.btnAddrDelete.Location = new System.Drawing.Point(233, 325);
            this.btnAddrDelete.Name = "btnAddrDelete";
            this.btnAddrDelete.Size = new System.Drawing.Size(145, 42);
            this.btnAddrDelete.TabIndex = 6;
            this.btnAddrDelete.Text = "Eliminar";
            this.btnAddrDelete.UseVisualStyleBackColor = true;
            this.btnAddrDelete.Click += new System.EventHandler(this.btnAddrDelete_Click);
            // 
            // btnAddrCancel
            // 
            this.btnAddrCancel.Location = new System.Drawing.Point(409, 325);
            this.btnAddrCancel.Name = "btnAddrCancel";
            this.btnAddrCancel.Size = new System.Drawing.Size(145, 42);
            this.btnAddrCancel.TabIndex = 7;
            this.btnAddrCancel.Text = "Cancelar";
            this.btnAddrCancel.UseVisualStyleBackColor = true;
            this.btnAddrCancel.Click += new System.EventHandler(this.btnAddrCancel_Click);
            // 
            // frmAddAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(584, 464);
            this.Controls.Add(this.btnAddrCancel);
            this.Controls.Add(this.btnAddrDelete);
            this.Controls.Add(this.btnAddSave);
            this.Controls.Add(this.txtAddrUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUpdateAddr);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAddAddress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guardar dirrecion";
            this.Load += new System.EventHandler(this.frmAddAddress_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbUpdateAddr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddSave;
        private System.Windows.Forms.Button btnAddrCancel;
        private System.Windows.Forms.Button btnAddrDelete;
        private System.Windows.Forms.TextBox txtAddrUpdate;
    }
}