
using System.ComponentModel.DataAnnotations;


namespace evaluacion.Models { 

public class Prestamo
{
    [Key]
    public Guid PrestamoId { get; set; }
    public int Monto { get; set; }
    public int TasaInteres { get; set; }
    public int Plazo { get; set; }

}
}
