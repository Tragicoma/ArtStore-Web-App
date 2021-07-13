using ArtStore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtStore.Ui.Models
{
    public class ProductModel
    {
        int ID { get; set; }
        string Name { get; set; }
        double Price { get; set; }
        paintingAuthorModel Author { get; set; }
        string Description { get; set; }
        paintingCategoryEnum Category { get; set; }


    }
}
