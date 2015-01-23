using System.Net;
using System.Net.Mail;
using System.Configuration;

namespace SeLigaNoBlog
{
    public class Gmail: IServicoWeb
    {
        public Smtp Smtp { get; set; }

        public const string HOST = "smtp.gmail.com";

        public const int PORT = 587;


        public Gmail(Smtp smtp)
        {
            this.Smtp = smtp;
        }

        public void Enviar(Mensagem email)
        {
            //envio de email
            var mail = email.ObterMailMessage();
            var smtpClient = this.ObterSmtpClient();

            mail.From = new MailAddress(this.Smtp.Login, this.Smtp.Nome);//quem manda

            smtpClient.Send(mail);//envia o email
        }

        public SmtpClient ObterSmtpClient()
        {
            return new SmtpClient(HOST, PORT)
            {
                Credentials = new NetworkCredential(this.Smtp.Login, this.Smtp.Senha),
                EnableSsl = true,
                UseDefaultCredentials = false,
                DeliveryMethod = SmtpDeliveryMethod.Network
            };
        }

        
    }
}
