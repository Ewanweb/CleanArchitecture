using CleanArch.Dom.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infranstructure.Presistant.Memory.Products
{
    public class ProductRepository : IProductRepository
    {
        private Context _context;
        public ProductRepository(Context context)
        {
            _context = context;
        }
        public void Add(Product product)
        {
            _context.Products.Add(product);
        }

        public List<Product> GetAll()
        {
            return _context.Products;
        }

        public Product GetById(Guid id)
        {
            return _context.Products.FirstOrDefault(f => f.Id == id);
        }

        public void Remove(Product product)
        {
            _context.Products.Remove(product);

        }

        public void Save()
        {
            //
        }

        public void Update(Product product)
        {
            var oldProduct = GetById(product.Id);
            _context.Products.Remove(oldProduct);
            Add(product);
        }
    }
}
