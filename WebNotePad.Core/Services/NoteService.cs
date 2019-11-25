using System;
using System.Collections.Generic;
using System.Text;
using WebNotePad.Core.Models;

namespace WebNotePad.Core.Services
{
    public class NoteService: INoteRepository<WebNotePad.Core.Models.Note>
    {
        INoteRepository<WebNotePad.Core.Models.Note> note;
        public NoteService(INoteRepository<WebNotePad.Core.Models.Note> Irepo)
        {
            this.note = Irepo;
        }

        public void Add(Note entity)
        {
            note.Add(entity);
        }

        public void Delete(Note Entity)
        {
            note.Delete(Entity);
        }

        public Note Get(long Id)
        {
            return note.Get(Id);
        }

        public IEnumerable<Note> GetAll()
        {
            return note.GetAll();
        }

        public void Update(Note dbEntity, Note Entity)
        {
            throw new NotImplementedException();
        }
    }
}
