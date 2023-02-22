using System;


namespace Prestamo
{
    class Generador_datos
    {
        static void Main(string[] args)
        {
            
            var Prestamo = new Datos_prestamo();
            Prestamo.Monto_capital = 12000;
            Prestamo.TasaInteresAnual = 18;
            Prestamo.NumCuotas = 24;
            var deuda = Prestamo.Monto_capital;
            float pago = Prestamo.ImporteCapital();
           

            for (int i = 1; i <= Prestamo.NumCuotas; i++)
            {

                Console.WriteLine("NumCuota: "+ i);
                Console.WriteLine("montoCapital: " + pago);
                Console.WriteLine("montoInteres: " + Prestamo.MontoInteres(deuda));
                deuda = deuda - pago;
                Console.WriteLine("SaldoInsolutoCredito: " + deuda);
                Console.WriteLine("\n\n");


            }

           
            
            Console.ReadKey();
        }
    }
}