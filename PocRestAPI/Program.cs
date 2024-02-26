using Microsoft.EntityFrameworkCore;
using PocRestAPI.Data;
using Serilog;

var configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json", true)
        .Build();

var logger = new LoggerConfiguration()
        .ReadFrom.Configuration(configuration)
        .CreateLogger();
try
{
    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.

    builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    // switch for environment
    builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
    builder.Host.UseSerilog((hostingContext, loggerConfiguration) => 
       loggerConfiguration.ReadFrom.Configuration(hostingContext.Configuration));

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    // app.UseSerilogRequestLogging();  // to log ALL requests

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    Log.Information("starting the application");

    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Application quit unexpectedly");
}
finally
{
    Log.Information("closing the application");
    Log.CloseAndFlush();
}
