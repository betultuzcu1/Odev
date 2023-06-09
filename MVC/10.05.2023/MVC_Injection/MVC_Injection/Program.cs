using MVC_Injection.Database;
using MVC_Injection.Repository;
using MVC_Injection.Service;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddMvc();

//Injection

//Scoped => her istekle beraber sadece 1 instance verir.
//Singleton => her istek gerçekleştirildiğinde isteği kontrol eder ve sadece 1 adet instance verir.
//Transient => her istek gerçekleştirildiğinde ayrı ayrı instance verir.

builder.Services.AddTransient<ICategoryRepository, CategoryService>();

builder.Services.AddTransient<IProductRepository, ProductService>();

builder.Services.AddTransient<ISupplierRepository, SupplierService>();



var app = builder.Build();

//url rotası aktif edilmesi.
app.UseRouting();

//wwwroot aktif edilmesi
app.UseStaticFiles();


//varsayılan url

app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();

});

app.Run();
