using Microsoft.EntityFrameworkCore;
using System.Globalization;
using Work_Flow.Application.Implementation.Services;
using Work_Flow.Application.Interfaces.Repositories;
using Work_Flow.Application.Interfaces.Services;
using Work_Flow.Domain.Interfaces.Repositories;
using Work_Flow.Infrastructure.Data;
using Work_Flow.Infrastructure.Implementation.Repositories;
using Work_Flow.Infrastructure.Implementation.Services;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<IUserServices, UserServices>();
builder.Services.AddScoped<IBoardService, BoardService>();

builder.Services.AddScoped<IAccountRepo, AccountRepo>();
builder.Services.AddScoped<IUserRepo, UserRepo>();
builder.Services.AddScoped<IBoardRepo, BoardRepo>();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

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
