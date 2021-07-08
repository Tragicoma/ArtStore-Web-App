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
        double Pride { get; set; }
        paintingAuthor Author { get; set; }

    }
}
