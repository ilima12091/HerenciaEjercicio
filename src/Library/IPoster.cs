using System;
using System.Collections;

namespace PII_Herencia
{
    public interface IPoster
    {
        void AddConductor(Conductor c);

        void AddPasajero(Pasajero p);
    }
}