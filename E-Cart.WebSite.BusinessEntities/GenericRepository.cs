using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using E_Cart.WebSite.Interfaces;
namespace E_Cart.WebSite.BusinessEntities
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ECartDbContext _context;
        private readonly DbSet<T> table;

        public GenericRepository(ECartDbContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }
        
        public T Add(T obj)
        {
            table.Add(obj);
            _context.SaveChanges();
            return obj;
        }

        public T Delete(int id)
        {
            T obj = table.Find(id);
            if (obj != null)
            {
                table.Remove(obj);
                _context.SaveChanges();

            }
            return obj;
        }

        public IEnumerable<T> GetAllOrders()
        {
            return table;
        }

        public T GetOrders(int id)
        {
            return table.Find(id);
        }


        public T Update(T objUpdate)
        {
            var obj = table.Attach(objUpdate);
            obj.State = EntityState.Modified;
            _context.SaveChanges();
            return objUpdate;
        }

    }
}
