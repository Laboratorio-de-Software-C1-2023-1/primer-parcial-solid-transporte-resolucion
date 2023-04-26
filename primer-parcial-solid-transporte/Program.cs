using System;
using System.Collections.Generic;

namespace primer_parcial_solid_transporte
{
    class Program
    {
        static void Main(string[] args)
        {

            List<ITransporteAereo> transportes = new List<ITransporteAereo>();

            Avion avion1 = new Avion();
            avion1._nombre = "AVION 01";
            avion1._velocidadActual = 0;
            avion1._velocidadMaxima = 100;
            avion1._alturaActual = 0;
            avion1._alturaMaxima = 100;
            transportes.Add(avion1);

            Avion avion2 = new Avion();
            avion2._nombre = "AVION 02";
            avion2._velocidadActual = 0;
            avion2._velocidadMaxima = 100;
            avion2._alturaActual = 0;
            avion2._alturaMaxima = 100;
            transportes.Add(avion2);

            List<ITransporteTerrestre> transportesTerrestres = new List<ITransporteTerrestre>();

            Tren tren1 = new Tren();
            tren1._nombre = "TREN 01";
            tren1._velocidadActual = 0;
            tren1._velocidadMaxima = 100;
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
