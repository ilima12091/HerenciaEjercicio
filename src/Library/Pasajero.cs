using System;
using System.Collections;

namespace PII_Herencia
{
    public class Pasajero: Usuario
    {
        public override void Calificar(int c)
        {
            this.calificaciones.Add(c);
        }

        public override string MensajePost()
        {
            return "Bienvenido al nuevo pasajero " + this.Nombre + " " + this.Apellido + "!!!";
        }

        public Pasajero(string nombre, string apellido, int cedula, string foto) : base(nombre, apellido, cedula, foto)
        {

        }
    }
}