namespace DroneOpsManager.Formularios
{
    partial class frmReportes
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
            this.btnMisiones = new System.Windows.Forms.Button();
            this.btnDrones = new System.Windows.Forms.Button();
            this.btnPilotos = new System.Windows.Forms.Button();
            this.btnMantenimientos = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnIngresos = new System.Windows.Forms.Button();
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
            this.label1.Text = "Reportes";
            //
            // btnMisiones
            //
            this.btnMisiones.Location = new System.Drawing.Point(67, 100);
            this.btnMisiones.Name = "btnMisiones";
            this.btnMisiones.Size = new System.Drawing.Size(300, 35);
            this.btnMisiones.TabIndex = 1;
            this.btnMisiones.Text = "Misiones completadas y canceladas";
            this.btnMisiones.UseVisualStyleBackColor = true;
            this.btnMisiones.Click += new System.EventHandler(this.btnPendiente_Click);
            //
            // btnDrones
            //
            this.btnDrones.Location = new System.Drawing.Point(67, 150);
            this.btnDrones.Name = "btnDrones";
            this.btnDrones.Size = new System.Drawing.Size(300, 35);
            this.btnDrones.TabIndex = 2;
            this.btnDrones.Text = "Drones más utilizados y horas de vuelo";
            this.btnDrones.UseVisualStyleBackColor = true;
            this.btnDrones.Click += new System.EventHandler(this.btnPendiente_Click);
            //
            // btnPilotos
            //
            this.btnPilotos.Location = new System.Drawing.Point(67, 200);
            this.btnPilotos.Name = "btnPilotos";
            this.btnPilotos.Size = new System.Drawing.Size(300, 35);
            this.btnPilotos.TabIndex = 3;
            this.btnPilotos.Text = "Pilotos con mayor actividad";
            this.btnPilotos.UseVisualStyleBackColor = true;
            this.btnPilotos.Click += new System.EventHandler(this.btnPendiente_Click);
            //
            // btnMantenimientos
            //
            this.btnMantenimientos.Location = new System.Drawing.Point(67, 250);
            this.btnMantenimientos.Name = "btnMantenimientos";
            this.btnMantenimientos.Size = new System.Drawing.Size(300, 35);
            this.btnMantenimientos.TabIndex = 4;
            this.btnMantenimientos.Text = "Mantenimientos y costos de reparación";
            this.btnMantenimientos.UseVisualStyleBackColor = true;
            this.btnMantenimientos.Click += new System.EventHandler(this.btnPendiente_Click);
            //
            // btnInventario
            //
            this.btnInventario.Location = new System.Drawing.Point(67, 300);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(300, 35);
            this.btnInventario.TabIndex = 5;
            this.btnInventario.Text = "Inventario y repuestos con stock bajo";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnPendiente_Click);
            //
            // btnIngresos
            //
            this.btnIngresos.Location = new System.Drawing.Point(67, 350);
            this.btnIngresos.Name = "btnIngresos";
            this.btnIngresos.Size = new System.Drawing.Size(300, 35);
            this.btnIngresos.TabIndex = 6;
            this.btnIngresos.Text = "Ingresos por mes";
            this.btnIngresos.UseVisualStyleBackColor = true;
            this.btnIngresos.Click += new System.EventHandler(this.btnPendiente_Click);
            //
            // frmReportes
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 430);
            this.Controls.Add(this.btnIngresos);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.btnMantenimientos);
            this.Controls.Add(this.btnPilotos);
            this.Controls.Add(this.btnDrones);
            this.Controls.Add(this.btnMisiones);
            this.Controls.Add(this.label1);
            this.Name = "frmReportes";
            this.Text = "Reportes";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMisiones;
        private System.Windows.Forms.Button btnDrones;
        private System.Windows.Forms.Button btnPilotos;
        private System.Windows.Forms.Button btnMantenimientos;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnIngresos;
    }
}