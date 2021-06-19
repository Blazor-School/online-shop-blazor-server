using System;
using System.Collections.Generic;

namespace OnlineShopBlazorServer.Data
{
    public class Cart
    {
        public Guid Id { get; set; }
        public List<Product> Items { get; set; }
    }
}
