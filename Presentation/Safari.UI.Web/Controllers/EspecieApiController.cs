using Safari.UI.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Safari.UI.Web.Controllers
{
    public class EspecieApiController : Controller
    {
        // GET: EspecieApi
        public ActionResult Index()
        {
            var eap = new EspecieApiProcess();
            var lista = eap.ToList();
            return View(lista);
        }
    }
}