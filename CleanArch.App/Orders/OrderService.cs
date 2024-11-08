using CleanArch.App.Orders.Dto;
using CleanArch.Dom.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.App.Orders
{

    public interface IOrderService
    {
        void AddOrder(AddOrderDto order);
        void FinalyOrder(FinalyOrderDto order);
        OrderDto GetOrderById(int id);
        List<OrderDto> GetAllOrders();
    }


    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repository;

        public OrderService()
        {
        }

        public OrderService(IOrderRepository repository)
        {
            _repository = repository;
        }
        public void AddOrder(AddOrderDto order)
        {
            var orders = new Order(order.ProductId, order.Price, order.Count);
            _repository.Add(orders);
            _repository.Save();
        }

        public void FinalyOrder(FinalyOrderDto order)
        {
            var orders = _repository.GetById(order.OrderId);
            orders.Finaly();
            _repository.Update(orders);
            _repository.Save();
        }

        public List<OrderDto> GetAllOrders()
        {
            return _repository.GetAll().Select(orders => new OrderDto()
            {
                Count = orders.Count,
                Price = orders.Price,
                Id = orders.Id,
                ProductId = orders.ProductId
            }).ToList();
        }

        public OrderDto GetOrderById(int id)
        {
            var orders = _repository.GetById(id);
            return new OrderDto()
            {
                 Count = orders.Count,
                 Price = orders.Price,
                 Id = orders.Id,
                 ProductId = orders.ProductId
            };

        }
    }

}
