namespace DroneOpsManager.Formularios
{
    partial class frmPiloto
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtLicencia = new System.Windows.Forms.TextBox();
            this.mtxtVencimiento = new System.Windows.Forms.MaskedTextBox();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRetiro = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnIngreso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
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
            this.label1.Text = "Gestión de pilotos";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 90);
            this.label2.Name = "label2";
            this.label2.TabIndex = 1;
            this.label2.Text = "Documento";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 140);
            this.label3.Name = "label3";
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 190);
            this.label4.Name = "label4";
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido";
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 240);
            this.label5.Name = "label5";
            this.label5.TabIndex = 4;
            this.label5.Text = "Licencia";
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 90);
            this.label6.Name = "label6";
            this.label6.TabIndex = 5;
            this.label6.Text = "Vencimiento de licencia";
            //
            // label7
            //
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 140);
            this.label7.Name = "label7";
            this.label7.TabIndex = 6;
            this.label7.Text = "Especialidad";
            //
            // txtDocumento
            //
            this.txtDocumento.Location = new System.Drawing.Point(66, 110);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(150, 20);
            this.txtDocumento.TabIndex = 7;
            //
            // txtNombre
            //
            this.txtNombre.Location = new System.Drawing.Point(66, 160);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 20);
            this.txtNombre.TabIndex = 8;
            //
            // txtApellido
            //
            this.txtApellido.Location = new System.Drawing.Point(66, 210);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(180, 20);
            this.txtApellido.TabIndex = 9;
            //
            // txtLicencia
            //
            this.txtLicencia.Location = new System.Drawing.Point(66, 260);
            this.txtLicencia.Name = "txtLicencia";
            this.txtLicencia.Size = new System.Drawing.Size(150, 20);
            this.txtLicencia.TabIndex = 10;
            //
            // mtxtVencimiento
            //
            this.mtxtVencimiento.Location = new System.Drawing.Point(300, 110);
            this.mtxtVencimiento.Mask = "00/00/0000";
            this.mtxtVencimiento.Name = "mtxtVencimiento";
            this.mtxtVencimiento.Size = new System.Drawing.Size(100, 20);
            this.mtxtVencimiento.TabIndex = 11;
            //
            // cmbEspecialidad
            //
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Items.AddRange(new object[] {
            "Fotografía",
            "Agricultura",
            "Topografía",
            "Vigilancia",
            "Entregas"});
            this.cmbEspecialidad.Location = new System.Drawing.Point(300, 160);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(150, 21);
            this.cmbEspecialidad.TabIndex = 12;
            //
            // txtTelefono
            //
            this.txtTelefono.Location = new System.Drawing.Point(300, 210);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(120, 20);
            this.txtTelefono.TabIndex = 13;
            //
            // txtCorreo
            //
            this.txtCorreo.Location = new System.Drawing.Point(300, 260);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(180, 20);
            this.txtCorreo.TabIndex = 14;
            //
            // label8
            //
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 190);
            this.label8.Name = "label8";
            this.label8.TabIndex = 15;
            this.label8.Text = "Teléfono";
            //
            // label9
            //
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(300, 240);
            this.label9.Name = "label9";
            this.label9.TabIndex = 16;
            this.label9.Text = "Correo";
            //
            // dgvHistorial
            //
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(66, 340);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.Size = new System.Drawing.Size(620, 150);
            this.dgvHistorial.TabIndex = 17;
            //
            // label10
            //
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 320);
            this.label10.Name = "label10";
            this.label10.TabIndex = 18;
            this.label10.Text = "Historial de misiones y horas de vuelo";
            //
            // btnRetiro
            //
            this.btnRetiro.Location = new System.Drawing.Point(360, 290);
            this.btnRetiro.Name = "btnRetiro";
            this.btnRetiro.Size = new System.Drawing.Size(75, 23);
            this.btnRetiro.TabIndex = 22;
            this.btnRetiro.Text = "Retirar";
            this.btnRetiro.UseVisualStyleBackColor = true;
            this.btnRetiro.Click += new System.EventHandler(this.btnPendiente_Click);
            //
            // btnConsulta
            //
            this.btnConsulta.Location = new System.Drawing.Point(250, 290);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 21;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnPendiente_Click);
            //
            // btnModificar
            //
            this.btnModificar.Location = new System.Drawing.Point(140, 290);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnPendiente_Click);
            //
            // btnIngreso
            //
            this.btnIngreso.Location = new System.Drawing.Point(30, 290);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(75, 23);
            this.btnIngreso.TabIndex = 19;
            this.btnIngreso.Text = "Ingresar";
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnPendiente_Click);
            //
            // frmPiloto
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 520);
            this.Controls.Add(this.btnRetiro);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.mtxtVencimiento);
            this.Controls.Add(this.txtLicencia);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPiloto";
            this.Text = "Gestión de pilotos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtLicencia;
        private System.Windows.Forms.MaskedTextBox mtxtVencimiento;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRetiro;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnIngreso;
    }
}