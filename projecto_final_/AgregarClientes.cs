using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projecto_final_
{
    public partial class AgregarClientes : Form
    {
        private BusinessLogicLayer _businessLogicLayer;
        private Cliente _cliente;
        public AgregarClientes()
        {
            InitializeComponent();
            _businessLogicLayer = new BusinessLogicLayer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.nombres = textBox1.Text;
            cliente.cedula = textBox2.Text;
            cliente.limite_credito = Convert.ToInt32(textBox4.Text);
            cliente.estado = textBox3.Text;

            cliente.id = _cliente != null ? _cliente.id : 0;

            _businessLogicLayer.guardarCliente(cliente);
            MessageBox.Show("Cliente agregado con exito", "Mensaje");

            this.Close();
            ((MainClientes)this.Owner).cargarClientes();
        }

        public void CargarClientes(Cliente cliente)
        {
            _cliente = cliente;
            if (cliente != null)
            {
                limpiar();

                textBox1.Text = cliente.nombres;
                textBox2.Text = cliente.cedula;
                textBox3.Text = cliente.estado;
                textBox4.Text = Convert.ToString(cliente.limite_credito);
            }
        }

        private void limpiar()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
        }
    }
}
