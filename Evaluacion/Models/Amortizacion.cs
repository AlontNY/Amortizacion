
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace evaluacion.Models
{

    public class Amortizacion
    {
        [Key]
        public Guid AmortizacionId { get; set; }
        public int NumCuotas { get; set; }
        public int MontoCapital { get; set; }
        public int MontoInteres { get; set; }
        public int SaldoInsolutoCredito { get; set; }
        [ForeignKey("PrestamoID")]
        public Guid PrestamoId { get; set; }
    }
}