var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();



// Controller: MVC uygulamalarında kullanılan bir yapıdır. Controller, kullanıcıdan gelen istekleri karşılar ve bu isteklere göre işlem yapar.

// Action: Controller sınıfı içerisinde tanımlanan metotlardır. Bu metotlar, Controller sınıfı içerisinde tanımlanır ve Controller sınıfı içerisindeki
//metotlar Action olarak adlandırılır.

// Model: Model, uygulama içerisinde kullanılan veri yapısıdır.

// View: View, uygulama içerisinde kullanıcıya sunulan arayüz yapısıdır. 

// Razor: Razor, ASP.NET Core uygulamalarında kullanılan bir view motorudur.

//wwwroot: wwwroot, ASP.NET Core uygulamalarında statik dosyaların tutulduğu klasördür.
