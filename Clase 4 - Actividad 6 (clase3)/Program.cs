namespace actividad6
{
    class Program
    {
        static void Main(string[] args)
        {
            double interesMensual = 0.015;
            double saldo = 1000;
            double pagado = 0;
            int contadorMes = 0;

            Console.WriteLine("DEUDA = $1000 - INTERES 1,5% Mensual");
            Console.WriteLine("Ingrese monto fijo mensual que abonara");
            int pagoMensual = int.Parse(Console.ReadLine());

            Calcular(interesMensual, saldo, pagado, contadorMes, pagoMensual);
        }

        static void Calcular(double interesMensual, double saldo, double pagado, int contadorMes, double pagoMensual)
        {
            while (saldo > 0)
            {
                double intereses = saldo * interesMensual; //15
                saldo += intereses;                        //1000 + 15
                saldo -= pagoMensual;                      //1000 - pago  (ej 1000-100)                             
                pagado += pagoMensual + interesMensual;         // 0 + 100
                contadorMes++;

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Mes: " + contadorMes);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Saldo actual: " + saldo.ToString("C2"));
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Total pagado: " + pagado.ToString("C2"));
                Console.ResetColor();
            }

            //SALDO < 0
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("¡Deuda saldada!");
            Console.ResetColor();
        }

    }
}
