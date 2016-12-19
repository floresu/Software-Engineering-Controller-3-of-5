using AXT.Model;
using BenobeDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXT.PublicSiteController
{
    public class CareerListController : _BaseController
    { 
        // Constructor 
        public CareerListController(string connectionString) : base(connectionString) { }

        public List<CareerModel> GetCareers(string url, string accessKey, string searchText)
        {
            CareerDataAccess cad = new CareerDataAccess("http://www.benobe.com/iapi/find", "5ff8278e-fad8-459f-b1ad-13034d0aff67");
            return cad.GetCareers(searchText);

        }
    }
}
 