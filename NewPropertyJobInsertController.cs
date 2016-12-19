using AXT.Model;
using AXT.SQLDBDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXT.PublicSiteController
{
    public class NewPropertyJobInsertController : _BaseController
    {
        // Constructor
        public NewPropertyJobInsertController(string connectionString) : base(connectionString) { }

        public void InsertNewPropertyJobInsert(NewPropertyJobInsertModel newNewPropertyJobInsert)
        {
            // Calls the NewPropertyJobInsertDataAccess 'InsertNewPropertyJobInsert' function.
            NewPropertyJobInsertDataAccess da = new NewPropertyJobInsertDataAccess(SqlConConnectionString);

            da.InsertNewPropertyJobInsert(newNewPropertyJobInsert);
        }
    }
}
