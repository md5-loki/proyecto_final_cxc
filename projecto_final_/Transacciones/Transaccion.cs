using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Transacciones
{
    public class Transaccion
    {
        public int IdentificadorTransaccion { get; set; }
        public string TipoMovimiento { get; set; }
        public string IdentificadorTipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime Fecha { get; set; }
        public string IdentificadorCliente { get; set; }
        public string Monto { get; set; }
    }
}
