using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Text;

namespace SOLID.SRP.Violation
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime RegisterDate { get; set; }

        public string AddClient()
        {
            if (!Email.Contains("@"))
                return "invalid email";

            if (CPF.Length != 11)
                return "invalid CPF";

            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "myconnectionstring";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into Client(name, email...";

                cmd.Parameters.AddWithValue("name", Name);
                cmd.Parameters.AddWithValue("email", Name);
                cmd.Parameters.AddWithValue("cpf", Name);
                cmd.Parameters.AddWithValue("registerdate", Name);

                cn.Open();
                cmd.ExecuteNonQuery();
            }

            var mail = new MailMessage("company@company.com", Email);
            var clientMail = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = "Welcome.";
            mail.Body = "Congrats! You are registered.";
            clientMail.Send(mail);

            return "successfully registered client";
        }
    }
}
