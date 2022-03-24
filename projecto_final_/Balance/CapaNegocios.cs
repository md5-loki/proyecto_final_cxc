using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Balances
{
    internal class CapaNegocios
    {
        private CapaDatos _capaDatos;

        public CapaNegocios()
        {
            _capaDatos = new CapaDatos();
        
        }

        public Balance SaveBalance(Balance balance)
        {
            if (balance.IdentificadorCliente == 0)
                _capaDatos.InsertBalance(balance);
            else
                _capaDatos.UpdateBalance(balance);
            
            return balance;

        }

        public List<Balance> GetBalances(string searchText = null)
        {
           return _capaDatos.GetBalances(searchText);
        }

        public void DeleteBalance(int identificadorCliente)
        {
            _capaDatos.DeleteBalance(identificadorCliente);
        }
    }
}
