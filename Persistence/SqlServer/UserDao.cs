using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Common.Cache;

namespace Persistence
{
    public class UserDao : ConnectionToSql
    {

        public void editProfile(int id, string userName, string password, string name, string lastName, string mail)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Users SET" + 
                        "LoginName=@userName, Password=@pass, FirstName=@name, LastName=@lastName, Email=@mail WHERE UserID=@id";
                    command.Parameters.AddWithValue("@userName", userName);
                    command.Parameters.AddWithValue("@pass", password);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@mail", mail);
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }

        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Users WHERE LoginName=@user and Password=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserCache.idUser = reader.GetInt32(0);
                            UserCache.LoginName = reader.GetString(1);
                            UserCache.Password = reader.GetString(2);
                            UserCache.FirsName = reader.GetString(3);
                            UserCache.LastName = reader.GetString(4);
                            UserCache.Position = reader.GetString(5);
                            UserCache.Email = reader.GetString(6);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        //
        public string recoverPassword(string userRequesting)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Users WHERE LoginName=@user or Email=@mail";
                    command.Parameters.AddWithValue("@user", userRequesting);
                    command.Parameters.AddWithValue("@mail", userRequesting);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        string userName = $"{reader.GetString(3)} {reader.GetString(4)}";
                        string userEmail = reader.GetString(6);
                        string accountPassword = reader.GetString(2);

                        var mailService = new MailServices.SystemSupportMail();
                        mailService.sendMail(
                            subject: "Recuperacion de contraseña",
                            body: $"Hola {userName}\n"+
                            "Usted solicitó recuperar su contraseña.\n"+
                            $"Su contraseña actual es {accountPassword}"+
                            "\nLe recomendamos, una vez haya visualizado este mensaje, cambie la contraseña inmediatamente.",
                            recipientMail: new List<string> { userEmail}
                            );

                        return $"Hola {userName}\n" +
                            "Usted solicitó recuperar su contraseña.\n" +
                            $"Por favor revise su correo {userEmail}" +
                            "\nLe recomendamos, una vez haya iniciado sesión en el sistema, cambie la contraseña inmediatamente.";
                    }
                    else
                    {
                        return "Lo sentimos, no posee una cuenta vinculada a este nombre de usuario o correo electrónico.";
                    }
                }
            }
        }

        public void anyMethod()
        {
            if (UserCache.Position == Positions.Administrator)
            {
                // Code
            }
            if (UserCache.Position == Positions.Receptionist || UserCache.Position == Positions.Accounting)
            {
                // Code
            }
        }
    }
}