using StoreOnline.DataAccess;
using Microsoft.EntityFrameworkCore;
using StoreOnline.Core.Abstractions.Repositories;
using StoreOnline.DataAccess.Repositories;
using StoreOnline.Core.Abstractions.Services;
using StoreOnline.API.Services;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUsersRepository, UsersRepository>();
builder.Services.AddScoped<IProductsRepository, ProductsRepository>();
builder.Services.AddScoped<IOrdersRepository, OrdersRepository>();
builder.Services.AddScoped<IPaymentsRepository, PaymentsRepository>();
builder.Services.AddScoped<IDeliveriesRepository, DeliveriesRepository>();
builder.Services.AddScoped<IBasketsRepository, BasketsRepository>();
builder.Services.AddScoped<ICategoriesRepository, CategoriesRepository>();

builder.Services.AddScoped<IUsersService, UsersService>();
builder.Services.AddScoped<IProductsService, ProductsService>();
builder.Services.AddScoped<IOrdersService, OrdersService>();
builder.Services.AddScoped<IPaymentsService, PaymentsService>();
builder.Services.AddScoped<IDeliveriesService, DeliveriesService>();
builder.Services.AddScoped<IBasketsService, BasketsService>();
builder.Services.AddScoped<ICategoriesService, CategoriesService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();