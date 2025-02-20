using System;

namespace Single_Responsibility_Solution;

public class ShoppingCart
    {
        private List<ShoppingCartItem> items { get; set; } = new List<ShoppingCartItem>();

        public IEnumerable<ShoppingCartItem> Items { get {  return items; } }

        public void Add(ShoppingCartItem item)
        {
            items.Add(item);
        }

        public void Remove(ShoppingCartItem item)
        {
            items.Remove(item);
        }

        public void Clear() { 
            items.Clear(); 
        }

        public double GetTotal()
        {
            return items.Sum(i => i.Quantity * i.Price);
        }

    }
