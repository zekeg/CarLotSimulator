using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            //Create Lot
            CarLot lot = new CarLot();

            //Create a seperate class file called Car DONE
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable DONE
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() DONE
            //The methods should take one string parameter: the respective noise property DONE


            //Now that the Car class is created we can instanciate 3 new cars DONE
            Car car1 = new Car();
            lot.Cars.Add(car1);
            CarLot.numberOfCars++;
            Car car2 = new Car();
            lot.Cars.Add(car2);
            CarLot.numberOfCars++;
            Car car3 = new Car();
            lot.Cars.Add(car3);
            CarLot.numberOfCars++;
            //Set the properties for each of the cars DONE
            car1.Year = 2008;
            car2.Year = 2007;
            car3.Year = 2006;

            car1.Make = "Toyota";
            car2.Make = "Mazda";
            car3.Make = "Bentley";

            car1.Model = "Yaris";
            car2.Model = "626";
            car3.Model = "Continental";

            car1.HonkNoise = "Beep!";
            car2.HonkNoise = "Awooga!";
            car3.HonkNoise = "Pardon me, old sport";

            car1.EngineNoise = "Rooom!";
            car2.EngineNoise = "Brooooo!";
            car3.EngineNoise = "Ah yes, let's get to it then";

            car1.IsDriveable = true;
            car2.IsDriveable = true;
            car3.IsDriveable = false;

            //Call each of the methods for each car DONE
            car1.MakeHonkNoise("Breep");
            car1.MakeEngineNoise("Froom");

            car2.MakeHonkNoise("Meeeeep");
            car2.MakeEngineNoise("Grrrrrrom");

            car3.MakeHonkNoise("Ah yes, excuse me");
            car3.MakeEngineNoise("Old sport, I must get going");

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            //(2 methods counting the third way i instantiated the first 3 cars)
            Car car4 = new Car() { Make = "Noyota", Model = "Zaris", Year = 1999, IsDriveable = false };
            lot.Cars.Add(car4);
            CarLot.numberOfCars++;
            Car car5 = new Car(1999, "Soyota", "Borvis", true);
            lot.Cars.Add(car5);
            CarLot.numberOfCars++;
            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            lot.Cars.ForEach(car=>Console.WriteLine($"Make: {car.Make} Model: {car.Model} Year: {car.Year}"));

            //Static Keyword Exercise
            //Creating 3 cars
            Console.WriteLine("Static Keyword Exercise \n\n\n");
            Car car6 = new Car();
            CarLot.numberOfCars++;
            Console.WriteLine($"New car created, number of cars is {CarLot.numberOfCars} (includes previously created cars above)");
            Car car7 = new Car();
            CarLot.numberOfCars++;
            Console.WriteLine($"New car created, number of cars is {CarLot.numberOfCars} (includes previously created cars above)");
            Car car8 = new Car();
            CarLot.numberOfCars++;
            Console.WriteLine($"New car created, number of cars is {CarLot.numberOfCars} (includes previously created cars above)");
        }
    }
}
