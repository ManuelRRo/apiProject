using BL.DTO;
using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ClaseBL
{
    public class TB_CUENTAS_BANCARIAS_BL
    {
        public List<TB_CUENTAS_BANCARIAS_DTO> getAll()
        {
            List<TB_CUENTAS_BANCARIAS_DTO> model;

            using (DB_FLUJOCAJAEntities db = new DB_FLUJOCAJAEntities())
            {
                model = (from d in db.TB_CUENTAS_BANCARIAS
                         select new TB_CUENTAS_BANCARIAS_DTO
                         {
                             id_tipo_cuenta = d.ID_TIPO_CUENTA,
                             banco = d.TB_BANCOS,
                             cuenta = d.TB_TIPOS_CUENTAS,
                             saldo = d.SALDO
                         }).ToList();
            }

            return model;
        }
    }
}
