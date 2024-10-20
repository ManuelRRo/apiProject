using DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTO
{
    public class TB_CUENTAS_BANCARIAS_INSERT
    {
        public decimal id_cuenta_bancaria { get; set; }
        [Required]
        public decimal id_tipo_cuenta { get; set; }
        [Required]
        public decimal id_banco {  get; set; }
        [Required]
        public double? saldo { get; set; }

        [Required]
        public string numeroCuenta { get; set; }
    }
}
