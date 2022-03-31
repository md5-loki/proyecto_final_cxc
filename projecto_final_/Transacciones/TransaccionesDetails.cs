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
    public partial class TransaccionDetails : Form
    {
        private CapaNegocios _capaNegocios;
        private Transaccion _transaccion;
        public TransaccionDetails()
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
            SaveTransaccion();
            this.Close();
            ((Main)this.Owner).PopulateTransacciones();
        }
        #endregion

        #region PRIVATE METHOD
        private void SaveTransaccion()
        {
            Transaccion transaccion = new Transaccion();

            transaccion.TipoMovimiento = comboBoxTipoMovimiento.Text;
            transaccion.IdentificadorTipoDocumento = txtIdentificadorTipoDocumento.Text;
            transaccion.NumeroDocumento = txtNumeroDocumento.Text;
            transaccion.Fecha = DatePickerFecha.Value;
            transaccion.IdentificadorCliente = txtIdentificadorCliente.Text;
            transaccion.Monto = txtMonto.Text;

            transaccion.IdentificadorTransaccion = _transaccion != null ? _transaccion.IdentificadorTransaccion : 0;

            _capaNegocios.SaveTransaccion(transaccion);
        }
        private void ClearForm()
        {
            comboBoxTipoMovimiento.Text = string.Empty;
            txtIdentificadorTipoDocumento.Text = string.Empty;
            txtNumeroDocumento.Text = string.Empty;
            DatePickerFecha.Value = DateTime.Today;
            txtIdentificadorCliente.Text = string.Empty;
            txtMonto.Text = string.Empty;
        }
        #endregion

        #region PUBLIC METHOD
        public void LoadTransaccion(Transaccion transaccion)
        {
            _transaccion = transaccion;

            if (transaccion != null)
            {
                comboBoxTipoMovimiento.Text = transaccion.TipoMovimiento;
                txtIdentificadorTipoDocumento.Text = transaccion.IdentificadorTipoDocumento;
                txtNumeroDocumento.Text = transaccion.NumeroDocumento;
                DatePickerFecha.Value = transaccion.Fecha;
                txtIdentificadorCliente.Text = transaccion.IdentificadorCliente;
                txtMonto.Text = transaccion.Monto;
            }
        }
        #endregion
    }
}
