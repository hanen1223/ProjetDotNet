using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using AM.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();// return ICollectionService
builder.Services.AddScoped<IServiceFlight,ServiceFlight>();//scopped=tasn3 instance 3la kol requete==>IServiecFlight service =new ServiceFlight(uow);
builder.Services.AddScoped<IServiceplane,Serviceplane>();//scopped=tasn3 instance 3la kol requete==>IServiecFlight service =new ServiceFlight(uow);
builder.Services.AddScoped<IUnitOfWork,UnitOfWork>();
builder.Services.AddDbContext<DbContext, AMContexte>();
builder.Services.AddSingleton<Type>(t=>typeof(GenericRepository<>));
//ligne 11,12,13 meme f kol projet mais 10 ytbadl
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
    pattern: "{controller=Home}/{action=Privacy}/{id?}");

app.Run();
