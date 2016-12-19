using AXT.SQLDBDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXT.PublicSiteController
{
    public class LoginController : _BaseController
    {
        public LoginController(string connectionString) : base(connectionString) { }


        /*
        public bool LoginUser(string email, string password)
       {
          return false;
       }
       */

        public int GetUserIDFromLogin(string password, string email)
        {
            UserDataAccess userID = new UserDataAccess(SqlConConnectionString);
            return userID.GetUserIDFromLogin(password, email);

        }


    }
}
