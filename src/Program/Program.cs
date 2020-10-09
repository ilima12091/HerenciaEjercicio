using System;
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
        }
    }
}
