﻿namespace EF_FP_G12
{
    partial class RegistroProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroProductos));
            this.btnstock = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.lbltituloreg = new System.Windows.Forms.Label();
            this.lbllistprod = new System.Windows.Forms.Label();
            this.gbdatprod = new System.Windows.Forms.GroupBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.dgvprod = new System.Windows.Forms.DataGridView();
            this.btnsalirprod = new System.Windows.Forms.Button();
            this.gbdatprod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprod)).BeginInit();
            this.SuspendLayout();
            // 
            // btnstock
            // 
            this.btnstock.AutoSize = true;
            this.btnstock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnstock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstock.Image = ((System.Drawing.Image)(resources.GetObject("btnstock.Image")));
            this.btnstock.Location = new System.Drawing.Point(566, 126);
            this.btnstock.Name = "btnstock";
            this.btnstock.Size = new System.Drawing.Size(154, 38);
            this.btnstock.TabIndex = 23;
            this.btnstock.Text = "Stock Productos";
            this.btnstock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnstock.UseVisualStyleBackColor = false;
            this.btnstock.Click += new System.EventHandler(this.btnstock_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.AutoSize = true;
            this.btncancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(566, 212);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(154, 38);
            this.btncancelar.TabIndex = 22;
            this.btncancelar.Text = "Cancelar Registro";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.AutoSize = true;
            this.btnregistrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnregistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnregistrar.Image")));
            this.btnregistrar.Location = new System.Drawing.Point(566, 80);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(154, 38);
            this.btnregistrar.TabIndex = 21;
            this.btnregistrar.Text = "Registrar Producto";
            this.btnregistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnregistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnregistrar.UseVisualStyleBackColor = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // lbltituloreg
            // 
            this.lbltituloreg.AutoSize = true;
            this.lbltituloreg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltituloreg.Location = new System.Drawing.Point(188, 22);
            this.lbltituloreg.Name = "lbltituloreg";
            this.lbltituloreg.Size = new System.Drawing.Size(266, 32);
            this.lbltituloreg.TabIndex = 20;
            this.lbltituloreg.Text = "Registrar Producto";
            // 
            // lbllistprod
            // 
            this.lbllistprod.AutoSize = true;
            this.lbllistprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllistprod.Location = new System.Drawing.Point(90, 271);
            this.lbllistprod.Name = "lbllistprod";
            this.lbllistprod.Size = new System.Drawing.Size(130, 15);
            this.lbllistprod.TabIndex = 18;
            this.lbllistprod.Text = "Lista de Productos:";
            // 
            // gbdatprod
            // 
            this.gbdatprod.Controls.Add(this.txtprecio);
            this.gbdatprod.Controls.Add(this.txtcategoria);
            this.gbdatprod.Controls.Add(this.txtnombre);
            this.gbdatprod.Controls.Add(this.txtcodigo);
            this.gbdatprod.Controls.Add(this.lblcodigo);
            this.gbdatprod.Controls.Add(this.lblprecio);
            this.gbdatprod.Controls.Add(this.lblcategoria);
            this.gbdatprod.Controls.Add(this.lblnombre);
            this.gbdatprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbdatprod.Location = new System.Drawing.Point(88, 73);
            this.gbdatprod.Name = "gbdatprod";
            this.gbdatprod.Size = new System.Drawing.Size(471, 182);
            this.gbdatprod.TabIndex = 17;
            this.gbdatprod.TabStop = false;
            this.gbdatprod.Text = "Datos del Producto";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(106, 133);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(323, 21);
            this.txtprecio.TabIndex = 13;
            // 
            // txtcategoria
            // 
            this.txtcategoria.Location = new System.Drawing.Point(106, 99);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(323, 21);
            this.txtcategoria.TabIndex = 11;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(108, 67);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(323, 21);
            this.txtnombre.TabIndex = 10;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(108, 36);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(327, 21);
            this.txtcodigo.TabIndex = 9;
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(29, 39);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(56, 15);
            this.lblcodigo.TabIndex = 8;
            this.lblcodigo.Text = "Código:";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(37, 136);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(52, 15);
            this.lblprecio.TabIndex = 6;
            this.lblprecio.Text = "Precio:";
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Location = new System.Drawing.Point(21, 98);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(73, 15);
            this.lblcategoria.TabIndex = 2;
            this.lblcategoria.Text = "Categoría:";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(27, 68);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(62, 15);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre:";
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.Location = new System.Drawing.Point(566, 169);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(154, 37);
            this.btnguardar.TabIndex = 24;
            this.btnguardar.Text = "Guardar datos";
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // dgvprod
            // 
            this.dgvprod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprod.Location = new System.Drawing.Point(88, 302);
            this.dgvprod.Name = "dgvprod";
            this.dgvprod.ReadOnly = true;
            this.dgvprod.Size = new System.Drawing.Size(544, 136);
            this.dgvprod.TabIndex = 25;
            // 
            // btnsalirprod
            // 
            this.btnsalirprod.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsalirprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalirprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalirprod.Image = ((System.Drawing.Image)(resources.GetObject("btnsalirprod.Image")));
            this.btnsalirprod.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsalirprod.Location = new System.Drawing.Point(287, 453);
            this.btnsalirprod.Name = "btnsalirprod";
            this.btnsalirprod.Size = new System.Drawing.Size(111, 38);
            this.btnsalirprod.TabIndex = 26;
            this.btnsalirprod.Text = "Salir";
            this.btnsalirprod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsalirprod.UseVisualStyleBackColor = false;
            this.btnsalirprod.Click += new System.EventHandler(this.btnsalirprod_Click);
            // 
            // RegistroProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 514);
            this.Controls.Add(this.btnsalirprod);
            this.Controls.Add(this.dgvprod);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnstock);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.lbltituloreg);
            this.Controls.Add(this.lbllistprod);
            this.Controls.Add(this.gbdatprod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroProductos";
            this.Text = "RegistroProductos";
            this.gbdatprod.ResumeLayout(false);
            this.gbdatprod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnstock;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Label lbltituloreg;
        private System.Windows.Forms.Label lbllistprod;
        private System.Windows.Forms.GroupBox gbdatprod;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.DataGridView dgvprod;
        private System.Windows.Forms.Button btnsalirprod;
    }
}