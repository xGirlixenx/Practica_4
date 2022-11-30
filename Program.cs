using System;

namespace FahrenheitACelsiusYViceversa
{
    class FahrenheitACelsiusYViceversa
    {
        static void Main(string[] args)
        {
            int opcion;
            double resultado, temperatura;
            Console.Write("Ingresa el valor de temperatura: ");
            temperatura = double.Parse(Console.ReadLine());
            Console.WriteLine("Selecciona el valor de opcion.");
            Console.WriteLine("\t1.- Fahrenheit a Celsius");
            Console.WriteLine("\t2.- Celsius a Fahrenheit");
            Console.Write("\t: ");
            do
            {
                opcion = int.Parse(Console.ReadLine());
                if (opcion < 1 || opcion > 2)
                    Console.Write("Valor incorrecto. Ingr\u00E9salo nuevamente.: ");
            } while (opcion < 1 || opcion > 2);
            if (opcion == 1)
                resultado = (temperatura - 32) / 1.8;
            else
                resultado = 1.8 * temperatura + 32;
            Console.WriteLine("Valor de resultado: " + resultado);
            Console.WriteLine();
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();
        }
    }
}