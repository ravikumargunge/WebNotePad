using System;
using WebNotePad.Core.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebNotePad.Infrastructure
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public DateTime DateCreated { get; set; }

        [ForeignKey("TagId")]
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
