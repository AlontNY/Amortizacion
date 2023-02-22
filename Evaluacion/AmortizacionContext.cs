
using evaluacion.Models;
using Microsoft.EntityFrameworkCore;




namespace amortizacion;



public class AmortizacionContext : DbContext
{
    public DbSet<Prestamo> Prestamos { get; set; }
    public DbSet<Amortizacion> Amortizaciones { get; set; }

    public AmortizacionContext(DbContextOptions<AmortizacionContext> options) : base(options) { }
}