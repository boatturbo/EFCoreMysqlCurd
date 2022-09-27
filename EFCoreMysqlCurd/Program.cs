using EFCoreMysqlCurd.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ParameterContext>(opt => {
string connectionString = builder.Configuration.GetConnectionString("MySQLConnection");
var serverVersion = ServerVersion.AutoDetect(connectionString);
opt.UseMySql(connectionString, serverVersion);
});


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

app.UseAuthorization();

app.MapControllers();

app.Run();

//转载自https://blog.csdn.net/EAyayaya/article/details/124048491
//转载自http://t.csdn.cn/iVInw
