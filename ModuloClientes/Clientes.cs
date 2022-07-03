﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Input;
using System.Windows.Forms;
using System.Data.Common;
using ConexionDB;


namespace ModuloClientes
{
    public class Clientes : ConexionDB.Conexion
    {
        private int idCliente;
        private string nombreCliente;
        private string rtnCliente;
        private string direccionCliente;
        private DateTime fechaCreacion;
        private DateTime fechaModificacion;
        


        public int IdCliente
        {
            get { return idCliente; }
            set { IdCliente = value; }
        }

        public string NombreCliente { get { return nombreCliente; } set { nombreCliente = value; } }

        public string RtnCliente { get { return rtnCliente; } set { rtnCliente = value; } }

        public string DireccionCliente { get { return direccionCliente; } set { direccionCliente = value; } }

        public DateTime FechaCreacion { get { return fechaCreacion; } set { fechaCreacion = DateTime.Now; } } 

        public DateTime FechaModificacion { get { return fechaModificacion; } set { fechaModificacion = DateTime.Now;  } }


        public void CargarDataGriewClientes(DataGridView dvg)
        {
            cnx.Open();
            try
            {
                DataAdapter = new SqlDataAdapter(@"SELECT * FROM CLIENTES", ccnx);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                dvg.DataSource = dt;

            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            cnx.Close();

        }

        public void CargarClientes(ComboBox comboBoxClientes)
        {
            cnx.Open();
            sql = string.Format(@"SELECT * FROM CLIENTES");
            cmd = new SqlCommand(sql, cnx);
            DataAdapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            DataAdapter.Fill(dt);
            cnx.Close();

            comboBoxClientes.ValueMember = "ID_CLIENTE";
            comboBoxClientes.DisplayMember = "NOMBRE";
            comboBoxClientes.DataSource = dt;
        }



    }
}
