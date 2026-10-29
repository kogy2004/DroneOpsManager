namespace DroneOpsManager.Formularios
{
    partial class frmInventario
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
            this.txtItem = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtStockMin = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
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
            this.label1.Text = "Inventario de repuestos";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 90);
            this.label2.Name = "label2";
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del item";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 90);
            this.label3.Name = "label3";
            this.label3.TabIndex = 2;
            this.label3.Text = "Categoría";
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 140);
            this.label4.Name = "label4";
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad";
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 140);
            this.label5.Name = "label5";
            this.label5.TabIndex = 4;
            this.label5.Text = "Stock mínimo / Precio unitario";
            //
            // txtItem
            //
            this.txtItem.Location = new System.Drawing.Point(66, 110);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(180, 20);
            this.txtItem.TabIndex = 5;
            //
            // cmbCategoria
            //
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Repuestos",
            "Baterías",
            "Equipos",
            "Sensores"});
            this.cmbCategoria.Location = new System.Drawing.Point(300, 110);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(150, 21);
            this.cmbCategoria.TabIndex = 6;
            //
            // txtCantidad
            //
            this.txtCantidad.Location = new System.Drawing.Point(66, 160);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 7;
            //
            // txtStockMin
            //
            this.txtStockMin.Location = new System.Drawing.Point(300, 160);
            this.txtStockMin.Name = "txtStockMin";
            this.txtStockMin.Size = new System.Drawing.Size(80, 20);
            this.txtStockMin.TabIndex = 8;
            //
            // txtPrecio
            //
            this.txtPrecio.Location = new System.Drawing.Point(390, 160);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(120, 20);
            this.txtPrecio.TabIndex = 9;
            //
            // btnEntrada
            //
            this.btnEntrada.Location = new System.Drawing.Point(66, 210);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(110, 30);
            this.btnEntrada.TabIndex = 10;
            this.btnEntrada.Text = "Registrar entrada";
            this.btnEntrada.UseVisualStyleBackColor = true;
            this.btnEntrada.Click += new System.EventHandler(this.btnPendiente_Click);
            //
            // btnSalida
            //
            this.btnSalida.Location = new System.Drawing.Point(190, 210);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(110, 30);
            this.btnSalida.TabIndex = 11;
            this.btnSalida.Text = "Registrar salida";
            this.btnSalida.UseVisualStyleBackColor = true;
            this.btnSalida.Click += new System.EventHandler(this.btnPendiente_Click);
            //
            // dgvInventario
            //
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(66, 260);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.Size = new System.Drawing.Size(620, 190);
            this.dgvInventario.TabIndex = 12;
            //
            // frmInventario
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 470);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtStockMin);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmInventario";
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtStockMin;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.DataGridView dgvInventario;
    }
}