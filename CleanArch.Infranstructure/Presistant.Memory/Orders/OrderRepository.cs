using CleanArch.Dom.Orders;
using CleanArch.Dom.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infranstructure.Presistant.Memory.Orders
{
    public class OrderRepository : IOrderRepository
    {
        private Context _context;
        public OrderRepository(Context context)
        {
            _context = context;
        }
        public void Add(Order order)
        {
            _context.Orders.Add(order);
        }

        public List<Order> GetAll()
        {
            return _context.Orders;
        }

        public Order GetById(int id)
        {
            return _context.Orders.FirstOrDefault(f => f.Id == id);
        }

        public void Save()
        {
            //
        }

        public void Update(Order order)
        {
            var oldOrder = GetById(order.Id);
            _context.Orders.Remove(oldOrder);
            Add(order);
        }
    }
}
