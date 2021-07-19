using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ArtStore.Entity
{
    public class OrderLineDTO
    {
        [Key]
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public double LineSum { get; set; }

    }
}
