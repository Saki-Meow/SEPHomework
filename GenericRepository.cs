using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        List<T> dataSource;

        public GenericRepository()
        {
            this.dataSource = new List<T>();
        }

        public void Add(T item)
        {
            dataSource.Add(item);
        }

        public IEnumerable<T> GetAll()
        {
            return dataSource;
        }

        public T GetById(int id)
        {
            return (T)dataSource[id];
        }

        public void Remove(T item)
        {
            dataSource.Remove(item);
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
