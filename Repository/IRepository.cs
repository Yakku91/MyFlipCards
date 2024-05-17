using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCards.Repository
{
   internal interface IRepository<T> where T : class
    {

        List<T> GetAll();
        T FindById(int id);
        void Add(T entity);
        void update(T entity);
        void delete(T entity);
    }
}
