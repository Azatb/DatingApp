var Builder = WebApplication.CreateBuilder(args);



Builder.Services.AddControllers();

var app = Builder.Build();

// Configuer the HTTP request pipeline.
app.MapControllers();

app.Run();