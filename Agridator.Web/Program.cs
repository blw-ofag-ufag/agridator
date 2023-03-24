using Agridator.Web.Data;
using Agridator.Web.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddHostedService<MigratorService>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "agridator Backend", Version = "v1" });
    c.EnableAnnotations();
});

builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(typeof(CatalogMappingProfile).Assembly);

// CORS configuration
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});


var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetService<ApplicationDbContext>();
        if (context?.Database.GetPendingMigrations().Any() ?? false)
        {
            context.Database.EnsureDeleted();
            context.Database.Migrate();
            Task.Run(async ()=> await DataSeeder.SeedDataAsync(context));
        }
    }
    catch (Exception ex)
    {
        //nope
    }
}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // empty for now
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles();
app.UseRouting();

app.UseCors();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();
