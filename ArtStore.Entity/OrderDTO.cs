using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ArtStore.Entity
{
    public class OrderDTO
    {
        [Key]
        public int Id { get; set; }

        public DateTime Date { get; set; }
        public string Email { get; set; }
        public string ClientName { get; set; }
        public int Status { get; set; }
        public double Sum { get; set; }
    }
}
