using SystemDesign.App.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSession(options =>
{
    options.Cookie.Name = ".SystemDesign.App.Session";
    options.IdleTimeout = TimeSpan.FromSeconds(10);
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseSession();
app.Use(async (context, next) =>
{
    var userAgent = context.Request.Headers["User-Agent"].ToString();
    if (!context.Session.Keys.Contains(userAgent))
    {
        context.Session.SetString(userAgent, Guid.NewGuid().ToString());
        Interlocked.Increment(ref HomeController.UniqueVisitors); // store it not database
    }
    HomeController.CurrentVisitors = context.Session.Keys.Count(); // current users
    await next.Invoke();    
});

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
