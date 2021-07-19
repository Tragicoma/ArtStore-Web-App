using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtStore.Ui.Models
{
    public class PaintingModel : ProductModel
    {
        public string Size { get; set; }
        public bool IsAvailable { get; set; }
    }
}
