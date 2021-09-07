using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivinator
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Ejecutar();
            Console.ReadKey();

        }

        public void Ejecutar()
        {
            int[] lista;

            Console.Write("Cuantos jugadores? ");
            int numJugadores = Int32.Parse(Console.ReadLine());

            Mesa jugadores = new Mesa(numJugadores);

            jugadores.Incribir();
            jugadores.MostrarJugadores();
            

            

        }

    }
}
