using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtStore.Ui.Models
{
    public class PaintingModel : ProductModel
    {
        string Size { get; set; }
        bool IsAvailable { get; set; }
    }
}
