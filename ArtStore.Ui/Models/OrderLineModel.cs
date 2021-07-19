using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtStore.Ui.Models
{
    public class OrderLineModel
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public double LineSum { get; set; }
    }
}
