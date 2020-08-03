using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace SOLID.SRP.Solution
{
    public class EmailService
    {
        public static void Send(string from, string to, string topic, string message)
        {
            var mail = new MailMessage(from, to);
            var clientMail = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = topic;
            mail.Body = message;
            clientMail.Send(mail);
        }
    }
}
