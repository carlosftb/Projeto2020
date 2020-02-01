using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projeto2020.Models;

namespace Projeto2020.Controllers
{
    public class CategoriasController : Controller
    {
        public IActionResult Index()
        {
            List<Categoria> list = new List<Categoria>();
            list.Add(new Categoria { Id = 1, Nome = "Insumos" });
            list.Add(new Categoria { Id = 2, Nome = "Farinaceis" });

            return View(list);
        }
    }
}