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
        DB_FLUJOCAJAEntities db = new DB_FLUJOCAJAEntities();
        public List<TB_CUENTAS_BANCARIAS_DTO> getAll()
        {
            List<TB_CUENTAS_BANCARIAS_DTO> model;

            using (DB_FLUJOCAJAEntities db = new DB_FLUJOCAJAEntities())
            {
                model = (from d in db.TB_CUENTAS_BANCARIAS
                         select new TB_CUENTAS_BANCARIAS_DTO
                         {
                             id_cuenta_bancaria = d.ID_CUENTA_BANCARIA,
                             id_tipo_cuenta = d.ID_TIPO_CUENTA,
                             numero_cuenta = d.NUMERO_CUENTA,
                             banco = d.TB_BANCOS,
                             cuenta = d.TB_TIPOS_CUENTAS,
                             saldo = d.SALDO
                         }).ToList();
            }

            return model;
        }

        public void insert(TB_CUENTAS_BANCARIAS_INSERT cuentaBancaria)
        {
            db.SP_TB_CUENTAS_BANCARIAS_INSERT(cuentaBancaria.id_tipo_cuenta, cuentaBancaria.id_banco, cuentaBancaria.saldo);
        }

        public TB_CUENTAS_BANCARIAS_INSERT getById(int ?id)
        {
            using (DB_FLUJOCAJAEntities db = new DB_FLUJOCAJAEntities())
            {
                var model = (from d in db.TB_CUENTAS_BANCARIAS
                             where d.ID_CUENTA_BANCARIA == id
                             select new TB_CUENTAS_BANCARIAS_INSERT
                             {
                                 id_cuenta_bancaria = d.ID_CUENTA_BANCARIA,
                                 id_tipo_cuenta = d.ID_TIPO_CUENTA,
                                 numeroCuenta = d.NUMERO_CUENTA,
                                 id_banco = d.ID_BANCO,
                                 saldo = d.SALDO
                             }).FirstOrDefault(); // Usamos FirstOrDefault para obtener un solo elemento o null si no existe

                return model; // Retornamos el modelo
            }
        }

        public void update(TB_CUENTAS_BANCARIAS_INSERT cb)
        {
            int result = db.SP_TB_CUENTAS_BANCARIAS_UPDATE(cb.id_cuenta_bancaria, cb.numeroCuenta, cb.id_tipo_cuenta, cb.id_banco, cb.saldo);
        }

        public void delete(int id)
        {
            var entity = db.TB_CUENTAS_BANCARIAS.SingleOrDefault(x => x.ID_CUENTA_BANCARIA == id);
            db.TB_CUENTAS_BANCARIAS.Remove(entity);
            db.SaveChanges();
        }

    }
}
