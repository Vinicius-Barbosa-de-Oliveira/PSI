using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppProjetoB2023.Models;
using System.Net; // pro " new HttpStatusCodeResult(HttpStatusCode.BadRequest) " funcionar
using System.Data.Entity;

namespace WebAppProjetoB2023.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private EFContext context = new EFContext();
      
        public ActionResult Index()
        {
            Home home = new Home();

            home.Categoria = context.Categorias.OrderBy(o =>o.Nome);
            home.Fabricante = context.Fabricantes.OrderBy(o =>o.nome);

            return View(home);
        }
    }
}