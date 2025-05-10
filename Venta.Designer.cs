namespace EF_FP_G12
{
    partial class Venta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venta));
            this.lblventa = new System.Windows.Forms.Label();
            this.lblnomventa = new System.Windows.Forms.Label();
            this.txtnomventa = new System.Windows.Forms.TextBox();
            this.gbventa = new System.Windows.Forms.GroupBox();
            this.txtapevent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpreciovent = new System.Windows.Forms.TextBox();
            this.lblprecios = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.txtnomprod = new System.Windows.Forms.TextBox();
            this.lblprodventa = new System.Windows.Forms.Label();
            this.btnsalirvent = new System.Windows.Forms.Button();
            this.dgvventa = new System.Windows.Forms.DataGridView();
            this.btnregventa = new System.Windows.Forms.Button();
            this.lblTotalGastado = new System.Windows.Forms.Label();
            this.gbventa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvventa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblventa
            // 
            this.lblventa.AutoSize = true;
            this.lblventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblventa.Location = new System.Drawing.Point(295, 18);
            this.lblventa.Name = "lblventa";
            this.lblventa.Size = new System.Drawing.Size(248, 31);
            this.lblventa.TabIndex = 0;
            this.lblventa.Text = "Registro de Venta";
            // 
            // lblnomventa
            // 
            this.lblnomventa.AutoSize = true;
            this.lblnomventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnomventa.Location = new System.Drawing.Point(22, 36);
            this.lblnomventa.Name = "lblnomventa";
            this.lblnomventa.Size = new System.Drawing.Size(135, 15);
            this.lblnomventa.TabIndex = 1;
            this.lblnomventa.Text = "Nombre del Cliente:";
            // 
            // txtnomventa
            // 
            this.txtnomventa.Location = new System.Drawing.Point(163, 33);
            this.txtnomventa.Name = "txtnomventa";
            this.txtnomventa.Size = new System.Drawing.Size(267, 21);
            this.txtnomventa.TabIndex = 2;
            this.txtnomventa.Leave += new System.EventHandler(this.txtnomventa_Leave);
            // 
            // gbventa
            // 
            this.gbventa.Controls.Add(this.txtapevent);
            this.gbventa.Controls.Add(this.label1);
            this.gbventa.Controls.Add(this.txtpreciovent);
            this.gbventa.Controls.Add(this.lblprecios);
            this.gbventa.Controls.Add(this.txtcantidad);
            this.gbventa.Controls.Add(this.lblcantidad);
            this.gbventa.Controls.Add(this.txtnomprod);
            this.gbventa.Controls.Add(this.lblprodventa);
            this.gbventa.Controls.Add(this.txtnomventa);
            this.gbventa.Controls.Add(this.lblnomventa);
            this.gbventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbventa.Location = new System.Drawing.Point(72, 67);
            this.gbventa.Name = "gbventa";
            this.gbventa.Size = new System.Drawing.Size(452, 214);
            this.gbventa.TabIndex = 3;
            this.gbventa.TabStop = false;
            this.gbventa.Text = "Datos de Venta";
            // 
            // txtapevent
            // 
            this.txtapevent.Location = new System.Drawing.Point(163, 62);
            this.txtapevent.Name = "txtapevent";
            this.txtapevent.ReadOnly = true;
            this.txtapevent.Size = new System.Drawing.Size(267, 21);
            this.txtapevent.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Apellidos del Cliente:";
            // 
            // txtpreciovent
            // 
            this.txtpreciovent.Location = new System.Drawing.Point(163, 158);
            this.txtpreciovent.Name = "txtpreciovent";
            this.txtpreciovent.ReadOnly = true;
            this.txtpreciovent.Size = new System.Drawing.Size(267, 21);
            this.txtpreciovent.TabIndex = 8;
            // 
            // lblprecios
            // 
            this.lblprecios.AutoSize = true;
            this.lblprecios.Location = new System.Drawing.Point(105, 161);
            this.lblprecios.Name = "lblprecios";
            this.lblprecios.Size = new System.Drawing.Size(52, 15);
            this.lblprecios.TabIndex = 7;
            this.lblprecios.Text = "Precio:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(163, 125);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(267, 21);
            this.txtcantidad.TabIndex = 6;
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(89, 128);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(68, 15);
            this.lblcantidad.TabIndex = 5;
            this.lblcantidad.Text = "Cantidad:";
            // 
            // txtnomprod
            // 
            this.txtnomprod.Location = new System.Drawing.Point(163, 93);
            this.txtnomprod.Name = "txtnomprod";
            this.txtnomprod.Size = new System.Drawing.Size(267, 21);
            this.txtnomprod.TabIndex = 4;
            this.txtnomprod.Leave += new System.EventHandler(this.txtnomprod_Leave);
            // 
            // lblprodventa
            // 
            this.lblprodventa.AutoSize = true;
            this.lblprodventa.Location = new System.Drawing.Point(89, 96);
            this.lblprodventa.Name = "lblprodventa";
            this.lblprodventa.Size = new System.Drawing.Size(68, 15);
            this.lblprodventa.TabIndex = 3;
            this.lblprodventa.Text = "Producto:";
            // 
            // btnsalirvent
            // 
            this.btnsalirvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalirvent.Image = ((System.Drawing.Image)(resources.GetObject("btnsalirvent.Image")));
            this.btnsalirvent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsalirvent.Location = new System.Drawing.Point(564, 195);
            this.btnsalirvent.Name = "btnsalirvent";
            this.btnsalirvent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnsalirvent.Size = new System.Drawing.Size(121, 39);
            this.btnsalirvent.TabIndex = 4;
            this.btnsalirvent.Text = "Salir";
            this.btnsalirvent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsalirvent.UseVisualStyleBackColor = true;
            this.btnsalirvent.Click += new System.EventHandler(this.btnsalirvent_Click);
            // 
            // dgvventa
            // 
            this.dgvventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvventa.Location = new System.Drawing.Point(63, 303);
            this.dgvventa.Name = "dgvventa";
            this.dgvventa.ReadOnly = true;
            this.dgvventa.Size = new System.Drawing.Size(513, 142);
            this.dgvventa.TabIndex = 5;
            // 
            // btnregventa
            // 
            this.btnregventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregventa.Image = ((System.Drawing.Image)(resources.GetObject("btnregventa.Image")));
            this.btnregventa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnregventa.Location = new System.Drawing.Point(564, 137);
            this.btnregventa.Name = "btnregventa";
            this.btnregventa.Size = new System.Drawing.Size(121, 40);
            this.btnregventa.TabIndex = 6;
            this.btnregventa.Text = "Registrar";
            this.btnregventa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnregventa.UseVisualStyleBackColor = true;
            this.btnregventa.Click += new System.EventHandler(this.btnregventa_Click);
            // 
            // lblTotalGastado
            // 
            this.lblTotalGastado.AutoSize = true;
            this.lblTotalGastado.Location = new System.Drawing.Point(541, 480);
            this.lblTotalGastado.Name = "lblTotalGastado";
            this.lblTotalGastado.Size = new System.Drawing.Size(35, 13);
            this.lblTotalGastado.TabIndex = 7;
            this.lblTotalGastado.Text = "label2";
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.lblTotalGastado);
            this.Controls.Add(this.btnregventa);
            this.Controls.Add(this.dgvventa);
            this.Controls.Add(this.btnsalirvent);
            this.Controls.Add(this.gbventa);
            this.Controls.Add(this.lblventa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Venta";
            this.Text = "Venta";
            this.gbventa.ResumeLayout(false);
            this.gbventa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvventa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblventa;
        private System.Windows.Forms.Label lblnomventa;
        private System.Windows.Forms.TextBox txtnomventa;
        private System.Windows.Forms.GroupBox gbventa;
        private System.Windows.Forms.Label lblprodventa;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox txtnomprod;
        private System.Windows.Forms.TextBox txtpreciovent;
        private System.Windows.Forms.Label lblprecios;
        private System.Windows.Forms.Button btnsalirvent;
        private System.Windows.Forms.DataGridView dgvventa;
        private System.Windows.Forms.TextBox txtapevent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnregventa;
        private System.Windows.Forms.Label lblTotalGastado;
    }
}