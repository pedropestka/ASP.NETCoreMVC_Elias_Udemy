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
            ViewBag.Palavras = _db.Palavras.ToList();
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
            return View("Cadastrar");
        }

        [HttpPost]
        public IActionResult Atualizar([FromForm] Palavra palavra)
        {
            return View("Cadastrar");
        }

        // Palavra/Excluir/Id
        //{Controller}/{Action}/{Id?}
        // não precisa de uma view - basta  acrescentar o 'to do' para excluir o registro no banco
        [HttpGet]
        public IActionResult Excluir(int Id)
        {
            return RedirectToAction("Index");
        }
    }
}
