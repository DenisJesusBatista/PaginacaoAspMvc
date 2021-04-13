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
        public ActionResult Index(int pagina = 1)
        {
            var produtos = db.Produtos.OrderBy(p => p.Id).ToPagedList(pagina, 10);
            return View(produtos);
        }
    }
}
