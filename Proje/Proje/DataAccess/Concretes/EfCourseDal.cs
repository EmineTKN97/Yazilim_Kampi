using Proje.DataAccess.Abstract;
using Proje.Entities;

namespace Proje.DataAccess.Concretes
{
    public class EfCourseDal:ICourseDal
    {
        List<Course> courses;
        public EfCourseDal()
        {
            Course course1 = new Course();
            course1.ID = 1;
            course1.Name = "JavaScript";
            course1.Description = ".NET 8 vs...";
            course1.Price = 0;

            Course course2 = new Course();
            course2.ID = 2;
            course2.Name = "JAVA";
            course2.Description = "Java 17 ....";
            course2.Price = 10;

            Course course3 = new Course();
            course3.ID = 3;
            course3.Name = "Python";
            course3.Description = "Python 3.12...";
            course3.Price = 20;

            courses = new List<Course> { course1, course2, course3 };
        }
        public List<Course> GetAll()
        {
            //sql öğren :)
            //burada db işlemleri yapılır

            return courses;
        }

        public void Add(Course course)
        {
            courses.Add(course);
        }
    }
}