using CleanArch.App.Orders.Dto;
using CleanArch.App.Products.DTO;
using CleanArch.Dom.Orders;
using CleanArch.Dom.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.App.Products
{
    public interface IProductService
    {
        void AddProduct(AddProductDto command);
        void EditProduct(EditProductDto command);
        ProductDto GetOProductById(Guid id);
        List<ProductDto> GetAllProducts();
    }

    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }
        public void AddProduct(AddProductDto command)
        {
            var product = new Product(command.Title,command.Price);
            _repository.Add(product);
            _repository.Save();
        }

        public void EditProduct(EditProductDto command)
        {
            var product = _repository.GetById(command.Id);
            _repository.Update(product);
            _repository.Save();
        }

        public List<ProductDto> GetAllProducts()
        {
            return _repository.GetAll().Select(products => new ProductDto()
            {
                Price = products.Price,
                Id = products.Id,
                 Title = products.Title
            }).ToList();
        }

        public ProductDto GetOProductById(Guid id)
        {
            var products = _repository.GetById(id);
            return new ProductDto()
            {
                Title = products.Title,
                Price = products.Price,
                Id = products.Id,
            };
        }

    }
}
