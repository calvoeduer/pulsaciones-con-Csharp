﻿using Entity;
using System;
using System.Net.Mail;




namespace Infraestructura
{
    public class Email
    {
        private MailMessage email;
        private SmtpClient smtp;
        public Email()
        {
            smtp = new SmtpClient();
        }
        private void ConfigurarSmt()
        {
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("tucorreo@gmail.com", "contraseña");
        }
        private void ConfigurarEmail(Persona persona)
        {
            email = new MailMessage();
            email.To.Add(new MailAddress("calvoeduer@gmail.com")); //enviar mail a
            email.From = new MailAddress("tucorreo@gmail.com"); // desde
            email.Subject = "your name " + DateTime.Now.ToString("dd/MMM/yyy hh:mm:ss");
            email.Body = $"<b>Sr {persona.Nombre }</b> <br " +
            $" > se ha realizado su registro Sartisfactoriamente";
            email.IsBodyHtml = true;
            email.Priority = MailPriority.High;

           // email.atachmen.Add(new atachmen("nombre pdf.pdf"));
          
        }


        public string EnviarEmail(Persona persona)

        {
            try
            {
                ConfigurarSmt();
                ConfigurarEmail(persona);
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
