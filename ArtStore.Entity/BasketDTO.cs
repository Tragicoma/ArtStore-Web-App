using System;
using System.Collections.Generic;
using System.Text;

namespace ArtStore.Entity
{
    public class BasketDTO
    {
        List<ProductDTO> Products { get; set; }
        double Sum { get; set; }
    }
}
