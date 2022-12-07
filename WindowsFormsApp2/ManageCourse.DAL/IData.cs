using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCourse.DAL
{
    public interface IData<T>
    {
        List<T> GetAll();
        T GetAnyById(int id);
        void Create(T data);
        void Update(T data);
        void Delete(int id);
        
    }
}
