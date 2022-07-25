using System;
using System.Collections.Generic;

namespace Domain.models
{
    public partial class Traderecord
    {
        public string Id { get; set; }
        public string ClientName { get; set; }
        public string ItemName { get; set; }
        public int ItemQuantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
