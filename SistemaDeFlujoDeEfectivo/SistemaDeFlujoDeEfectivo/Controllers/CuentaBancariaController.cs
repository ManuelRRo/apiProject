using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BL.ClaseBL;
using BL.DTO;
using BL.DTO.CuentasBancarias;
namespace SistemaDeFlujoDeEfectivo.Controllers
{
    public class CuentaBancariaController : Controller
    {
        TB_CUENTAS_BANCARIAS_BL db = new TB_CUENTAS_BANCARIAS_BL();

        TB_BANCOS_BL dbBancos = new TB_BANCOS_BL();

        TB_TIPOS_CUENTAS_BL dbTipoCuentas = new TB_TIPOS_CUENTAS_BL();

        // GET: CuentaBancaria
        public ActionResult Index(int? id)
        {
            List<TB_CUENTAS_BANCARIAS_DTO> listaCuentasBancarias = db.getAll();

            CuentasBancariasView model = new CuentasBancariasView();

            model.CuentasBancarias = listaCuentasBancarias;

            model.cuentaBancaria = new TB_CUENTAS_BANCARIAS_INSERT();

            ViewBag.Bancos = new SelectList(dbBancos.getAll(), "id_banco", "nombre");
            
            ViewBag.TipoCuentas = new SelectList(dbTipoCuentas.getAll(), "id_tipo_cuenta", "nombre");

            if (id != null)
            {
                TB_CUENTAS_BANCARIAS_INSERT d = db.getById(id);
                model.cuentaBancaria.id_cuenta_bancaria = Convert.ToInt32(id);
                model.cuentaBancaria.id_tipo_cuenta = d.id_tipo_cuenta;
                model.cuentaBancaria.id_banco = d.id_banco;
                model.cuentaBancaria.numeroCuenta = d.numeroCuenta; 
                model.cuentaBancaria.saldo = d.saldo;
            }


                return View(model);
        }
        [HttpPost]
        public ActionResult Index(FormCollection formColletion,CuentasBancariasView c)
        {
            var cc = c;
            //Cargar Listas para el combo Box
            ViewBag.Bancos = new SelectList(dbBancos.getAll(), "id_banco", "nombre");
            ViewBag.TipoCuentas = new SelectList(dbTipoCuentas.getAll(), "id_tipo_cuenta", "nombre");
            
            //Inicializar modelo y inicializar la clase TB_CUENTAS_BANCARIAS_INSERT
            CuentasBancariasView model = new CuentasBancariasView();
            model.cuentaBancaria = new TB_CUENTAS_BANCARIAS_INSERT();

            //mapear lo del post al objeto
            // model.cuentaBancaria.id_cuenta_bancaria = Convert.ToDecimal(formColletion["cuentaBancaria.id_cuenta_bancaria"]);
            int op = Convert.ToInt32(formColletion["cuentaBancaria.id_cuenta_bancaria"]);
            model.cuentaBancaria.id_tipo_cuenta = Convert.ToDecimal(formColletion["TipoCuentas"]);
            model.cuentaBancaria.id_banco = Convert.ToDecimal(formColletion["Bancos"]);
            model.cuentaBancaria.saldo = Convert.ToDouble(formColletion["cuentaBancaria.saldo"]);
            if (op == 0)
            {
                db.insert(c.cuentaBancaria);
            }
            else
            {
                db.update(c.cuentaBancaria);
            }
            return Redirect("/CuentaBancaria/Index");
        }

        [HttpGet]
        public ActionResult Eliminar(int id)
        {
            db.delete(id);
            return Redirect("/CuentaBancaria/Index");
        }
    }
}