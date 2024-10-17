using BL.DTO;
using BL.DTO.Bancos;
using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ClaseBL
{
    public class TB_BANCOS_BL
    {
        public List<TB_BANCOS_LIST> getAll()
        {
            List<TB_BANCOS_LIST> model;

            using (DB_FLUJOCAJAEntities db = new DB_FLUJOCAJAEntities())
            {
                model = (from d in db.TB_BANCOS
                         select new TB_BANCOS_LIST
                         {
                             id_banco = d.ID_BANCO,
                             nombre = d.NOMBRE,
                             descripcion = d.DESCRIPCION
                         }).ToList();
            }

            return model;
        }
    }
}
