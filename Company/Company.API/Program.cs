using Company.API.CompanyHub;
using Company.Business.Abstract;
using Company.Business.Concrete;
using Company.DataAccess.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy = null;
});

builder.Services.AddDbContext<CompanyContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("CompanyDBConnection")));

builder.Services.AddScoped<IPersonelService, PersonelManager>();

builder.Services.AddSignalR();

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        builder => builder
            .AllowAnyMethod()
            .AllowAnyHeader()
            .WithOrigins("http://localhost:1617", "http://localhost:4200")
            .AllowCredentials());
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(x =>
{
    x.SwaggerDoc("v1", new OpenApiInfo { Title = "Company API", Version = "v1" });

    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    x.IncludeXmlComments(xmlPath);

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();
app.UseCors("CorsPolicy");
app.MapHub<PersonelHub>("/personelHub");

app.Run();
