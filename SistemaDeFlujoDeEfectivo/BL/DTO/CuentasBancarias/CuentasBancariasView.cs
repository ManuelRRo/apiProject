using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTO.CuentasBancarias
{
    public class CuentasBancariasView
    {
        public List<TB_CUENTAS_BANCARIAS_DTO> CuentasBancarias {  get; set; }
        public TB_CUENTAS_BANCARIAS_INSERT cuentaBancaria { get; set; }
    }
}
