using System;
namespace CarExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car(RegNo: "ABC127") //myCar är av typen Car. <<<<<<<Car car1 = new Car(regNo: "ABC127") { FuelLevel = 10 }>>>>>>>> (object initializor)
            {
                FuelLevel = -10,
                Mileage = 100
            };                                            //car1.RegNo = "ABC127"; //publika fält skriver vi med stor bokstav

            Car car2 = new Car();            
            car2.RegNo = "XYZ987";

            car1.StatusReport();
            car2.StatusReport();
            Console.WriteLine("Odometer: " + Car.GlobalMileage); //om den inte är skriven till (det är en sträng,  en referenstyp) så kommer den innehålla null, tillskillnad från double.
            Console.WriteLine();

            Console.WriteLine(car1.RegNo.Length);

    
            car1.FuelLevel = 10; //fieldsyntax

            // tanke fullt
            car1.FuelLevel = 10;
            car1.FuelLevel += 100; // + myCar.FuelLevel; ännu tidigare myCarGetFuelLevel(100 + GetFuelLevel())
            car2.FuelLevel += 50;

            /*
            myCar.FuelLevel = myCar.FuelLevel - 60; //Låt oss exponera en metod istället!
            Console.WriteLine(myCar.FuelLevel);
            */

            //kör en massa
            car1.Drive(600);
            car1.Drive(600)
            car2.Drive(100000)


            
            car1.StatusReport();
            car2.StatusReport();

            Console.WriteLine("Odomoeter: " + Car.GlobalMileage);
        }
    }
}
