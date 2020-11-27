using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult GetAll()
        {

            return View();
        }
        public ActionResult Pruebas()
        {
            return View();
        }
    }
}