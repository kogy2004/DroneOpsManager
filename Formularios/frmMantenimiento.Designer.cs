namespace DroneOpsManager.Formularios
{
    partial class frmMantenimiento
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDrone = new System.Windows.Forms.ComboBox();
            this.mtxtFecha = new System.Windows.Forms.MaskedTextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.mtxtProxima = new System.Windows.Forms.MaskedTextBox();
            this.dgvMantenimientos = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantenimientos)).BeginInit();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(60, 20);
            this.label1.Name = "label1";
            this.label1.TabIndex = 0;
            this.label1.Text = "Control de mantenimiento";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 90);
            this.label2.Name = "label2";
            this.label2.TabIndex = 1;
            this.label2.Text = "Dron";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 140);
            this.label3.Name = "label3";
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha (dd/mm/aaaa)";
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 90);
            this.label4.Name = "label4";
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de mantenimiento";
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 140);
            this.label5.Name = "label5";
            this.label5.TabIndex = 4;
            this.label5.Text = "Costo";
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 190);
            this.label6.Name = "label6";
            this.label6.TabIndex = 5;
            this.label6.Text = "Próxima revisión";
            //
            // cmbDrone
            //
            this.cmbDrone.FormattingEnabled = true;
            this.cmbDrone.Location = new System.Drawing.Point(66, 110);
            this.cmbDrone.Name = "cmbDrone";
            this.cmbDrone.Size = new System.Drawing.Size(180, 21);
            this.cmbDrone.TabIndex = 6;
            //
            // mtxtFecha
            //
            this.mtxtFecha.Location = new System.Drawing.Point(66, 160);
            this.mtxtFecha.Mask = "00/00/0000";
            this.mtxtFecha.Name = "mtxtFecha";
            this.mtxtFecha.Size = new System.Drawing.Size(100, 20);
            this.mtxtFecha.TabIndex = 7;
            //
            // cmbTipo
            //
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Preventivo",
            "Correctivo",
            "Cambio de batería",
            "Cambio de hélices",
            "Calibración",
            "Actualización de software"});
            this.cmbTipo.Location = new System.Drawing.Point(300, 110);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(180, 21);
            this.cmbTipo.TabIndex = 8;
            //
            // txtDescripcion
            //
            this.txtDescripcion.Location = new System.Drawing.Point(66, 210);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(414, 50);
            this.txtDescripcion.TabIndex = 9;
            //
            // txtCosto
            //
            this.txtCosto.Location = new System.Drawing.Point(300, 160);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(120, 20);
            this.txtCosto.TabIndex = 10;
            //
            // mtxtProxima
            //
            this.mtxtProxima.Location = new System.Drawing.Point(300, 210);
            this.mtxtProxima.Mask = "00/00/0000";
            this.mtxtProxima.Name = "mtxtProxima";
            this.mtxtProxima.Size = new System.Drawing.Size(100, 20);
            this.mtxtProxima.TabIndex = 11;
            //
            // dgvMantenimientos
            //
            this.dgvMantenimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMantenimientos.Location = new System.Drawing.Point(66, 320);
            this.dgvMantenimientos.Name = "dgvMantenimientos";
            this.dgvMantenimientos.Size = new System.Drawing.Size(620, 150);
            this.dgvMantenimientos.TabIndex = 12;
            //
            // btnRegistrar
            //
            this.btnRegistrar.Location = new System.Drawing.Point(66, 280);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(110, 30);
            this.btnRegistrar.TabIndex = 13;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnPendiente_Click);
            //
            // frmMantenimiento
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 490);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgvMantenimientos);
            this.Controls.Add(this.mtxtProxima);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.mtxtFecha);
            this.Controls.Add(this.cmbDrone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMantenimiento";
            this.Text = "Control de mantenimiento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMantenimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDrone;
        private System.Windows.Forms.MaskedTextBox mtxtFecha;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.MaskedTextBox mtxtProxima;
        private System.Windows.Forms.DataGridView dgvMantenimientos;
        private System.Windows.Forms.Button btnRegistrar;
    }
}