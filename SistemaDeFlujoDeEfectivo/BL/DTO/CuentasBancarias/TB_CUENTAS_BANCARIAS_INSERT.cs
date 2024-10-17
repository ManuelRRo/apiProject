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
        public Decimal id_tipo_cuenta { get; set; }
        [Required]
        public TB_BANCOS banco { get; set; }
        [Required]
        public TB_TIPOS_CUENTAS cuenta { get; set; }
        [Required]
        public double? saldo { get; set; }
    }
}
