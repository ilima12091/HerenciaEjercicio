using System;
using System.Collections;

namespace PII_Herencia
{
    public class Pool : Conductor
    {
        public int Capacidad {get; set;}

        public Pool(string nombre, string apellido, int cedula, string foto, string biografia, string matricula, int capacidad) : base(nombre, apellido, cedula, foto, biografia, matricula)
        {
            this.Capacidad = capacidad;
        }
    }
}