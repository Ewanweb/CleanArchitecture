using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Dom.Products
{
    public class Product
    {
         
            
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public int Price { get; private set; }


        public Product(string title, int price)
        {
            Guard(title,price);
            Title = title;
            Price = price;
            Id = Guid.NewGuid();
        }

        public void Edit(string title, int price)
        {
            Guard(title, price);
            Title = title;
            Price = price;
        }



        private void Guard(string title, int price)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentNullException("title");

            if (price < 0)
                throw new ArgumentOutOfRangeException();
        }
    }
}
