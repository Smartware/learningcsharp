using LearningCSharp.Topics.MoreEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Topics.MoreEF.Repository
{
    public interface IEFRepository<T> 
    {
        T GetSingle(int id);
        IQueryable<T> GetAll();
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
        void Delete(T[] entity);
        void Edit(T entity);
        void Save();
    }
}
