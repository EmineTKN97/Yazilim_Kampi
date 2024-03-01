using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Entities
{
    public class IndividualCustomer:BaseCustomer
    {
       
        public  string FirstName { get; set; }
        public  string LastName { get; set; }
        public string NationalIdentity { get; set; }
    }
}
