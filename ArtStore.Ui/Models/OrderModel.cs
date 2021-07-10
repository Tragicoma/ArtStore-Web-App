using ArtStore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtStore.Ui.Models
{
    public class OrderModel
    {
        int Id { get; set; }
        DateTime Date { get; set; }
        BasketModel OrderBasket { get; set; }
        string Email { get; set; }
        string ClientName { get; set; }
        orderStatusDTO Status { get; set; }

    }
}
