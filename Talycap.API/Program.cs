using Microsoft.EntityFrameworkCore;
using Talycap.Repositories.Data;
using Talycap.Repositories.Interfaces;
using Talycap.Repositories.Repositories;
using Talycap.Services;
using Talycap.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ClienteDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IClienteService, ClienteService>();

builder.Services.AddScoped<IClienteRepository, ClienteRepository>();

builder.Services.AddControllers();

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