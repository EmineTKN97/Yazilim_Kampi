using Business.Abstracts;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
   public class CourseManager:ICourseService
    {

        ICourseDal _courseDal;
  

        public CourseManager(ICourseDal courseDal, ICategoryService categoryService,
            IInstructorService instructorService)
        {
            _courseDal = courseDal;
          
        }


        public IDataResult<List<Course>> GetAll()
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll());
        }

        public IDataResult<List<Course>> GetById(int id)
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(c => c.Id == id));
        }

        public IResult Add(Course course)
        {
            _courseDal.Add(course);
            return new SuccessResult("Kurs başarı ile eklendi");
        }

        public IResult Update(Course course)
        {
            _courseDal.Update(course);
            return new SuccessResult("Kurs Başarı ile güncellendi");
        }

        public IResult Delete(Course course)
        {
            _courseDal.Delete(course);
            return new SuccessResult("Kurs Başarı ile silindi");
        }

    }
}
