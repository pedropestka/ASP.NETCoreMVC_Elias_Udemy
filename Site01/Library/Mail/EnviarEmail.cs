using Site01.Models;
using System.Net;
using System.Net.Mail;

namespace Site01.Library.Mail
{
    public class EnviarEmail
    {
        public static void EnviarMensagemContato(Contato contato)
        {
            string conteudo = string.Format("Nome: {0}<br /> E-mail: {1}<br /> Assunto: {2}<br /> Mensagem: {3}<br />",
                contato.Nome, contato.Email, contato.Assunto, contato.Mensagem);

            // Configurar servidor SMTP
            SmtpClient smtp = new SmtpClient(Constants.ServidorSMTP, Constants.PortaSMTP);
            smtp.EnableSsl = true; // habilitar o ssl
            smtp.UseDefaultCredentials = false; // nao usar o mode de credencial padrao
            smtp.Credentials = new NetworkCredential(Constants.Usuario, Constants.Senha);

            // Mensagem de email
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("pedropestka@gmail.com");
            mensagem.To.Add("pedropestka@gmail.com");
            mensagem.Subject = "Formulario de contato";

            mensagem.IsBodyHtml = true; // para usar html na pagina
            mensagem.Body = "<h1>Formulário de contato</h1>" + conteudo;

            smtp.Send(mensagem);

        }


    }
}
