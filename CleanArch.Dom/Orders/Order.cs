using System;
using System.Collections.Generic;

namespace CleanArch.Dom.Orders
{
    public class Order
    {
        public int Id { get; private set; }
        public Guid ProductId { get; private set; }
        public int Price { get; private set; }
        public int Count { get; private set; }
        public bool IsFinaly { get; private set; }
        public DateTime FinalyDate { get; private set; }
        public int TotalPrice => Count * Price;

        public Order(Guid productId, int price, int count)
        {
            if (price < 0)
                throw new ArgumentOutOfRangeException(nameof(price), "Price must be non-negative.");

            if (count <= 1)
                throw new ArgumentException("Count must be greater than 1.", nameof(count));

            ProductId = productId;
            Price = price;
            Count = count;
        }

        public void Finaly()
        {
            IsFinaly = true;
            FinalyDate = DateTime.Now;
        }

        public void IncreaseProductCount(int count)
        {
            if (count < 1)
                throw new ArgumentException("Count to add must be at least 1.", nameof(count));

            Count += count;
        }
    }
}
