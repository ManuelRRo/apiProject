using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTO
{
    public class TB_CUENTAS_BANCARIAS_DTO
    {
        public Decimal id_tipo_cuenta {  get; set; }
        public TB_BANCOS banco { get; set; }
        public TB_TIPOS_CUENTAS cuenta { get; set; }
        public double? saldo { get; set; }
    }
}
