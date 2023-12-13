using AppLibrary.Services;
using AppLibrary.Interfaces;
using CSharpConsoleApp.Services;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Linq.Expressions;
var builder = Host.CreateDefaultBuilder().ConfigureServices(services =>
{
    services.AddSingleton<IFileService, FileService>();
    services.AddSingleton<IContactService, ContactService>();
   
    services.AddSingleton<MenuService>();

}).Build();

builder.Start();
Console.Clear();


var menuService= builder.Services.GetRequiredService<MenuService>();
menuService.MainMenu();