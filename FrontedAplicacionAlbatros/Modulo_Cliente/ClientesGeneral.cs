using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModuloClientes;

namespace FrontedAplicacionAlbatros.Modulo_Cliente
{
    public partial class ClientesGeneral : Form
    {
        public ClientesGeneral()
        {
            InitializeComponent();
        }

        private void buttonSeleccionarCliente_Click(object sender, EventArgs e)
        {
            ModificacionClientes modificacionClientes = new ModificacionClientes();
            modificacionClientes.ShowDialog();
        }

        private void ClientesGeneral_Load(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.CargarDataGriewClientes(dataGridClientesListado);
        }
    }
}
