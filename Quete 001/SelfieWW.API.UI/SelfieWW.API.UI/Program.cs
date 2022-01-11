using SelfieAwwokieCore.Selfies.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using SelfieAwwokieCore.Selfies.Domain;
using SelfieAwwokieCore.Selfies.Infrastructure.Repositories;
using SelfieWW.API.UI.Controllers.ExtentionMehods;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SelfieContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SelfiesDatabase") 

    );

});
//builder.Services.AddTransient<ISelfieRepository, DefaultSelfieRepositories>();

builder.Services.AddScoped<ISelfieRepository, DefaultSelfieRepositories>();
builder.Services.AddInjection();

//builder.Services.AddSingleton<DefaultSelfieRepositories>();




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
