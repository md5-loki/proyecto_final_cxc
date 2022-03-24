using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecto_final_
{
    class BusinessLogicLayer
    {
        private DataAccesLayer _dataAccesLayer;

        public BusinessLogicLayer()
        {
            _dataAccesLayer = new DataAccesLayer();
        }

        public Cliente guardarCliente(Cliente cliente)
        {
            if (cliente.id == 0)
                _dataAccesLayer.insertCliente(cliente);
            else
                _dataAccesLayer.editCliente(cliente);

            return cliente;
        }

        public List<Cliente> getClientes(string busqueda = null)
        {
            return _dataAccesLayer.getClientes(busqueda);
        }

        public void delCliente(int id)
        {
            _dataAccesLayer.delCliente(id);
        }
    }
}
