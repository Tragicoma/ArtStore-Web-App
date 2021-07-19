using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ArtStore.Entity
{
    public class ProductDTO
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public PaintingAuthorDTO Author { get; set; }
        public string Description { get; set; }
        public int Category { get; set; }
        public string Picture { get; set; }
    }
}

