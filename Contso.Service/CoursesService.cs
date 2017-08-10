using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contso.Data;
using Contso.Model;

namespace Contso.Service
{
    public class CoursesService
    {
        IRepository<Courses> CoursesRepository;
        public CoursesService()
        {
            CoursesRepository = new CourseRepository();
        }
        public void Insert(Courses obj)
        {
            CoursesRepository.Insert(obj);
        }
        public void Update(Courses obj)
        {
            CoursesRepository.Update(obj);
        }
        public IEnumerable<Courses> GetAll()
        {
            return CoursesRepository.GetAll();
        }
        public Courses GetById(int id)
        {
            return CoursesRepository.GetBy(id);
        }
        public void DeleteAll()
        {
            CoursesRepository.DeleteAll();
        }
        public void DeleteById(int id)
        {
            CoursesRepository.DeleteBy(CoursesRepository.GetBy(id));
        }

    }
}
