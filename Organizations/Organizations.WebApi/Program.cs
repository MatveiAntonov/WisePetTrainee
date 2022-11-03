using Organizations.Application.Common.Mappings;
using Organizations.Persistence;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddAutoMapper(typeof(OrganizationsMappingProfile));

builder.Services.AddDbContext<OrganizationsDbContext>(opts => {
    opts.UseSqlServer(builder.Configuration["ConnectionStrings:OrganizationsConnection"]);
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
