using System;
using System.Collections.Generic;
using System.Text;

namespace WebNotePad.Infrastructure
{
  public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }

       public ICollection<Note> Notes { get; set; }

    }
}
