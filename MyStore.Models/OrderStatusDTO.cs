using System;
using System.Collections.Generic;

namespace MyStore.Models
{
    public partial class OrderStatusDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<CustomerOrderDTO> CustomerOrder { get; set; }
    }
}