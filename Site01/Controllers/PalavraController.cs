using Microsoft.AspNetCore.Mvc;
using Site01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Controllers
{
    public class PalavraController : Controller
    {
        
        // Listar todas as palavras do banco de dados
        public IActionResult Index()
        {
            return View();
        }


        //CRUD - Create, Retrieve, Update and Delete (cadastrar, consultar, atualizar e excluir)
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar([FromForm] Palavra palavra)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Atualizar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Atualizar([FromForm] Palavra palavra)
        {
            return View();
        }

        
        // Palavra/Excluir/Id
        //{Controller}/{Action}/{Id?}
        [HttpGet]
        public IActionResult Excluir (int Id)
        {
            return RedirectToAction("Index");
        }

    }
}
