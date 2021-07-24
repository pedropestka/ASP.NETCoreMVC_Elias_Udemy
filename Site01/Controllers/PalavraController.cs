using Microsoft.AspNetCore.Mvc;
using Site01.Database;
using Site01.Models;
using System.Linq;

namespace Site01.Controllers
{
    public class PalavraController : Controller
    {
        private DatabaseContext _db;
        public PalavraController(DatabaseContext db)
        {
            _db = db;
        }

        // Listar todas as palavras do banco de dados
        public IActionResult Index()
        {
            var palavras = _db.Palavras.ToList();
            return View(palavras);
        }

        //CRUD - Create, Retrieve, Update and Delete (cadastrar, consultar, atualizar e excluir)
        //•	GET: Método genérico para qualquer requisição que busca dados do servidor;
        //•	POST: Método genérico para qualquer requisição que envia dados ao servidor;
        //•	PUT: Método específico para atualização de dados no servidor;
        //•	DELETE: Método específico para remoção de dados no servidor


        [HttpGet] // Visualizar o formulario
        public IActionResult Cadastrar()
        {
            return View(new Palavra());
        }

        [HttpPost] // Cadastrar a palavra
        public IActionResult Cadastrar([FromForm] Palavra palavra)
        {
            if (ModelState.IsValid)
            {
                _db.Palavras.Add(palavra); // passo a palavra que veio do fromulario
                _db.SaveChanges();

                return RedirectToAction("Index"); // para ver o registro sendo consultado
            }

            return View();
        }

        [HttpGet]
        public IActionResult Atualizar(int Id)
        {
            Palavra palavra = _db.Palavras.Find(Id);
            
            return View("Cadastrar", palavra);
        }

        [HttpPost]
        public IActionResult Atualizar([FromForm] Palavra palavra)
        {
            if (ModelState.IsValid)
            {
                _db.Palavras.Update(palavra);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            
            
            return View("Cadastrar", palavra);
        }

        // Palavra/Excluir/Id
        //{Controller}/{Action}/{Id?}
        // não precisa de uma view - basta  acrescentar o 'to do' para excluir o registro no banco
        [HttpGet]
        public IActionResult Excluir(int Id)
        {
            _db.Palavras.Remove(_db.Palavras.Find(Id));
            _db.SaveChanges();
            
            return RedirectToAction("Index"); // retorna para a listagem
        }
    }
}
