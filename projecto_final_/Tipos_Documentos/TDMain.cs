using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tipos_Documentos
{
    public partial class Form_Tipos_Documentos : Form
    {

        private BusinessLogicLayer _businessLogicLayer;

        public Form_Tipos_Documentos()
        {
            InitializeComponent();
            _businessLogicLayer = new BusinessLogicLayer();
            txtIdTD.Enabled = false;
        }

        

        #region Metodos CRUD

        //Insertar
        private void Insertar()
        {
            Tipo_Documento TD = new Tipo_Documento();

            TD.Descripcion = txtDescTD.Text;
            TD.Cuenta_Contable = txtCcTD.Text;
            TD.Estado = cbEstado.Text;

            _businessLogicLayer.GuardarTD(TD);
        }

        //Modificar
        private void Modificar()
        {
            Tipo_Documento TD = new Tipo_Documento();

            TD.IDTemp = txtIdTD.Text; 
            TD.Descripcion = txtDescTD.Text;
            TD.Cuenta_Contable = txtCcTD.Text;
            TD.Estado = cbEstado.Text;

            if (MessageBox.Show("Está seguro que desea modificar este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes) { 

                _businessLogicLayer.ModificarTD(TD);
                MessageBox.Show("Registro modificado correctamente");
            }
        }

        //Borrar
        private void Borrar()
        {
            Tipo_Documento TD = new Tipo_Documento();

            TD.IDTemp = txtIdTD.Text;


            if (MessageBox.Show("Está seguro que desea Borrar este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                _businessLogicLayer.BorrarTD(TD);
                Limpiar();
                MessageBox.Show("Registro borrado correctamente");
            }
        }

        #endregion


        #region Metodos
        private void MostrarTabla(string searchText = null)
        {
            List<Tipo_Documento> tipo_Documentos = _businessLogicLayer.GetTipo_Documento(searchText);
            dgvTD.DataSource = tipo_Documentos;
        }

        private void Limpiar()
        {
            txtIdTD.Text = "";
            txtDescTD.Text = "";
            txtCcTD.Text = "";
            cbEstado.Text = "";

            txtDescTD.Focus();
        }

        #endregion

        #region Eventos
        //Load
        private void Form_Tipos_Documentos_Load(object sender, EventArgs e)
        {
            MostrarTabla();
        }

        //Nuevo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        //Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Insertar();
            MostrarTabla();
            MessageBox.Show("Registro guardado correctamente");
        }

        //Modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
            MostrarTabla();
        }

        //Borrar
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Borrar();
            MostrarTabla();
        }

        //Llenar campos
        private void dgvTD_SelectionChanged(object sender, EventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;

            txtIdTD.Text = row.Cells[0].Value.ToString();
            txtDescTD.Text = row.Cells[1].Value.ToString();
            txtCcTD.Text = row.Cells[2].Value.ToString();
            cbEstado.Text = row.Cells[3].Value.ToString();
        }

        //Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarTabla(txtBuscar.Text);
            txtBuscar.Text = string.Empty;
        }

        //Salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        #endregion


    }
}
