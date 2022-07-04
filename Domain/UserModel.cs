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
        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user, pass);
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
