using System.Security.Principal;
using Work_Flow.Application.Interfaces.Repositories;
using Work_Flow.Application.Interfaces.Services;
using Work_Flow.Infrastructure.Implementation.Repositories;
using Work_Flow.Infrastructure.Implementation;
using Work_Flow.Infrastructure.Implementation.Services;
using Microsoft.EntityFrameworkCore;
using Work_Flow.Infrastructure.Data;


{

    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.

    builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    builder.Services.AddScoped<IAccountService, AccountService>();
    builder.Services.AddScoped<IAccountRepo, AccountRepo>();
    builder.Services.AddScoped<IUserServices, UserServices>();
    builder.Services.AddScoped<IUserRepo, UserRepo>();
    builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
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

    app.Run(); }
