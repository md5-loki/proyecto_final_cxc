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
    public partial class Main : Form
    {
        private CapaNegocios _capaNegocios;
        public Main()
        {
            InitializeComponent();
            _capaNegocios = new CapaNegocios();
        }

        #region EVENTS
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenTransaccionDetailsDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            PopulateTransacciones();
        }

        private void GridTransacciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)GridTransacciones.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell.Value.ToString() == "Editar")
            {
                TransaccionDetails transaccionDetails = new TransaccionDetails();
                transaccionDetails.LoadTransaccion(new Transaccion
                {
                    IdentificadorTransaccion = int.Parse(GridTransacciones.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    TipoMovimiento = GridTransacciones.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    IdentificadorTipoDocumento = GridTransacciones.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    NumeroDocumento = GridTransacciones.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    Fecha = (DateTime)GridTransacciones.Rows[e.RowIndex].Cells[4].Value,
                    IdentificadorCliente = GridTransacciones.Rows[e.RowIndex].Cells[5].Value.ToString(),
                    Monto = GridTransacciones.Rows[e.RowIndex].Cells[6].Value.ToString(),
                });
                transaccionDetails.ShowDialog(this);
            }
            else if (cell.Value.ToString() == "Eliminar")
            {
                DeleteTransaccion(int.Parse(GridTransacciones.Rows[e.RowIndex].Cells[0].Value.ToString()));
                PopulateTransacciones();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PopulateTransacciones(txtSearch.Text);
            txtSearch.Text = String.Empty;
        }


        #endregion

        #region PRIVATE METHODS
        private void OpenTransaccionDetailsDialog()
        {
            TransaccionDetails transaccionDetails = new TransaccionDetails();
            transaccionDetails.ShowDialog(this);
        }

        private void DeleteTransaccion(int identificadorTransaccion)
        {
            _capaNegocios.DeleteTransaccion(identificadorTransaccion);
        }
        #endregion

        #region PUBLIC METHODS
        public void PopulateTransacciones(string searchText = null)
        {
            List<Transaccion> transacciones = _capaNegocios.GetTransacciones(searchText);
            GridTransacciones.DataSource = transacciones;
        }
        #endregion

    }
}
