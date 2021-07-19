using System;
using System.Collections.Generic;
using System.Text;

namespace ArtStore.Entity
{
    public class PaintingDTO : ProductDTO
    {
        public string Size { get; set; }
        public bool IsAvailable { get; set; }
    }
}
