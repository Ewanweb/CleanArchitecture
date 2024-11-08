using CleanArch.App.Orders;
using CleanArch.Dom.Orders;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        private IOrderService _orderRepository;
        public HomeController(IOrderService orderService) {
            _orderRepository = orderService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_orderRepository.GetAllOrders());
        }
    }
}
