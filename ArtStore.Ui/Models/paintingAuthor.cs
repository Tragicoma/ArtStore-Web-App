using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtStore.Ui.Models
{
    public class paintingAuthor
    {
        int Id { get; set; }
        string FullName { get; set; }
        string Country { get; set; }
        string Portfolio { get; set; } // link to somewhere?
    }
}
