using System.Net;
using System.Net.Mail;

namespace SendMail.Logic.Implementation
{
    public static class SendService
    {
        /// <summary>
        /// Method Sending Mail
        /// </summary>
        /// <param name="origin">Email address from where it will be sent.</param>
        /// <param name="password">Email password from where it was sent.</param>
        /// <param name="destiny">Destination email address.</param>
        /// <param name="subject">Subject of the email.</param>
        /// <param name="body">Contents of the email.</param>
        /// <returns>True if sent</returns>
        public static bool Send(string origin, string password, string destiny, string subject, string body)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;

                client.Credentials = new NetworkCredential(origin, password);

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(origin);
                mail.To.Add(destiny);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;

                client.Send(mail);

                return true;
            }
            catch
            {
                throw;
            }
        }
    }
}
