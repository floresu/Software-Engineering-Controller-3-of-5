using AXT.SQLDBDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXT.PublicSiteController
{
    public class TheWebServiceController : _BaseController
    {
        // Constructor 
        public TheWebServiceController(string connectionString) : base(connectionString) { }

        public int InsertNewPropertyModel()
        {

            NewPropertyJobInsertDataAccess newProp = new NewPropertyJobInsertDataAccess(SqlConConnectionString);
            return newProp.InsertNewPropertyModel();
        }
    }
}
