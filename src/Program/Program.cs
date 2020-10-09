﻿using System;
using System.Collections;

namespace PII_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario pasajero = new Pasajero("Gonzalo", "Pennino", 12345678, @"gonzalo.jpg");
            Usuario conductor = new Conductor("Eduardo", "Pérez", 12345678, @"edu.png", "Profesor de programación II en la Universidad Católica del Uruguay", "BAT-1234");
            Usuario pool = new Pool("Federico", "Martino", 12345678, @"federico.jpg", "Profesor de programación II en la Universidad Católica del Uruguay", "BAT-4321", 4);
            UcuRideShare rideShare = new UcuRideShare();

            rideShare.Add(pasajero);
            rideShare.Add(conductor);
            rideShare.Add(pool);

            /*
            En éste método deberas mostrar un ejemplo de funcionamiento de tu programa an pseudocódigo. A continuación te 
            planteamos un ejemplo de como hacerlo. Esto no significa que te limites a hacer solamente esto, debes pensar 
            en grande!

            Usuario pasajero1 = nuevo Pasajero()
            Usuario pasajero2 = nuevo Pasajero()
            Usuario pasajero3 = nuevo Pasajero()
            Usuario conductor1 = nuevo Conductor()
            Usuario conductorPool1 = nuevo ConductorPool(maxPasajeros = 3)
            UcuRideShare rideShare = nuevo UcuRideShare()
            
            rideShare.Add(conductor1)
            Se publica en Twitter un nuevo conductor!

            rideShare.Add(conductorPool1)
            Se publica en Twitter un nuevo conductor!
            
            rideShare.Add(pasajero1)
            Se publica en Twitter nuevo registro de pasajero!
            
            rideShare.Add(pasajero2)
            Se publica en Twitter nuevo registro de pasajero!

            rideShare.Add(pasajero3)
            Se publica en Twitter nuevo registro de pasajero!

            */
        }
    }
}
