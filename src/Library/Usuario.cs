using System;
using System.Collections.Generic;

namespace PII_Herencia
{
    /*
        La clase usuario es abstract porque decidimos que algunos métodos que tiene deberían ser implementados por
        las clases que hereden de ella, ya que la forma de calificar puede ser distinta para un conductor o un pasajero.
    */
    public abstract class Usuario
    {
        protected List<int> calificaciones;
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public int Cedula {get; set;}
        public string Foto {get; set;}
        public int Calificacion {
            get {
                int resultado = 0;
                foreach(int c in calificaciones)
                {
                    resultado += c;
                }
                return resultado / calificaciones.Count;
            }
        }

        public Usuario(string nombre, string apellido, int cedula, string foto)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cedula = cedula;
            this.Foto = foto;
        }

        public abstract void Calificar (int c);

        public abstract string MensajePost();
    }
}