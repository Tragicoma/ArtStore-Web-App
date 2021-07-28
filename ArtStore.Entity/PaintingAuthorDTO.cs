using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ArtStore.Entity
{
    public class PaintingAuthorDTO
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Country { get; set; }
        public string Portfolio { get; set; } // link to somewhere?
    }
}
