using CleanArch.Dom.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Dom.Products
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product GetById(Guid id);
        void Add(Product product);
        void Update(Product product);
        void Remove(Product product);
        void Save();
    }
}
