using ExploradorFaunaMarinaAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MarinaContext>(options =>
    options.UseSqlite("Data Source=faunamarina.db"));

builder.Services.AddControllers(); // 👈 AGREGA ESTA LÍNEA

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
