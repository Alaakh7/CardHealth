using Microsoft.EntityFrameworkCore;
using Utils.Models;
using Utils.Services;

var builder = WebApplication.CreateBuilder(args);
JasonManger.SetJeson();
builder.Services.AddDbContextPool<Context>(options => options.UseSqlServer(JasonManger.GetConnectionString()));
builder.Services.AddControllersWithViews();
builder.Services.AddControllers();
builder.Services.AddSession();

var app = builder.Build();

var context = Context.GetNew();
if (false)
{
    await context.Database.EnsureDeletedAsync();
}
await context.Database.MigrateAsync();
if (!context.Accounts.Any())
{
    await context.Accounts.AddAsync(new Account
    {
        AccountType = Utils.Models.Enums.AccountType.Admin,
        UserName = "admin",
        Password = "123"
    });
    await context.SaveChangesAsync();
}



if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseCookiePolicy();
app.UseAuthorization();
app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Login}/{id?}");

app.Run();
