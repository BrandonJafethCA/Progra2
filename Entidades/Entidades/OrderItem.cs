﻿using System.Collections.Generic;

namespace DataAccess.Entidades
{
    public class OrderItem
    {
        public int? Id { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public List<Products>? Products { get; set; }
        public int? Quantity { get; set; }
        public double? Subtotal { get; set; }
    }
}
