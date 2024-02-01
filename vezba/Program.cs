using Microsoft.EntityFrameworkCore;
using vezba.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("ConStr")));
builder.Services.AddCors();
// Add services to the container.

builder.Services.AddControllers();
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
app.UseCors(opt => opt.AllowAnyHeader().AllowAnyMethod().AllowCredentials().SetIsOriginAllowed(origin => true));
app.UseAuthorization();

app.MapControllers();

app.Run();
