using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    internal class Car
    {
        public Car() {
        }

        public Car(int year, string make, string model, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            IsDriveable = isDriveable;
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string HonkNoise { get; set; }
        public string EngineNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string EngineNoise) {
            Console.WriteLine(EngineNoise);
        }

        public void MakeHonkNoise(string HonkNoise)
        {
            Console.WriteLine(HonkNoise);
        }
    }
}
