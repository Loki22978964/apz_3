
using BLL.Infrastructure;
using BLL.Interfaces;
using BLL.Services;
using DAL;
using DAL.EF;
using DAL.Interfaces;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using UI;

// Top-level programs can be async.
var services = new ServiceCollection();

services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ContentLibDB;Trusted_Connection=True;"));

IServiceCollection serviceCollection = services.AddAutoMapper(typeof(MappingProfile));

services.AddScoped<IUnitOfWork, UnitOfWork>();
services.AddScoped<IContentService, ContentService>();

var serviceProvider = services.BuildServiceProvider();

var menu = new MainMenu(serviceProvider.GetRequiredService<IContentService>());
menu.Show();