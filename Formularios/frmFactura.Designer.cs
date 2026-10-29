namespace DroneOpsManager.Formularios
{
    partial class frmFactura
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
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbMision = new System.Windows.Forms.ComboBox();
            this.mtxtFecha = new System.Windows.Forms.MaskedTextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
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
            this.label1.Text = "Facturación";
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
            this.label3.Text = "Misión finalizada";
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 190);
            this.label4.Name = "label4";
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha (dd/mm/aaaa)";
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 90);
            this.label5.Name = "label5";
            this.label5.TabIndex = 4;
            this.label5.Text = "Subtotal";
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 140);
            this.label6.Name = "label6";
            this.label6.TabIndex = 5;
            this.label6.Text = "IVA (19 %)";
            //
            // label7
            //
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(330, 190);
            this.label7.Name = "label7";
            this.label7.TabIndex = 6;
            this.label7.Text = "Total";
            //
            // cmbCliente
            //
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(66, 110);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(200, 21);
            this.cmbCliente.TabIndex = 7;
            //
            // cmbMision
            //
            this.cmbMision.FormattingEnabled = true;
            this.cmbMision.Location = new System.Drawing.Point(66, 160);
            this.cmbMision.Name = "cmbMision";
            this.cmbMision.Size = new System.Drawing.Size(200, 21);
            this.cmbMision.TabIndex = 8;
            //
            // mtxtFecha
            //
            this.mtxtFecha.Location = new System.Drawing.Point(66, 210);
            this.mtxtFecha.Mask = "00/00/0000";
            this.mtxtFecha.Name = "mtxtFecha";
            this.mtxtFecha.Size = new System.Drawing.Size(100, 20);
            this.mtxtFecha.TabIndex = 9;
            //
            // txtSubtotal
            //
            this.txtSubtotal.Location = new System.Drawing.Point(330, 110);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(150, 20);
            this.txtSubtotal.TabIndex = 10;
            //
            // txtIVA
            //
            this.txtIVA.Location = new System.Drawing.Point(330, 160);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.ReadOnly = true;
            this.txtIVA.Size = new System.Drawing.Size(150, 20);
            this.txtIVA.TabIndex = 11;
            //
            // txtTotal
            //
            this.txtTotal.Location = new System.Drawing.Point(330, 210);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(150, 20);
            this.txtTotal.TabIndex = 12;
            //
            // btnCalcular
            //
            this.btnCalcular.Location = new System.Drawing.Point(500, 150);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(110, 30);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular total";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnPendiente_Click);
            //
            // btnGenerar
            //
            this.btnGenerar.Location = new System.Drawing.Point(500, 190);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(110, 30);
            this.btnGenerar.TabIndex = 14;
            this.btnGenerar.Text = "Generar factura";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnPendiente_Click);
            //
            // dgvFacturas
            //
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Location = new System.Drawing.Point(66, 260);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.Size = new System.Drawing.Size(620, 180);
            this.dgvFacturas.TabIndex = 15;
            //
            // frmFactura
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 460);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.mtxtFecha);
            this.Controls.Add(this.cmbMision);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFactura";
            this.Text = "Facturación";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbMision;
        private System.Windows.Forms.MaskedTextBox mtxtFecha;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dgvFacturas;
    }
}