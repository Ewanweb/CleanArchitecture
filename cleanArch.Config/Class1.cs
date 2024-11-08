using CleanArch.App.Orders;
using CleanArch.App.Products;
using CleanArch.Dom.Orders;
using CleanArch.Dom.Products;
using CleanArch.Infranstructure.Presistant.Memory;
using CleanArch.Infranstructure.Presistant.Memory.Orders;
using CleanArch.Infranstructure.Presistant.Memory.Products;
using Microsoft.Extensions.DependencyInjection;

namespace cleanArch.Config
{
    public class ProjectBootStrapper
    {
        public static void Init(IServiceCollection services)
        {
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddSingleton<Context>();
        }
    }
}
