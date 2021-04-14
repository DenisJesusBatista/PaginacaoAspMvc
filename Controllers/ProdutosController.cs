using PaginacaoBasica.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace PaginacaoBasica.Controllers
{
    public class ProdutosController : Controller
    {
        private LojaContext db = new LojaContext();
        // GET: Produtos
        public ActionResult Index(string busca = "",int pagina = 1)
        {
            //var produtos = db.Produtos.OrderBy(p => p.Id).ToPagedList(pagina, 10);
            var produtos = db.Produtos.Where(p => p.Nome.Contains(busca))
                                      .OrderBy(p => p.Id)
                                      .ToPagedList(pagina, 10);

            ViewBag.Busca = busca;

            return View(produtos);
        }
    }
}
