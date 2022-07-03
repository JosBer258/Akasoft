namespace FrontedAplicacionAlbatros.Modulo_Facturas
{
    partial class CreacionFacturas
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
            this.groupDatosGenerales = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.labelIDCliente = new System.Windows.Forms.Label();
            this.groupResumen = new System.Windows.Forms.GroupBox();
            this.textTotalFactura = new System.Windows.Forms.TextBox();
            this.labelTotalFactura = new System.Windows.Forms.Label();
            this.textImpuesto = new System.Windows.Forms.TextBox();
            this.labelImpuesto = new System.Windows.Forms.Label();
            this.groupDetalles = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridItemsListado = new System.Windows.Forms.DataGridView();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonGuardarClientes = new System.Windows.Forms.Button();
            this.groupDatosGenerales.SuspendLayout();
            this.groupResumen.SuspendLayout();
            this.groupDetalles.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItemsListado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDatosGenerales
            // 
            this.groupDatosGenerales.Controls.Add(this.comboBox1);
            this.groupDatosGenerales.Controls.Add(this.dateTimePicker1);
            this.groupDatosGenerales.Controls.Add(this.label1);
            this.groupDatosGenerales.Controls.Add(this.labelIDCliente);
            this.groupDatosGenerales.Location = new System.Drawing.Point(22, 12);
            this.groupDatosGenerales.Name = "groupDatosGenerales";
            this.groupDatosGenerales.Size = new System.Drawing.Size(362, 100);
            this.groupDatosGenerales.TabIndex = 0;
            this.groupDatosGenerales.TabStop = false;
            this.groupDatosGenerales.Text = "Header";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(147, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(147, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fecha Creacion";
            // 
            // labelIDCliente
            // 
            this.labelIDCliente.AutoSize = true;
            this.labelIDCliente.Location = new System.Drawing.Point(12, 31);
            this.labelIDCliente.Name = "labelIDCliente";
            this.labelIDCliente.Size = new System.Drawing.Size(109, 13);
            this.labelIDCliente.TabIndex = 8;
            this.labelIDCliente.Text = "Seleccion de Clientes";
            // 
            // groupResumen
            // 
            this.groupResumen.Controls.Add(this.textTotalFactura);
            this.groupResumen.Controls.Add(this.labelTotalFactura);
            this.groupResumen.Controls.Add(this.textImpuesto);
            this.groupResumen.Controls.Add(this.labelImpuesto);
            this.groupResumen.Location = new System.Drawing.Point(401, 12);
            this.groupResumen.Name = "groupResumen";
            this.groupResumen.Size = new System.Drawing.Size(271, 100);
            this.groupResumen.TabIndex = 1;
            this.groupResumen.TabStop = false;
            this.groupResumen.Text = "Resumen";
            // 
            // textTotalFactura
            // 
            this.textTotalFactura.Location = new System.Drawing.Point(118, 57);
            this.textTotalFactura.Name = "textTotalFactura";
            this.textTotalFactura.ReadOnly = true;
            this.textTotalFactura.Size = new System.Drawing.Size(125, 20);
            this.textTotalFactura.TabIndex = 15;
            // 
            // labelTotalFactura
            // 
            this.labelTotalFactura.AutoSize = true;
            this.labelTotalFactura.Location = new System.Drawing.Point(8, 60);
            this.labelTotalFactura.Name = "labelTotalFactura";
            this.labelTotalFactura.Size = new System.Drawing.Size(70, 13);
            this.labelTotalFactura.TabIndex = 14;
            this.labelTotalFactura.Text = "Total Factura";
            // 
            // textImpuesto
            // 
            this.textImpuesto.Location = new System.Drawing.Point(118, 31);
            this.textImpuesto.Name = "textImpuesto";
            this.textImpuesto.ReadOnly = true;
            this.textImpuesto.Size = new System.Drawing.Size(125, 20);
            this.textImpuesto.TabIndex = 13;
            // 
            // labelImpuesto
            // 
            this.labelImpuesto.AutoSize = true;
            this.labelImpuesto.Location = new System.Drawing.Point(8, 34);
            this.labelImpuesto.Name = "labelImpuesto";
            this.labelImpuesto.Size = new System.Drawing.Size(92, 13);
            this.labelImpuesto.TabIndex = 12;
            this.labelImpuesto.Text = "Total de Impuesto";
            // 
            // groupDetalles
            // 
            this.groupDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupDetalles.Controls.Add(this.groupBox1);
            this.groupDetalles.Controls.Add(this.dataGridItemsListado);
            this.groupDetalles.Location = new System.Drawing.Point(22, 118);
            this.groupDetalles.Name = "groupDetalles";
            this.groupDetalles.Size = new System.Drawing.Size(1018, 451);
            this.groupDetalles.TabIndex = 2;
            this.groupDetalles.TabStop = false;
            this.groupDetalles.Text = "Detalles de Factura";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCancelar);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.buttonGuardarClientes);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(15, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 138);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumen";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(339, 54);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(125, 20);
            this.textBox3.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Impuesto %";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(121, 106);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(125, 20);
            this.textBox4.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Precio Unitario";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cantidad ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(125, 20);
            this.textBox2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Producto Nombre";
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
            this.dataGridItemsListado.Location = new System.Drawing.Point(15, 224);
            this.dataGridItemsListado.Name = "dataGridItemsListado";
            this.dataGridItemsListado.ReadOnly = true;
            this.dataGridItemsListado.Size = new System.Drawing.Size(983, 208);
            this.dataGridItemsListado.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(339, 80);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(125, 20);
            this.textBox5.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Impuesto Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Busqueda Producto";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(123, 25);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(341, 21);
            this.comboBox2.TabIndex = 13;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(547, 67);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(157, 33);
            this.buttonCancelar.TabIndex = 22;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonGuardarClientes
            // 
            this.buttonGuardarClientes.Location = new System.Drawing.Point(547, 25);
            this.buttonGuardarClientes.Name = "buttonGuardarClientes";
            this.buttonGuardarClientes.Size = new System.Drawing.Size(157, 33);
            this.buttonGuardarClientes.TabIndex = 21;
            this.buttonGuardarClientes.Text = "Guardar Datos";
            this.buttonGuardarClientes.UseVisualStyleBackColor = true;
            // 
            // CreacionFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1068, 581);
            this.Controls.Add(this.groupDetalles);
            this.Controls.Add(this.groupResumen);
            this.Controls.Add(this.groupDatosGenerales);
            this.Name = "CreacionFacturas";
            this.Text = "Creacion de Facturas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupDatosGenerales.ResumeLayout(false);
            this.groupDatosGenerales.PerformLayout();
            this.groupResumen.ResumeLayout(false);
            this.groupResumen.PerformLayout();
            this.groupDetalles.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridItemsListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupDatosGenerales;
        private System.Windows.Forms.GroupBox groupResumen;
        private System.Windows.Forms.GroupBox groupDetalles;
        private System.Windows.Forms.Label labelIDCliente;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTotalFactura;
        private System.Windows.Forms.Label labelTotalFactura;
        private System.Windows.Forms.TextBox textImpuesto;
        private System.Windows.Forms.Label labelImpuesto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridItemsListado;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardarClientes;
    }
}