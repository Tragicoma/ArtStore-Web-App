using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtStore.Ui.Models
{
    public class paintingAuthorModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Country { get; set; }
        public string Portfolio { get; set; } // link to somewhere?
    }
}
