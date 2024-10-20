using BL.DTO.Bancos;
using BL.DTO.TipoCuentas;
using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ClaseBL
{
    public class TB_TIPOS_CUENTAS_BL
    {
        public List<TB_TIPOS_CUENTAS_LIST> getAll()
        {
            List<TB_TIPOS_CUENTAS_LIST> model;

            using (DB_FLUJOCAJAEntities db = new DB_FLUJOCAJAEntities())
            {
                model = (from d in db.TB_TIPOS_CUENTAS
                         select new TB_TIPOS_CUENTAS_LIST
                         {
                             id_tipo_cuenta = d.ID_TIPO_CUENTA,
                             nombre = d.NOMBRE,
                         }).ToList();
            }

            return model;
        }
    }
}
