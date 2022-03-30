using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Balances
{
    public partial class FormReporteBalances : Form
    {
        public FormReporteBalances()
        {
            InitializeComponent();
        }

        private void FormReporteBalances_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetBalance.Mostrar_Balance_Cliente' Puede moverla o quitarla según sea necesario.
            this.Mostrar_Balance_ClienteTableAdapter.Fill(this.DataSetBalance.Mostrar_Balance_Cliente);

            this.reportViewer1.RefreshReport();
        }
    }
}
