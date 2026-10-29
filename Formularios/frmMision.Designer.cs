namespace DroneOpsManager.Formularios
{
    partial class frmMision
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
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbServicio = new System.Windows.Forms.ComboBox();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.mtxtFecha = new System.Windows.Forms.MaskedTextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.cmbPiloto = new System.Windows.Forms.ComboBox();
            this.cmbDrone = new System.Windows.Forms.ComboBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
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
            this.label1.Text = "Programación de misiones";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 90);
            this.label2.Name = "label2";
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 140);
            this.label3.Name = "label3";
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de servicio";
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 190);
            this.label4.Name = "label4";
            this.label4.TabIndex = 3;
            this.label4.Text = "Ubicación";
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 240);
            this.label5.Name = "label5";
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha (dd/mm/aaaa)";
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 90);
            this.label6.Name = "label6";
            this.label6.TabIndex = 5;
            this.label6.Text = "Hora";
            //
            // label7
            //
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 140);
            this.label7.Name = "label7";
            this.label7.TabIndex = 6;
            this.label7.Text = "Piloto asignado";
            //
            // label8
            //
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 190);
            this.label8.Name = "label8";
            this.label8.TabIndex = 7;
            this.label8.Text = "Dron asignado";
            //
            // cmbCliente
            //
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(66, 110);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(180, 21);
            this.cmbCliente.TabIndex = 8;
            //
            // cmbServicio
            //
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Items.AddRange(new object[] {
            "Fotografía aérea",
            "Video profesional",
            "Agricultura de precisión",
            "Inspección de infraestructura",
            "Vigilancia",
            "Cartografía",
            "Entrega de paquetes"});
            this.cmbServicio.Location = new System.Drawing.Point(66, 160);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(180, 21);
            this.cmbServicio.TabIndex = 9;
            //
            // txtUbicacion
            //
            this.txtUbicacion.Location = new System.Drawing.Point(66, 210);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(180, 20);
            this.txtUbicacion.TabIndex = 10;
            //
            // mtxtFecha
            //
            this.mtxtFecha.Location = new System.Drawing.Point(66, 260);
            this.mtxtFecha.Mask = "00/00/0000";
            this.mtxtFecha.Name = "mtxtFecha";
            this.mtxtFecha.Size = new System.Drawing.Size(100, 20);
            this.mtxtFecha.TabIndex = 11;
            //
            // txtHora
            //
            this.txtHora.Location = new System.Drawing.Point(300, 110);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(80, 20);
            this.txtHora.TabIndex = 12;
            //
            // cmbPiloto
            //
            this.cmbPiloto.FormattingEnabled = true;
            this.cmbPiloto.Location = new System.Drawing.Point(300, 160);
            this.cmbPiloto.Name = "cmbPiloto";
            this.cmbPiloto.Size = new System.Drawing.Size(180, 21);
            this.cmbPiloto.TabIndex = 13;
            //
            // cmbDrone
            //
            this.cmbDrone.FormattingEnabled = true;
            this.cmbDrone.Location = new System.Drawing.Point(300, 210);
            this.cmbDrone.Name = "cmbDrone";
            this.cmbDrone.Size = new System.Drawing.Size(180, 21);
            this.cmbDrone.TabIndex = 14;
            //
            // txtObservaciones
            //
            this.txtObservaciones.Location = new System.Drawing.Point(300, 260);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(220, 60);
            this.txtObservaciones.TabIndex = 15;
            //
            // btnCrear
            //
            this.btnCrear.Location = new System.Drawing.Point(66, 350);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(110, 30);
            this.btnCrear.TabIndex = 16;
            this.btnCrear.Text = "Crear misión";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnPendiente_Click);
            //
            // btnAsignar
            //
            this.btnAsignar.Location = new System.Drawing.Point(190, 350);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(110, 30);
            this.btnAsignar.TabIndex = 17;
            this.btnAsignar.Text = "Asignar recursos";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnPendiente_Click);
            //
            // btnIniciar
            //
            this.btnIniciar.Location = new System.Drawing.Point(314, 350);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(110, 30);
            this.btnIniciar.TabIndex = 18;
            this.btnIniciar.Text = "Iniciar misión";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnPendiente_Click);
            //
            // btnFinalizar
            //
            this.btnFinalizar.Location = new System.Drawing.Point(438, 350);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(110, 30);
            this.btnFinalizar.TabIndex = 19;
            this.btnFinalizar.Text = "Finalizar misión";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnPendiente_Click);
            //
            // frmMision
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 420);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.cmbDrone);
            this.Controls.Add(this.cmbPiloto);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.mtxtFecha);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.cmbServicio);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMision";
            this.Text = "Gestión de misiones";
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbServicio;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.MaskedTextBox mtxtFecha;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.ComboBox cmbPiloto;
        private System.Windows.Forms.ComboBox cmbDrone;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnFinalizar;
    }
}