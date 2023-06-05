using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppProjetoB2023.Models;
using System.Data.Entity;
using System.Net;

namespace WebAppProjetoB2023.Controllers
{
    public class ProdutoController : Controller
    {
          
            EFContext context = new EFContext();
            public ActionResult Index()
            {
                var produtos = context.Produtos.Include(c => c.Categoria).Include(f => f.Fabricante).OrderBy(n => n.Nome);
                //return View(context.Produtos.OrderBy(p => p.Nome));
                return View(produtos);
            }
            
    }
}