﻿namespace FrontedAplicacionAlbatros.Modulo_Cliente
{
    partial class ClientesGeneral
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
            this.tabControlClientes = new System.Windows.Forms.TabControl();
            this.tabBusqueda = new System.Windows.Forms.TabPage();
            this.tabCreacion = new System.Windows.Forms.TabPage();
            this.dataGridClientesListado = new System.Windows.Forms.DataGridView();
            this.labelRTN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.lableIdCliente = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.buttonGuardarClientes = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlClientes.SuspendLayout();
            this.tabBusqueda.SuspendLayout();
            this.tabCreacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientesListado)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlClientes
            // 
            this.tabControlClientes.Controls.Add(this.tabBusqueda);
            this.tabControlClientes.Controls.Add(this.tabCreacion);
            this.tabControlClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlClientes.Location = new System.Drawing.Point(0, 0);
            this.tabControlClientes.Name = "tabControlClientes";
            this.tabControlClientes.SelectedIndex = 0;
            this.tabControlClientes.Size = new System.Drawing.Size(800, 432);
            this.tabControlClientes.TabIndex = 0;
            // 
            // tabBusqueda
            // 
            this.tabBusqueda.Controls.Add(this.label1);
            this.tabBusqueda.Controls.Add(this.dataGridClientesListado);
            this.tabBusqueda.Location = new System.Drawing.Point(4, 22);
            this.tabBusqueda.Name = "tabBusqueda";
            this.tabBusqueda.Padding = new System.Windows.Forms.Padding(3);
            this.tabBusqueda.Size = new System.Drawing.Size(792, 406);
            this.tabBusqueda.TabIndex = 0;
            this.tabBusqueda.Text = "Busqueda de Clientes";
            this.tabBusqueda.UseVisualStyleBackColor = true;
            // 
            // tabCreacion
            // 
            this.tabCreacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabCreacion.Controls.Add(this.buttonCancelar);
            this.tabCreacion.Controls.Add(this.buttonGuardarClientes);
            this.tabCreacion.Controls.Add(this.textBox4);
            this.tabCreacion.Controls.Add(this.textBox3);
            this.tabCreacion.Controls.Add(this.textBox2);
            this.tabCreacion.Controls.Add(this.textBox1);
            this.tabCreacion.Controls.Add(this.lableIdCliente);
            this.tabCreacion.Controls.Add(this.labelDireccion);
            this.tabCreacion.Controls.Add(this.label3);
            this.tabCreacion.Controls.Add(this.labelRTN);
            this.tabCreacion.Location = new System.Drawing.Point(4, 22);
            this.tabCreacion.Name = "tabCreacion";
            this.tabCreacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreacion.Size = new System.Drawing.Size(792, 406);
            this.tabCreacion.TabIndex = 1;
            this.tabCreacion.Text = "Creacion de Clientes";
            // 
            // dataGridClientesListado
            // 
            this.dataGridClientesListado.AllowUserToAddRows = false;
            this.dataGridClientesListado.AllowUserToDeleteRows = false;
            this.dataGridClientesListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridClientesListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridClientesListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientesListado.Location = new System.Drawing.Point(8, 49);
            this.dataGridClientesListado.Name = "dataGridClientesListado";
            this.dataGridClientesListado.ReadOnly = true;
            this.dataGridClientesListado.Size = new System.Drawing.Size(776, 349);
            this.dataGridClientesListado.TabIndex = 0;
            // 
            // labelRTN
            // 
            this.labelRTN.AutoSize = true;
            this.labelRTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRTN.Location = new System.Drawing.Point(23, 96);
            this.labelRTN.Name = "labelRTN";
            this.labelRTN.Size = new System.Drawing.Size(36, 16);
            this.labelRTN.TabIndex = 1;
            this.labelRTN.Text = "RTN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Cliente";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccion.Location = new System.Drawing.Point(23, 126);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(64, 16);
            this.labelDireccion.TabIndex = 3;
            this.labelDireccion.Text = "Direccion";
            // 
            // lableIdCliente
            // 
            this.lableIdCliente.AutoSize = true;
            this.lableIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableIdCliente.Location = new System.Drawing.Point(23, 30);
            this.lableIdCliente.Name = "lableIdCliente";
            this.lableIdCliente.Size = new System.Drawing.Size(64, 16);
            this.lableIdCliente.TabIndex = 4;
            this.lableIdCliente.Text = "ID Cliente";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(173, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(173, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 22);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(173, 95);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(215, 22);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(173, 126);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(215, 156);
            this.textBox4.TabIndex = 8;
            // 
            // buttonGuardarClientes
            // 
            this.buttonGuardarClientes.Location = new System.Drawing.Point(173, 288);
            this.buttonGuardarClientes.Name = "buttonGuardarClientes";
            this.buttonGuardarClientes.Size = new System.Drawing.Size(215, 47);
            this.buttonGuardarClientes.TabIndex = 9;
            this.buttonGuardarClientes.Text = "Guardar Datos";
            this.buttonGuardarClientes.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(173, 341);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(215, 47);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(462, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "*Doble Click en datos del Cliente para observar detalles / Modificar";
            // 
            // ClientesGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 432);
            this.Controls.Add(this.tabControlClientes);
            this.Name = "ClientesGeneral";
            this.Text = "Gestion de Clientes";
            this.tabControlClientes.ResumeLayout(false);
            this.tabBusqueda.ResumeLayout(false);
            this.tabBusqueda.PerformLayout();
            this.tabCreacion.ResumeLayout(false);
            this.tabCreacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientesListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlClientes;
        private System.Windows.Forms.TabPage tabBusqueda;
        private System.Windows.Forms.TabPage tabCreacion;
        private System.Windows.Forms.DataGridView dataGridClientesListado;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardarClientes;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lableIdCliente;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelRTN;
        private System.Windows.Forms.Label label1;
    }
}