using System;
using System.Collections;

namespace PII_Herencia
{
    public class Conductor: Usuario
    {
        public string Biografia {get; set;}

        public string Matricula {get; set;}

        public Conductor(string nombre, string apellido, int cedula, string foto, string biografia, string matricula) : base(nombre, apellido, cedula, foto)
        {
            this.Biografia = biografia;
            this.Matricula = matricula;
        }

        public override void Calificar(int c)
        {
            this.calificaciones.Add(c);
        }

        public override string MensajePost()
        {
            return "Bienvenido al nuevo conductor " + this.Nombre + " " + this.Apellido + "!!!" + "\n" + "Bio:" + "\n" + this.Biografia;
        }
    }
}