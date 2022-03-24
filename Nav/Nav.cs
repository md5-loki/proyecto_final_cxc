using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projecto_final_;
using CRUD_Balances;
using Tipos_Documentos;

namespace Nav
{
    public partial class Nav : Form
    {
        public Nav()
        {
            InitializeComponent();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            projecto_final_.MainClientes mainClientes = new MainClientes();
            mainClientes.Show();
        }

        private void mantenimientoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tipos_Documentos.Form_Tipos_Documentos documentos = new Form_Tipos_Documentos();
            documentos.Show();
        }

        private void mantenimientoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CRUD_Balances.Main balances = new Main();
            balances.Show();
        }
    }
}
