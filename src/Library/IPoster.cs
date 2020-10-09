using System;
using System.Collections;

namespace PII_Herencia
{
    /*
        Creamos la interface IPoster para poder hacer que nuestro programa pueda crecer y expandirse a postear en otras plataformas
        además de twitter.
    */
    public interface IPoster
    {
        void Add(Usuario usuario);
    }
}