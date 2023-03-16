using API.Data;
using Microsoft.EntityFrameworkCore;

var Builder = WebApplication.CreateBuilder(args);

// Add services to the container

Builder.Services.AddControllers();
Builder.Services.AddDbContext<DataContext>(opt => 
{
    opt.UseSqlite(Builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = Builder.Build();

// Configuer the HTTP request pipeline.
app.MapControllers();

app.Run();