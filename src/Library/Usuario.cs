using System;
using System.Collections;

namespace PII_Herencia
{
    public class Usuario
    {
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public int Cedula {get; set;}
        public string Foto {get; set;}
        public int Calificacion {get; set;}

        public abstract void Calificar (int c);
    }
}