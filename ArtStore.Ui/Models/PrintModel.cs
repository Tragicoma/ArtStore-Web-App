using ArtStore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtStore.Ui.Models
{
    public class PrintModel : PaintingModel
    {
        printSizeEnum Size { get; set; }
    }
}
