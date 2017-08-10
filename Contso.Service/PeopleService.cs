using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contso.Data;
using Contso.Model;

namespace Contso.Service
{
    public class PeopleService
    {
        IRepository<People> PeopleRepository;
        public PeopleService()
        {
            PeopleRepository = new PeopleRepository();
        }
        public IEnumerable<People> GetAll()
        {
            return PeopleRepository.GetAll();
        }
        public People GetById(int id)
        {
            return PeopleRepository.GetBy(id);
        }
        public void Insert(People obj)
        {
            PeopleRepository.Insert(obj);
        }
        public void Update(People obj)
        {
            PeopleRepository.Update(obj);
        }
        public void DeleteAll()
        {
            PeopleRepository.DeleteAll();
        }
        public void DeleteById(int id)
        {
            PeopleRepository.DeleteBy(PeopleRepository.GetBy(id));
        }

        public void SavePerson(People obj)
        {
            PeopleRepository.Insert(obj);
        }
    }
}
