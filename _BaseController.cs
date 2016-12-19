using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXT.PublicSiteController
{
    public abstract class _BaseController
    {
        // Constructor
        public _BaseController(string connectionString) { SqlConConnectionString = connectionString; }

        protected string SqlConConnectionString { get; set; }
    }
}
