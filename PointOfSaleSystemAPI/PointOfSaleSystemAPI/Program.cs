using PointOfSaleSystem.Services.Products;
using PointOfSaleSystem.Services.Stocks;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Inject services


// only one instance of the service is created and shared per application lifetime
//builder.Services.AddSingleton<IProductRepository, ProductService>();

// a new instance of the service is created each reaquests
builder.Services.AddScoped<IProductRepository, ProductService>();
builder.Services.AddScoped<IStockRepository, StockService>();

// a new instance of the service is created every time it's requested
//builder.Services.AddTransient<IProductRepository, ProductService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
