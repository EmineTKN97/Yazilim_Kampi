using Core.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Category:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Collection<Course> Courses { get; set; }
    }
}
