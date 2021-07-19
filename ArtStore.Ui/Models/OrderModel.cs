using ArtStore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtStore.Ui.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Email { get; set; }
        public string ClientName { get; set; }
        public orderStatusEnum Status { get; set; }

    }
}
