using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivinator
{
    class Mesa
    {
        private Jugador[] jugadores;
        private int numeroGenerado;
        private Random r;

        public Mesa(int numJugadores)
        {
            jugadores = new Jugador[numJugadores];

            


            numeroGenerado = 0;
            r = new Random();
        }

        public void GenerarNumero()
        {
            int newNumero = r.Next(1, 51);
            SetValor(newNumero);
        }

        public void Incribir()
        {
            for(int i=0; i < jugadores.Length; i++)
            {
                (string nombre, string direccion, int Telefono) = PedirDatosPersonales();
                jugadores[i] = new Jugador(nombre, direccion, Telefono);

            }
        }


        private (string nombre, string direccion, int telefono) PedirDatosPersonales()
        {
            Console.WriteLine("Constructor Jugador");
            Console.WriteLine("Ingrese los datos del jugador");

            Console.Write("Nombre    :");
            string nombre = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Dirección    :");
            string direccion = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Teléfono    :");
            int Telefono = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            return (nombre, direccion, Telefono);
            

        }


        private void SetValor(int numeroGenerado)
        {
            this.numeroGenerado = numeroGenerado;
        }

        public void MostrarJugadores()
        {
            for(int i = 0; i < jugadores.Length; i++)
            {
                jugadores[i].GetInfoJugador();
            }
        }

        


    }
}
