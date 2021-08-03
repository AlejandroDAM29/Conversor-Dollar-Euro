using System;

namespace Clases
{
    class Program
    {
        /*En este programa vamos a ver cómo calcular área de un 
         triángulo, utilizando una clase aparte.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una cantidad de euros para saber a cuántos dólares equivalen: ");
            double dolares = double.Parse(Console.ReadLine());

            convertor conversion1 = new convertor();
            Console.WriteLine($"Tienes {conversion1.ConversionDolarEuro(dolares)} dolares");

            Console.WriteLine("UPS! la moneda del euro ha fluctuado... Por favor, introduce el nuevo valor del euro");
            double fluctuacion = double.Parse(Console.ReadLine());
            conversion1.setEuro(fluctuacion);
            Console.WriteLine($"Con la nueva fluctuacion, tienes {conversion1.ConversionDolarEuro(dolares)} dolares");
        }
    }

    class convertor
    {
        private double euro = 1.12;

        public double ConversionDolarEuro(double cantidad)
        {
            return cantidad * euro;
        }
        public void setEuro (double euro)
        {
            this.euro = euro;
        }
    }

    
    }

