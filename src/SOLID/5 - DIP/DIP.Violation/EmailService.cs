﻿using System.Net.Mail;

namespace SOLID.DIP.Violation
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
