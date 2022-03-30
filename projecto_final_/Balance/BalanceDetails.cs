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
    public partial class BalanceDetails : Form
    {
        private CapaNegocios _capaNegocios;
        private Balance _balance;

        public BalanceDetails()
        {
            InitializeComponent();
            _capaNegocios = new CapaNegocios();
        }

        #region EVENTS

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveBalance();
            this.Close();
            ((Main)this.Owner).PopulateBalances();
        }

        #endregion

        #region PRIVATE METHOD

        private void SaveBalance()
        {
            Balance balance = new Balance();

            balance.IdentificadorCliente = txtIdCliente.Text;
            balance.FechaCorte = DatePickerFechaCorte.Value;
            balance.AntigüedadPromedioSaldos = txtAntiguedadPromedioSaldos.Text;
            balance.Monto = txtMonto.Text;

            balance.Identificador = _balance != null ? _balance.Identificador : 0;

            _capaNegocios.SaveBalance(balance);
        }

        private void ClearForm()
        {
            txtIdCliente.Text = string.Empty;
            DatePickerFechaCorte.Value = DateTime.Today;
            txtAntiguedadPromedioSaldos.Text = string.Empty;
            txtMonto.Text = string.Empty;
        }

        #endregion

        #region PUBLIC METHOD

        public void LoadBalance(Balance balance)
        {
            _balance = balance;

            if (balance != null)
            {
                ClearForm();

                txtIdCliente.Text = balance.IdentificadorCliente;
                DatePickerFechaCorte.Value = balance.FechaCorte;
                txtAntiguedadPromedioSaldos.Text = balance.AntigüedadPromedioSaldos;
                txtMonto.Text = balance.Monto;

            }
        }

        #endregion

        private void DatePickerFechaCorte_ValueChanged(object sender, EventArgs e)
        {
        }

        private void txtFechaCorte_TextChanged(object sender, EventArgs e)
        {
        }

        private void BalanceDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
