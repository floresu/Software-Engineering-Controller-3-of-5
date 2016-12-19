using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXT.PublicSiteController
{
    public class UserListController : _BaseController
    {
        public UserListController(string connectionString) : base(connectionString) { }

       
        public object GetUsers()
        {
            return null;
        }
        
    }
}
