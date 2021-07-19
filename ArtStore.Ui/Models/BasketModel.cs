using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtStore.Ui.Models
{
    public class BasketModel
    {
        public List<ProductModel> Products { get; set; }
        public double Sum { get; set; }

    }
}
