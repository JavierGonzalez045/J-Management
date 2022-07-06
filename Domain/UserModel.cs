using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence;
using Common.Cache;

namespace Domain
{
    public class UserModel
    {
        UserDao userDao = new UserDao();

        // Atributos
        private int idUser;
        private string loginName;
        private string password;
        private string firstName;
        private string lastName;
        private string position;
        private string email;

        //Constructors
        public UserModel(int idUser, string loginName, string password, string firstName, string lastName, string position, string email)
        {
            this.idUser = idUser;
            this.loginName = loginName;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;
            this.email = email;
        }

        public UserModel()
        {
        }
        //Methods
        public string editUserProfile()
        {
            try
            {
                userDao.editProfile(idUser, loginName, password, firstName, lastName, email);
                LoginUser(loginName, password);
                return "Su perfil fue actualizado exitosamente.";
            }
            catch (Exception ex)
            {
                return "El nombre de usuario ya existe, intente con otro.";
            }
        }

        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user, pass);
        }

        public string recoverPassword(string userRequesting)
        {
            return userDao.recoverPassword(userRequesting);
        }

        public void anyMethod()
        {
            // SEGURIDAD Y PERMISOS

            if (UserCache.Position == Positions.Administrator)
            {

            }
            if (UserCache.Position == Positions.Receptionist || UserCache.Position == Positions.Accounting)
            {

            }
        }
    }
}
