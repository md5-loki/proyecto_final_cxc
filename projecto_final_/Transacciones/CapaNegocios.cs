using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Transacciones
{
    internal class CapaNegocios
    {
        private CapaDatos _capaDatos;

        public CapaNegocios()
        {
            _capaDatos = new CapaDatos();
        }

        public Transaccion SaveTransaccion(Transaccion transaccion)
        {
            if (transaccion.IdentificadorTransaccion == 0)
                _capaDatos.InsertTransaccion(transaccion);
            else
                _capaDatos.UpdateTransaccion(transaccion);

            return transaccion;
        }

        public List<Transaccion> GetTransacciones(string searchText = null)
        {
            return _capaDatos.GetTransacciones(searchText);
        }

        public void DeleteTransaccion(int identificadorTransaccion)
        {
            _capaDatos.DeleteTransaccion(identificadorTransaccion);
        }
    }
}
