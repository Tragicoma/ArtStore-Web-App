using System;
using System.Collections.Generic;
using System.Text;

namespace ArtStore.Entity
{
    public class ProductDTO
    {
        int ID { get; set; }
        string Name { get; set; }
        double Price { get; set; }
        PaintingAuthorDTO Author { get; set; }
        string Description { get; set; }
        paintingCategoryDTO Category { get; set; }
    }
}
