using Auth.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace Auth.Services
{
    public class AuthService
    {
        public User? AuthenticateUser(string email, string password)
        {
            string query = "SELECT Id, Email, NamaLengkap, Role FROM Users WHERE Email = @Email AND Password = @Password";

            MySqlParameter[] parameters = {
                new MySqlParameter("@Email", email.Trim()),
                new MySqlParameter("@Password", password.Trim())
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new User
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Email = row["Email"].ToString() ?? "",
                    NamaLengkap = row["NamaLengkap"].ToString() ?? "",
                    Role = row["Role"].ToString() ?? ""
                };
            }

            return null;
        }
    }
}