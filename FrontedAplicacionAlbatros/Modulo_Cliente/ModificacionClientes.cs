using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontedAplicacionAlbatros.Modulo_Cliente
{
    public partial class ModificacionClientes : Form
    {
        public string idCliente;
        public string nombreCliente;

        public ModificacionClientes()
        {
            InitializeComponent();
        }

        private void ModificacionClientes_Load(object sender, EventArgs e)
        {
            textIDCLiente.Text = idCliente;
            textNombre.Text = nombreCliente;
        }
    }
}
