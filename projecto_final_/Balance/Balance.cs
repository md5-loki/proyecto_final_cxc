using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Balances
{
    public class Balance
    {
        public int Identificador { get; set; }
        public String IdentificadorCliente { get; set; }
        public DateTime FechaCorte { get; set; }
        public string AntigüedadPromedioSaldos { get; set; }
        public string Monto { get; set; }

    }
}
