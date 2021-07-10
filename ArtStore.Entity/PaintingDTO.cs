using System;
using System.Collections.Generic;
using System.Text;

namespace ArtStore.Entity
{
    public class PaintingDTO : ProductDTO
    {
        string Size { get; set; }
        bool IsAvailable { get; set; }
    }
}
