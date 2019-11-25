using System;
using System.Collections.Generic;
using System.Text;
using WebNotePad.Core;

namespace WebNotePad.Infrastructure
{
    public class NoteRepository : INoteRepository<Note>
    {
        readonly MyApplicationDbContext dbContext;
        public NoteRepository(MyApplicationDbContext db)
        {
            this.dbContext = db;
        }
        public void Add(Note entity)
        {
            dbContext.Add(entity);
            dbContext.SaveChanges();
        }

        public void Delete(Note Entity)
        {
            
        }

        public Note Get(long Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Note> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Note dbEntity, Note Entity)
        {
            throw new NotImplementedException();
        }
    }
}
