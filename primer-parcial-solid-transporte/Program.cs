using System;
using System.Collections.Generic;

namespace primer_parcial_solid_transporte
{
    class Program
    {
        static void Main(string[] args)
        {

            List<ITransporteAereo> transportes = new List<ITransporteAereo>();

            Avion avion1 = new Avion("AVION 01", 0, 100, 0, 100);
            transportes.Add(avion1);

            Avion avion2 = new Avion("AVION 02", 0, 100, 0, 100);
            transportes.Add(avion2);

            List<ITransporteTerrestre> transportesTerrestres = new List<ITransporteTerrestre>();

            Tren tren1 = new Tren("TREN 01", 0, 100);
            transportesTerrestres.Add(tren1);

            Console.WriteLine("Inicio del viaje :)");

            foreach (ITransporteAereo transporte in transportes)
            {
                transporte.Volar(10);    
            }

            foreach (ITransporteTerrestre transporte in transportes)
            {
                transporte.Acelerar(10);
            }

            Console.WriteLine("Fin del viaje :)");
        }
    }
}
