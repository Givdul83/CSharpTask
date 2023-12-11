using AppLibrary.Services;
using CSharpConsoleApp.Services;
using System.Linq.Expressions;

var contactService = new ContactService();
var menuService = new MenuService();

menuService.MainMenu();