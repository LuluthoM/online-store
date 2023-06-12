using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnlineStore;
using OnlineStore.Services;
using OnlineStore.Services.Cart;
using OnlineStore.Services.fcInterviewAPI.Orders;
using OnlineStore.Services.fcInterviewAPI.Products;
using OnlineStore.Services.fcInterviewAPI.Users;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

var configuration = builder.Configuration;

builder.Services.AddSingleton<IOrderService>(sp => new OrderService(configuration["Api:Endpoint"], configuration["Api:ApiKey"]));
builder.Services.AddSingleton<IProductService>(sp => new ProductService(configuration["Api:Endpoint"], configuration["Api:ApiKey"]));
builder.Services.AddSingleton<IUserService>(sp => new UserService(configuration["Api:Endpoint"], configuration["Api:ApiKey"]));
builder.Services.AddSingleton<ICartService>(sp => new CartService());

await builder.Build().RunAsync();
