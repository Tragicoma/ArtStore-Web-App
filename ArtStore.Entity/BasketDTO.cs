using System;
using System.Collections.Generic;
using System.Text;

namespace ArtStore.Entity
{
    public class BasketDTO
    {
        public List<OrderLineDTO> Products { get; set; }
        public double Sum { get; set; }
    }
}
