using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Dominio
{
    public static class Mail
    {
        public static bool validarEmail(string emailDirection)
        {
            try
            {
                new MailAddress(emailDirection);
                return true;
            } catch (FormatException)
            {
                return false;
            }
        }
      
    }
}
