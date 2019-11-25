using System;
using System.Collections.Generic;
using System.Text;

namespace WebNotePad.Core.Models
{
  public class Note 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public DateTime DateCreated { get; set; }

    }
}
