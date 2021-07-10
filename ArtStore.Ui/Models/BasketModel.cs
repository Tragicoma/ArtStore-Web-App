using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtStore.Ui.Models
{
    public class BasketModel
    {
        List<ProductModel> Products { get; set; }
        double Sum { get; set; }

    }
}
