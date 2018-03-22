using LearningCSharp.Topics.MoreEF.Models;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace LearningCSharp.Topics.MoreEF.Repository
{
    public class EFRepository<C, T> : IEFRepository<T> where T: BaseEntity
    {
        private PhoneBookDbContext context = new PhoneBookDbContext();
        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
            Save();
        }

        public void Delete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity is null");

            var result = context.Set<T>().FirstOrDefault(t => t.Id == entity.Id);

            if (result == null)
                return;

            context.Set<T>().Remove(result);
            Save();
        }

        public void Delete(T[] entities)
        {
            Action<T> action = entity =>
            {
                if (entity == null)
                    throw new ArgumentNullException("entity is null");

                var result = context.Set<T>().FirstOrDefault(t => t.Id == entity.Id);

                if (result == null)
                    return;

                context.Set<T>().Remove(result);
            };

            Array.ForEach(entities, action);

            Save();
        }

        public void Edit(T entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetSingle(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
