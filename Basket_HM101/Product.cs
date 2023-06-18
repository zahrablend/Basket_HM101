using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket_HM101
{
    public abstract class Product
    {
        public int Id { get; private set; }
        public string? Brand { get; set; }
        public decimal Price { get; private set; }
        public int Volume { get; set; }
        public SkinType SkinType { get; set; }
        public HairType HairType { get; set; }
        public string? Description { get; set; }

        protected Product(int id, decimal price)
        {
            Id = id;
            Price = price;
        }
    }
}
