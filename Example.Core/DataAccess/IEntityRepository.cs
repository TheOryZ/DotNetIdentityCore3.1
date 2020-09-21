using Example.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Example.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter = null);
        //Expression<Func<T, bool>> filter = null kullanımı sayesinde, bi parametreye göre Liste dönmesini sağlıyoruz. Null geçilebilir. Null gönderilirse tüm listeyi getirmesi sağlanacak.
        List<T> GetList(Expression<Func<T, bool>> filter = null);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
