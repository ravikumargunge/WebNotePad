using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebNotePad.Core.Models
{
    class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NoteId { get; set; }

    }
}
