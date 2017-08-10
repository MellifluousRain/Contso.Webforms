using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contso.Data
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetBy(int id);
        void DeleteAll();
        void DeleteBy(T obj);
        void Update(T obj);
        void Insert(T obj);
    }
}
