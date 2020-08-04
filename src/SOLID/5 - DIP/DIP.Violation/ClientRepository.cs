using System.Data;
using System.Data.SqlClient;

namespace SOLID.DIP.Violation
{
    public class ClientRepository
    {
        public void  AddClient(Client client)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "myconnectionstring";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into Client(name, email...";

                cmd.Parameters.AddWithValue("name", client.Name);
                cmd.Parameters.AddWithValue("email", client.Email.EmailAddress);
                cmd.Parameters.AddWithValue("cpf", client.CPF.Number);
                cmd.Parameters.AddWithValue("registerdate", client.RegisterDate);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
