using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using amortizacion;
using Microsoft.SqlServer;






internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        //builder.Services.AddDbContext<AmortizacionContext>(p => p.UseInMemoryDatabase("AmortizacionDB"));
        builder.Services.AddSqlServer<AmortizacionContext>("Data Source = MSI\\SQLEXPRESS; Initial Catalog = AmortizacionDB;Trusted_Connection = True; Integrated Security = True");

        var app = builder.Build();

        app.MapGet("/", () => "Hello World!");

        app.MapGet("/dbconexion", async ([FromServices] AmortizacionContext dbContext) =>
            {
                dbContext.Database.EnsureCreated();
                return Results.Ok("base de datos en memoria: " + dbContext.Database.IsInMemory());


            });
        app.Run();

    }
}