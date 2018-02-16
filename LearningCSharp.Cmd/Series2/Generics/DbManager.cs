using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Series2.Generics
{
    public class DbManager<TM> : IDbManager<TM>
    {
       
        public DbManager()
        {
        }

        public bool Delete(int id)
        {
            return true;
        }
        public TM Update(TM item)
        {
            return default(TM);
        }

        public TM Add(TM item)
        {
            return default(TM);
        }
        //public TEntity Update<TEntity>(TEntity item) where TEntity : Staff
        //{
        //    return default(TEntity);
        //}
        //public TModel Add<TModel>(TModel item) where TModel : Staff
        //{
        //    return default(TModel);
        //}
    }
}
