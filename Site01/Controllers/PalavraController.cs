﻿using Microsoft.AspNetCore.Mvc;
using Site01.Database;
using Site01.Library.Filters;
using Site01.Models;
using System.Collections.Generic;
using System.Linq;
using X.PagedList;

namespace Site01.Controllers
{
    [Login]
    public class PalavraController : Controller
    {
        List<Nivel> niveis = new List<Nivel>();

        private DatabaseContext _db;
        public PalavraController(DatabaseContext db)
        {
            _db = db;
            
            niveis.Add(new Nivel() { Id = 1, Nome = "Fácil" });
            niveis.Add(new Nivel() { Id = 2, Nome = "Médio" });
            niveis.Add(new Nivel() { Id = 3, Nome = "Difícil" });
        }

        // Listar todas as palavras do banco de dados
        public IActionResult Index(int? page)
        {
            var pageNumber = page ?? 1;
            
            var palavras = _db.Palavras.ToList();
            var resultadoPaginado = palavras.ToPagedList(pageNumber, 5);
            return View(resultadoPaginado);
        }

        //CRUD - Create, Retrieve, Update and Delete (cadastrar, consultar, atualizar e excluir)
        //•	GET: Método genérico para qualquer requisição que busca dados do servidor;
        //•	POST: Método genérico para qualquer requisição que envia dados ao servidor;
        //•	PUT: Método específico para atualização de dados no servidor;
        //•	DELETE: Método específico para remoção de dados no servidor


        [HttpGet] // Visualizar o formulario
        public IActionResult Cadastrar()
        {
            ViewBag.Nivel = niveis;

            return View(new Palavra());
        }

        [HttpPost] // Cadastrar a palavra
        public IActionResult Cadastrar([FromForm] Palavra palavra)
        {
            ViewBag.Nivel = niveis;

            if (ModelState.IsValid)
            {
                _db.Palavras.Add(palavra); // passo a palavra que veio do fromulario
                _db.SaveChanges();

                // TEMPDATA
                TempData["Mensagem"] = "A palavra '" + palavra.Nome + "' foi cadastrada com sucesso!";

                return RedirectToAction("Index"); // para ver o registro sendo consultado
            }

            return View();
        }

        [HttpGet]
        public IActionResult Atualizar(int Id)
        {
            ViewBag.Nivel = niveis;

            Palavra palavra = _db.Palavras.Find(Id);
            
            return View("Cadastrar", palavra);
        }

        [HttpPost]
        public IActionResult Atualizar([FromForm] Palavra palavra)
        {
            ViewBag.Nivel = niveis;

            if (ModelState.IsValid)
            {
                _db.Palavras.Update(palavra);
                _db.SaveChanges();

                // TEMPDATA
                TempData["Mensagem"] = "A palavra '" + palavra.Nome + "' foi atualizada com sucesso!";

                return RedirectToAction("Index");
            }
            
            
            return View("Cadastrar", palavra);
        }

        [HttpGet]
        public IActionResult Excluir(int Id)
        {
            Palavra palavra = _db.Palavras.Find(Id);
            _db.Palavras.Remove(palavra);
            _db.SaveChanges();

            // TEMPDATA
            TempData["Mensagem"] = "A palavra '" + palavra.Nome + "' foi excluída com sucesso!";

            return RedirectToAction("Index"); // retorna para a listagem
        }
    }
}
