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
            OpenBalanceDetailsDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            PopulateBalances();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)GridBalances.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (cell.Value.ToString() == "Editar")
            {
                BalanceDetails balanceDetails = new BalanceDetails();
                balanceDetails.LoadBalance(new Balance
                {
                    Identificador = int.Parse(GridBalances.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    IdentificadorCliente = (GridBalances.Rows[e.RowIndex].Cells[1].Value.ToString()),
                    FechaCorte = (DateTime)GridBalances.Rows[e.RowIndex].Cells[2].Value,
                    AntigüedadPromedioSaldos = GridBalances.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    Monto = GridBalances.Rows[e.RowIndex].Cells[4].Value.ToString(),
                });
                balanceDetails.ShowDialog(this);
            }
            else if (cell.Value.ToString() == "Eliminar")
            {
                DeleteBalance(int.Parse(GridBalances.Rows[e.RowIndex].Cells[0].Value.ToString()));
                PopulateBalances();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PopulateBalances(txtSearch.Text);
            txtSearch.Text = String.Empty;
        }

        #endregion

        #region PRIVATE METHODS

        private void OpenBalanceDetailsDialog()
        {
            BalanceDetails balanceDetails = new BalanceDetails();
            balanceDetails.ShowDialog(this);
        }

        private void DeleteBalance(int identificador)
        {
            _capaNegocios.DeleteBalance(identificador);
        }

        #endregion

        #region PUBLIC METHODS

        public void PopulateBalances(string searchText = null)
        {
            List<Balance> balances = _capaNegocios.GetBalances(searchText);
            GridBalances.DataSource = balances;

        }

        #endregion

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            FormReporteBalances Reportes = new FormReporteBalances();

            Reportes.ShowDialog();
        }
    }
}
