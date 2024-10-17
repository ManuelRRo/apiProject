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
        // GET: CuentaBancaria
        public ActionResult Index()
        {
            TB_CUENTAS_BANCARIAS_BL db = new TB_CUENTAS_BANCARIAS_BL();

            TB_BANCOS_BL dbBancos = new TB_BANCOS_BL();

            List<TB_CUENTAS_BANCARIAS_DTO> listaCuentasBancarias = db.getAll();

            CuentasBancariasView model = new CuentasBancariasView();

            model.CuentasBancarias = listaCuentasBancarias;

            model.cuentaBancaria = new TB_CUENTAS_BANCARIAS_INSERT();

            ViewBag.Bancos = new SelectList(dbBancos.getAll(),"id_banco", "nombre");

            return View(model);
        }
    }
}