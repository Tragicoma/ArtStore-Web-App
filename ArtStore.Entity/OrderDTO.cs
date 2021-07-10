using System;
using System.Collections.Generic;
using System.Text;

namespace ArtStore.Entity
{
    public class OrderDTO
    {
        int Id { get; set; }
        DateTime Date { get; set; }
        BasketDTO OrderBasket { get; set; }
        string Email { get; set; }
        string ClientName { get; set; }
        orderStatusDTO Status { get; set; }
    }
}
