using System;

namespace CarExample
{
    internal class Car

        //Finns den en prop på en klass så vill vi att det ska ha ett skönsvärde
    {//field, method, property - fields och methods är nästan som vars och functions. access-modifierare. Accessnivå sätts på medlem eller klass.
        public string RegNo;

        private readonly double fuelConsumption = 0.1; //börjar med liten bokstav eftersom privat.

        private double fuelLevel; //ett fält.        //backingfield
        public double FuelLevel //kontrollerad exponering //En property (som är publik) ///////////////////dataintegritet innebär att tillstånden i data inte kan nå tillstånd som inte kan nås genom legal interaktion med instansen genom dess klass (eller annan klass) metoder. Och data ska aldrig nå implementeringslogiska fel - som negativ mileage på en bil,
        {
            get { return fuelLevel; } //gives field syntax to Program.cs
            set {
                double newLevel = Math.Max(0, value); //negativ bränslenivå är ogiltig //NON THREAD SAFE: fuelLevel = Math.Max(0, value);
                fuelLevel = Math.Min(newLevel, FuelCapacity); //över högsta bränslenivå är ogiltig //properties är till för att skydda internal state (data integrity)
                } //settern har alltid en parameter som heter value (vilket är det som är höger om likhetstecknet??) //Gives fieldsyntax to Program.cs
        }

        public double FuelCapacity { get; private set; } = 105;     //fuelLevel är lika med 105 (istället för att initiera den tidigare // accessnivån ärvs från public i början av deklarationen //
        public double Milage { get; private set; }
        public static double GlobalMileage { get; set; }

        //public double GetFuelLevel()
        //{
        //    return fuelLevel;
        //}

        //public void SetFuelLevel(double level)
        //{
        //    fuelLevel = Math.Max(0, level);
        //}

        //objektorientering ger inkapsling. Vi vill skydda det som sker i klassen.

        public void Drive(double distanceKm) //egentligen en notator för fuel level
        {
            if (distanceKm < 0) //Vi vill ha en datatyp som inte kan ta negativ. Valideringskod börjar.
            {
                distanceKm = 0;
                Console.WriteLine("Negativt avstånd tolkas som noll");
            }

            double maxDistance = fuelLevel / fuelConsumption;

            if (distanceKm > maxDistance)
            {
                distanceKm = maxDistance;
                Console.WriteLine("Bränslet räcker inte så långt.");
            }

        }
            fuelLevel = distanceKm * fuelConsumption; //Försöka berökna hur långt man får köra innan det är soppatorsk
            public double mileage = 0;
            mileage += distanceKm;
            Console.WriteLine("Du körde " + distanceKm + "km");
        

        public void StatusReport()
        {
            Console.WriteLine("Fuel: " + FuelLevel + "/" + fuelCapacity);
            Console.WriteLine("Milage: " + Mileage);
            Console.WriteLine();
            Console.WriteLine("RegNo: " + RegNo);
        }
    }
}
