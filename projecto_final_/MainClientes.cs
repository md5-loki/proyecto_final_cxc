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
    public partial class MainClientes : Form
    {
        private BusinessLogicLayer _businessLogicLayer;
        public MainClientes()
        {
            InitializeComponent();
            _businessLogicLayer = new BusinessLogicLayer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregarClientes agregarclientes = new AgregarClientes();
            agregarclientes.ShowDialog(this);

        }

        private void MainClientes_Load(object sender, EventArgs e)
        {
            cargarClientes();
        }

        public void cargarClientes(string busqueda = null)
        {
            List<Cliente> clientes = _businessLogicLayer.getClientes(busqueda);
            grid_clientes.DataSource = clientes;
        }

        private void grid_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                DataGridViewLinkCell celda = (DataGridViewLinkCell)grid_clientes.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (celda.Value.ToString() == "Editar")
                {
                    AgregarClientes agregarClientes = new AgregarClientes();
                    agregarClientes.CargarClientes(new Cliente
                    {
                        id = Convert.ToInt32(grid_clientes.Rows[e.RowIndex].Cells[0].Value.ToString()),
                        nombres = grid_clientes.Rows[e.RowIndex].Cells[1].Value.ToString(),
                        cedula = grid_clientes.Rows[e.RowIndex].Cells[2].Value.ToString(),
                        limite_credito = Convert.ToInt32((grid_clientes.Rows[e.RowIndex].Cells[3]).Value.ToString()),
                        estado = grid_clientes.Rows[e.RowIndex].Cells[4].Value.ToString(),
                    });
                    agregarClientes.ShowDialog(this);
                }
                else if (celda.Value.ToString() == "Borrar")
                {
                    _businessLogicLayer.delCliente(Convert.ToInt32(grid_clientes.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    cargarClientes();
                }
            }
            catch (InvalidCastException)
            {
                /*continue;*/
                /*throw;*/
            }

        }

        private void grid_clientes_SelectionChanged(object sender, EventArgs e)
        {
            if (grid_clientes.CurrentCell.RowIndex == 0 || grid_clientes.CurrentCell.RowIndex == 1 || grid_clientes.CurrentCell.RowIndex == 2 || grid_clientes.CurrentCell.RowIndex == 3 || grid_clientes.CurrentCell.RowIndex == 4)
            {
                grid_clientes.CurrentCell.Selected = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarClientes(txtBusqueda.Text);
            txtBusqueda.Text = string.Empty;
        }
    }
}
