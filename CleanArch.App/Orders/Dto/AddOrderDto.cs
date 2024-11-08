using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.App.Orders.Dto
{
    public class AddOrderDto
    {
        public Guid ProductId { get; private set; }
        public int Price { get; private set; }
        public int Count { get; private set; }
    }
}
