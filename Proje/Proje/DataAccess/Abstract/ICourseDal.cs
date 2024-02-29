using Proje.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje.DataAccess.Abstract
{
   public  interface ICourseDal
    {
        List<Course> GetAll();
        void Add(Course course);
    }
}
