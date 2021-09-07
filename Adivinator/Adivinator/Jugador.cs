using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivinator
{
    class Jugador
    {
        private string nombre;
        private string direccion;
        private int telefono;
        private int numeroDeVecesAdivinados;
        //holaaaa
        public Jugador(string nombre, string direccion, int telefono)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            numeroDeVecesAdivinados = 0;
        }

        public void Mostrar()
        {
            Console.WriteLine(nombre + " " + direccion + " " + telefono);
        }

        public (string nombre, string direccion, int telefono) GetInfoJugador()
        {
            (string nombre, string direccion, int telefono) = (this.nombre, this.direccion, this.telefono);
            return (nombre, direccion, telefono);
        }




    }
}
