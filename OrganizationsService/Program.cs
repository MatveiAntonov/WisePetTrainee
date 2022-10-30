using Microsoft.EntityFrameworkCore;
using OrganizationsService.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<OrganizationsDbContext>(opts => {
    opts.UseSqlServer(
    builder.Configuration["ConnectionStrings:OrganizationsConnection"]);
});

builder.Services.AddScoped<IOrganizationsRepository, EFOrganizationRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
