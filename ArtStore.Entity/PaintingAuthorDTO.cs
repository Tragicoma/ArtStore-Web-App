using System;
using System.Collections.Generic;
using System.Text;

namespace ArtStore.Entity
{
    public class PaintingAuthorDTO
    {
        int Id { get; set; }
        string FullName { get; set; }
        string Country { get; set; }
        string Portfolio { get; set; } // link to somewhere?
    }
}
