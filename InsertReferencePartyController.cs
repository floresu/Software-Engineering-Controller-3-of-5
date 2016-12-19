using AXT.Model;
using AXT.SQLDBDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXT.PublicSiteController
{
    public class InsertReferencePartyController : _BaseController
    {
        // Constructor 
        public InsertReferencePartyController(string connectionString) : base(connectionString) { }

        // Method to insert 'InsertReferenceParty'
        public void InsertInsertReferenceParty(InsertReferencePartyModel newInsertReferenceParty)
        {
            // Calls the InsertReferencePartyDataAccess 'InsertInsertReferenceParty' function.
            InsertReferencePartyDataAccess da = new InsertReferencePartyDataAccess(SqlConConnectionString);

            da.InsertInsertReferenceParty(newInsertReferenceParty);
        }


    }
}
