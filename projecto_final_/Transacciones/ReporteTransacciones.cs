using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Transacciones
{
    public partial class ReporteTransacciones : Form
    {
        public ReporteTransacciones()
        {
            InitializeComponent();
        }

        private void ReporteTransacciones_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetGeneral.MostrarTransaccion' table. You can move, or remove it, as needed.
            this.mostrarTransaccionTableAdapter.Fill(this.dataSetGeneral.MostrarTransaccion);

            this.ReporteTransaccionesViewer.RefreshReport();
        }
    }
}
