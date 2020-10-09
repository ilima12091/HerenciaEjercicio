using System;
using System.Collections.Generic;

namespace PII_Herencia
{
    public class UcuRideShare
    {
        public List<Usuario> Usuarios {get; set;}

        public UcuRideShare()
        {
            Usuarios = new List<Usuario>();
        }

        public void Add(Usuario usuario)
        {
            Usuarios.Add(usuario);
            TwitterPoster TWPoster = new TwitterPoster();
            TWPoster.Add(usuario);
        }
    }
}