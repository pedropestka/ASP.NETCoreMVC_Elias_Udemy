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
            string conteudo = string.Format("Nome: {0}, E-mail: {1}, Assunto: {2}, Mensagem: {3}",
                contato.Nome, contato.Email, contato.Assunto, contato.Mensagem);

            return new ContentResult() { Content = conteudo };
        }

















        /*
            
        OBTER DADOS MANUALMENTE

        public IActionResult ReceberContato()
        {
           
            // POST - Request.Form - quanto é enviado pelo corpo da pagina
            // GET - Request.QueryString - quando é enviado pelo endereço da pagina

            Contato contato = new Contato();

            contato.Nome = Request.Form["nome"];
            contato.Email = Request.Form["email"];
            contato.Assunto = Request.Form["assunto"];
            contato.Mensagem = Request.Form["mensagem"];

            string conteudo = string.Format("Nome: {0}, E-mail: {1}, Assunto: {2}, Mensagem: {3}", 
                contato.Nome, contato.Email, contato.Assunto, contato.Mensagem);

            return new ContentResult() { Content =  conteudo};
            
        }
        */
    }
}
