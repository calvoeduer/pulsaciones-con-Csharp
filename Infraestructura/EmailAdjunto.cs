using System;
using System.Net.Mail;

namespace Infraestructura
{
    public class EmailAdjunto
    {
        private MailMessage email;
        private SmtpClient smtp;
        public EmailAdjunto()
        {
            smtp = new SmtpClient();
        }
        private void ConfigurarSmt()
        {
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("tucorreo@gmail.com", "pasword");
        }
        private void ConfigurarEmail()
        {
            email = new MailMessage();
            email.To.Add(new MailAddress("calvoeduer@gmail.com"));
            email.From = new MailAddress("tucorreo@gmail.com");
            email.Subject = "your name - Tablas";
            email.Body = $"<b> Señor </b> <br " +
            $" > informe de registro " + DateTime.Now.ToString("dd/MMM/yyy hh:mm:ss");
            email.IsBodyHtml = true;
            email.Priority = MailPriority.High;

            // email.atachmen.Add(new atachmen("nombre pdf.pdf"));
            email.Attachments.Add(new Attachment("PDFTABLAS.pdf")); // nombre del pdf
        }


        public string EnviarEmail()

        {
            try
            {
                ConfigurarSmt();
                ConfigurarEmail();
                smtp.Send(email);
                return ("Correo enviado Satifactoriamente");
            }
            catch (Exception e)
            {
                return ("error al enviar correo" + e.Message);
            }
            finally
            {
                email.Dispose();
            }
        }


    }
}
