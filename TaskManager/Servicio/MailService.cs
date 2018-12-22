using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class MailService
    {
        MailMessage mail = new MailMessage();
        SmtpClient servidor = new SmtpClient();

        public bool sendMail(String mailTo, String subject, String body)
        {
            try
            {
                SmtpClient servidor = new SmtpClient();
                servidor.Credentials = new System.Net.NetworkCredential("programacionfrgputn@outlook.com", "Programacion123");
                servidor.EnableSsl = true;
                servidor.Port = 587;
                servidor.Host = "smtp.live.com";
                mail = new MailMessage();
                mail.From = new MailAddress("programacionfrgputn@outlook.com");
                mail.To.Add(mailTo);
                mail.Subject = subject;
                mail.IsBodyHtml = true;
                mail.Body = "<h1>"+body+"</h1>";
                servidor.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                servidor.Dispose();
                mail.Dispose();
            }
  
      
        }
        
        
    }
}
