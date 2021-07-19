using ArtStore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtStore.Ui.Models
{
    public class ProductModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public paintingAuthorModel Author { get; set; }
        public string Description { get; set; }
        public int Category { get; set; }
        public string Picture { get; set; }
    }
}
