﻿using CleanArch.Dom.Orders;
using CleanArch.Dom.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infranstructure.Presistant.Memory
{
    public  class Context
    {
        public  List<Product> Products { get; set; }
        public  List<Order> Orders { get; set; } = new List<Order>() { new Order(Guid.NewGuid(),100,1000)};
    }
}