using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyek_PAD
{
    public class menuItem
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public menuItem(string Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
    public class orderedItem
    {
        public menuItem MenuItem { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice => Price * Quantity;

        public orderedItem(menuItem menuItem, int quantity, decimal price)
        {
            this.MenuItem = menuItem;
            this.Quantity = quantity;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"{MenuItem.Name} X{Quantity}";
        }
    }
}
