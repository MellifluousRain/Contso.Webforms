using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contso.Data;
using Contso.Model;

namespace Contso.Service
{
    public class DepartmentService
    {
        IRepository<Department> departmentRepository;
        public DepartmentService()
        {
            departmentRepository = new DepartmentRepository();
        }
        public void Insert(Department obj)
        {
            departmentRepository.Insert(obj);
        }
        public IEnumerable<Department> GetAll()
        {
            return departmentRepository.GetAll();
        }
        public Department GetById(int id)
        {
            return departmentRepository.GetBy(id);
        }
        public void Update(Department obj)
        {
            departmentRepository.Update(obj);
        }
        public void DeleteAll()
        {
            departmentRepository.DeleteAll();
        }
        public void DeleteById(int id)
        {
            departmentRepository.DeleteBy(departmentRepository.GetBy(id));
        }

    }
}
