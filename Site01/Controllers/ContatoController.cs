using Microsoft.AspNetCore.Mvc;
using Site01.Models;

namespace Site01.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ReceberContato([FromForm] Contato contato)
        {
            if (ModelState.IsValid)
            {
                string conteudo = string.Format("Nome: {0}, E-mail: {1}, Assunto: {2}, Mensagem: {3}",
                contato.Nome, contato.Email, contato.Assunto, contato.Mensagem);
                return new ContentResult() { Content = conteudo };
            }
            else
            {
                return View("Index");
            }    
        }
    }
}
