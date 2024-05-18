using Microsoft.EntityFrameworkCore;
using ChatRoom.Hubs;
using ChatRoom.Models;


var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddDbContext<RealTimeDbContext>(options =>
{
	options.UseSqlServer(builder.Configuration.GetConnectionString("Database"));
	options.EnableSensitiveDataLogging();
});

services.AddAuthentication().AddCookie(options =>
{
	options.Cookie.Name = "RealTimeAuthCookie";
});
services.AddAuthorization();

services.AddRazorPages(options =>
{
    options.Conventions.AddPageRoute("/Index", "/home");
});

services.AddSignalR();
//---------------------------------------------------------


var app = builder.Build();

app.UseStaticFiles();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.MapHub<ChatHub>("/chathub");

app.Run();