using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket_HM101
{
    public class Cart
    {
        public int CartId { get; private set; }
        private readonly List<(Product Item, int Quantity)> _items;

        public Cart(int cartId)
        {
            CartId = cartId;
            _items = new List<(Product, int)>();
        }

        public void AddItem(Product item, int quantity = 1)
        {
            var existingItem = _items.Find(i => i.Item.Id == item.Id);
            if (existingItem.Item != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                _items.Add((item, quantity));
            }
        }

        public void RemoveItem(Product item)
        {
            _items.RemoveAll(i => i.Item.Id == item.Id);
        }

        public IEnumerable<(Product Item, int Quantity)> ListItems()
        {
            return _items.AsEnumerable();
        }

        public decimal GetTotal()
        {
            return _items.Sum(item => item.Item.Price * item.Quantity);
        }
    }
}
