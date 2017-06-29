using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Heroko.Controllers
{
    public class CalculadoraController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
    }
}