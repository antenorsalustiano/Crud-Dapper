using Crud_Dapper.Data;
using Crud_Dapper.Repository;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<IDapperContext, DapperContext>();
builder.Services.AddTransient<IBranchRepository, BranchRepository>();
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Branch}/{action=Index}/{id?}");

app.Run();
