using System;

namespace ejercicio1dejoaquinzampelunghe
{
    class Program
    {
        static void Main(string[] args)
        {
			double distancia;
			double distanciakms;
			double tiempo;
			double velocidad;
			Console.Write($"ingrese la velocidad constante a la que se desplaza el movil:");
			velocidad = Double.Parse(Console.ReadLine());
			Console.Write($"indique durante cuanto tiempo lo hace:");
			tiempo = Double.Parse(Console.ReadLine());
			distancia = velocidad * tiempo;
			Console.WriteLine($"la distancia que recorre el móvil es {distancia} m/s:");
			distanciakms = distancia / 1000;
			Console.WriteLine($"la distancia recorrida en m/s, en kms equivale a {distanciakms} kms:");
			Console.WriteLine();

			Console.ReadLine();
		}

	}

}


        
    

