using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        //properties
        public string Model { get; set; }
        public string Make { get; set; }
        public double Year { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise()
        {
            if ("RRMmmmrrrr" == EngineNoise)
            { 
                Console.WriteLine("This Car can go!.");
            }
            else if ("VROOM" == EngineNoise)
                        {
                Console.WriteLine("This car FlYS.");
            }

            else if ("Brap" == EngineNoise)
            {
                Console.WriteLine("This Car Makes some Noise.");
            }
            else
            {

            }
        }

        public void MakeHonkNoise()
        {
            if ("Beep" == HonkNoise)
            {
                Console.WriteLine("It Beeps for sure.");
            }
            else if ("Boop" == HonkNoise)
            {
                Console.WriteLine("For some reason this one Boops, Kinda weird.");
            }
            else if ("Beep Bop" == HonkNoise)
            {
                Console.WriteLine("I'm not really sure but it definitely drives.");

            }
            else 
            {

            }
        }



    }
}
