using System;

namespace RetoTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
           estadoDelAgua();
        }

        static void estadoDelAgua()
        {
            double datoRecibido = ingresaDato("Por favor ingrese la temperatura del agua en grados");
            Logica(datoRecibido);

        }

        static double ingresaDato(string menssage)
        {
            System.Console.WriteLine(menssage);
            double dato = Double.Parse(Console.ReadLine());
            return dato;
        }

        static void Logica (double grados)
        {
            if (grados <= 0)
            {
                System.Console.WriteLine("El agua esta en estado solido");
            }
            else
            {
                if(grados < 100)
                {
                    System.Console.WriteLine("El agua esta en estado liquido");
                } 
                else
                {
                        System.Console.WriteLine("El agua esta en estado gaseoso");
                }
            }

        }

    }
}
