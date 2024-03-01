using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
   public interface IApplicantService
    {
        public void ApplyForMask(Person person);
        public List<Person> GetList();
        public bool CheckPerson(Person person);
    }
}
