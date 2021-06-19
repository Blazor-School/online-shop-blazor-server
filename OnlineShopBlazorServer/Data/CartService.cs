using System;
using System.Collections.Generic;

namespace OnlineShopBlazorServer.Data
{
    public class CartService
    {
        private readonly Cart _cart;

        public CartService()
        {
            _cart = new();
            _cart.Id = Guid.NewGuid();
            _cart.Items = new();
        }

        public void AddToCart(Product item)
        {
            _cart.Items.Add(item);
        }

        public List<Product> GetProductsInCart()
        {
            return _cart.Items;
        }
    }
}
