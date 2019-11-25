using System;
using System.Collections.Generic;

namespace WebNotePad.Core
{
    public interface INoteRepository<T>
    {
        IEnumerable<T> GetAll();
        void Add(T entity);
        T Get(long Id);
        void Update(T dbEntity, T Entity);
        void Delete(T Entity);


    }
}
