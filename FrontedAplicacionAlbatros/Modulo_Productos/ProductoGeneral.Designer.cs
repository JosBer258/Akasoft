﻿namespace FrontedAplicacionAlbatros.Modulo_Item
{
    partial class ProductoGeneral
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
            this.tabControlProductos = new System.Windows.Forms.TabControl();
            this.tabBusqueda = new System.Windows.Forms.TabPage();
            this.dataGridItemsListado = new System.Windows.Forms.DataGridView();
            this.tabCreacion = new System.Windows.Forms.TabPage();
            this.comboImpuestos = new System.Windows.Forms.ComboBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonGuardarClientes = new System.Windows.Forms.Button();
            this.textPrecioProducto = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lableIdProducto = new System.Windows.Forms.Label();
            this.labelImpuesto = new System.Windows.Forms.Label();
            this.labelDescripcionProducto = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlProductos.SuspendLayout();
            this.tabBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItemsListado)).BeginInit();
            this.tabCreacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlProductos
            // 
            this.tabControlProductos.Controls.Add(this.tabBusqueda);
            this.tabControlProductos.Controls.Add(this.tabCreacion);
            this.tabControlProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlProductos.Location = new System.Drawing.Point(0, 0);
            this.tabControlProductos.Name = "tabControlProductos";
            this.tabControlProductos.SelectedIndex = 0;
            this.tabControlProductos.Size = new System.Drawing.Size(800, 450);
            this.tabControlProductos.TabIndex = 1;
            // 
            // tabBusqueda
            // 
            this.tabBusqueda.Controls.Add(this.label1);
            this.tabBusqueda.Controls.Add(this.dataGridItemsListado);
            this.tabBusqueda.Location = new System.Drawing.Point(4, 22);
            this.tabBusqueda.Name = "tabBusqueda";
            this.tabBusqueda.Padding = new System.Windows.Forms.Padding(3);
            this.tabBusqueda.Size = new System.Drawing.Size(792, 424);
            this.tabBusqueda.TabIndex = 0;
            this.tabBusqueda.Text = "Busqueda de Productos";
            this.tabBusqueda.UseVisualStyleBackColor = true;
            // 
            // dataGridItemsListado
            // 
            this.dataGridItemsListado.AllowUserToAddRows = false;
            this.dataGridItemsListado.AllowUserToDeleteRows = false;
            this.dataGridItemsListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridItemsListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridItemsListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridItemsListado.Location = new System.Drawing.Point(8, 42);
            this.dataGridItemsListado.Name = "dataGridItemsListado";
            this.dataGridItemsListado.ReadOnly = true;
            this.dataGridItemsListado.Size = new System.Drawing.Size(776, 374);
            this.dataGridItemsListado.TabIndex = 0;
            // 
            // tabCreacion
            // 
            this.tabCreacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabCreacion.Controls.Add(this.comboImpuestos);
            this.tabCreacion.Controls.Add(this.buttonCancelar);
            this.tabCreacion.Controls.Add(this.buttonGuardarClientes);
            this.tabCreacion.Controls.Add(this.textPrecioProducto);
            this.tabCreacion.Controls.Add(this.textBox2);
            this.tabCreacion.Controls.Add(this.textBox1);
            this.tabCreacion.Controls.Add(this.lableIdProducto);
            this.tabCreacion.Controls.Add(this.labelImpuesto);
            this.tabCreacion.Controls.Add(this.labelDescripcionProducto);
            this.tabCreacion.Controls.Add(this.labelPrecio);
            this.tabCreacion.Location = new System.Drawing.Point(4, 22);
            this.tabCreacion.Name = "tabCreacion";
            this.tabCreacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreacion.Size = new System.Drawing.Size(792, 424);
            this.tabCreacion.TabIndex = 1;
            this.tabCreacion.Text = "Creacion de Productos";
            // 
            // comboImpuestos
            // 
            this.comboImpuestos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboImpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboImpuestos.FormattingEnabled = true;
            this.comboImpuestos.Location = new System.Drawing.Point(173, 126);
            this.comboImpuestos.Name = "comboImpuestos";
            this.comboImpuestos.Size = new System.Drawing.Size(215, 23);
            this.comboImpuestos.TabIndex = 11;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(173, 223);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(215, 47);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonGuardarClientes
            // 
            this.buttonGuardarClientes.Location = new System.Drawing.Point(173, 170);
            this.buttonGuardarClientes.Name = "buttonGuardarClientes";
            this.buttonGuardarClientes.Size = new System.Drawing.Size(215, 47);
            this.buttonGuardarClientes.TabIndex = 9;
            this.buttonGuardarClientes.Text = "Guardar Datos";
            this.buttonGuardarClientes.UseVisualStyleBackColor = true;
            // 
            // textPrecioProducto
            // 
            this.textPrecioProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrecioProducto.Location = new System.Drawing.Point(173, 95);
            this.textPrecioProducto.Name = "textPrecioProducto";
            this.textPrecioProducto.Size = new System.Drawing.Size(215, 22);
            this.textPrecioProducto.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(173, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(173, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 22);
            this.textBox1.TabIndex = 5;
            // 
            // lableIdProducto
            // 
            this.lableIdProducto.AutoSize = true;
            this.lableIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableIdProducto.Location = new System.Drawing.Point(23, 30);
            this.lableIdProducto.Name = "lableIdProducto";
            this.lableIdProducto.Size = new System.Drawing.Size(77, 16);
            this.lableIdProducto.TabIndex = 4;
            this.lableIdProducto.Text = "ID Producto";
            // 
            // labelImpuesto
            // 
            this.labelImpuesto.AutoSize = true;
            this.labelImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImpuesto.Location = new System.Drawing.Point(23, 130);
            this.labelImpuesto.Name = "labelImpuesto";
            this.labelImpuesto.Size = new System.Drawing.Size(62, 16);
            this.labelImpuesto.TabIndex = 3;
            this.labelImpuesto.Text = "Impuesto";
            // 
            // labelDescripcionProducto
            // 
            this.labelDescripcionProducto.AutoSize = true;
            this.labelDescripcionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcionProducto.Location = new System.Drawing.Point(23, 64);
            this.labelDescripcionProducto.Name = "labelDescripcionProducto";
            this.labelDescripcionProducto.Size = new System.Drawing.Size(79, 16);
            this.labelDescripcionProducto.TabIndex = 2;
            this.labelDescripcionProducto.Text = "Descripcion";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.Location = new System.Drawing.Point(23, 96);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(36, 16);
            this.labelPrecio.TabIndex = 1;
            this.labelPrecio.Text = "RTN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(451, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "*Doble Click en datos del Producto para observar detalles / Modificar";
            // 
            // ProductoGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlProductos);
            this.Name = "ProductoGeneral";
            this.Text = "Gestion de Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControlProductos.ResumeLayout(false);
            this.tabBusqueda.ResumeLayout(false);
            this.tabBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItemsListado)).EndInit();
            this.tabCreacion.ResumeLayout(false);
            this.tabCreacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlProductos;
        private System.Windows.Forms.TabPage tabBusqueda;
        private System.Windows.Forms.DataGridView dataGridItemsListado;
        private System.Windows.Forms.TabPage tabCreacion;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardarClientes;
        private System.Windows.Forms.TextBox textPrecioProducto;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lableIdProducto;
        private System.Windows.Forms.Label labelImpuesto;
        private System.Windows.Forms.Label labelDescripcionProducto;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.ComboBox comboImpuestos;
        private System.Windows.Forms.Label label1;
    }
}