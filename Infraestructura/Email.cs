using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Entity;

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
            smtp.Credentials = new System.Net.NetworkCredential("yesithm72@gmail.com", "2305f3e6");
        }
        private void ConfigurarEmail(Pendulo pendulo)
        {
            
            email = new MailMessage();
            email.To.Add(pendulo.Email);
            email.From = new MailAddress("yesithm72@gmail.com");
            email.Subject = "Orlando Rojano Calcular Frecuencia y Gravedad"
            + DateTime.Now.ToString("dd/MMM/yyy hh:mm:ss");
            email.Body = $"<b> </b> <br " +
            $" > Se ha calculado satisfactoriamente ";
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;
        }
        public string EnviarEmail(Pendulo pendulo)
        {
            try

            {

                ConfigurarSmt();

                ConfigurarEmail(pendulo);

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
