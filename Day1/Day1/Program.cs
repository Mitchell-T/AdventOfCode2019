using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            // SETUP
            List<int> input = new List<int>();
            input = GetInput();
            int fuelRequired = 0;


            // PART 1
            foreach(int mass in input)
            {
                // Mass divided by 3 > round down > subtract 2
                int fuelRequiredForMass = mass;
                fuelRequiredForMass /= 3;
                fuelRequiredForMass -= 2;
                // Floor not needed because we are using ints
                fuelRequired += fuelRequiredForMass;

                int newFuel = fuelRequiredForMass;
            }
            Console.WriteLine("Part 1 flag: " + fuelRequired);



            // PART 2
            fuelRequired = 0;
            foreach (int mass in input)
            {
                // Mass divided by 3 > round down > subtract 2
                int fuelRequiredForMass = mass;
                fuelRequiredForMass /= 3;
                fuelRequiredForMass -= 2;
                // Floor not needed because we are using ints
                fuelRequired += fuelRequiredForMass;

                int newFuel = fuelRequiredForMass;
                while (true)
                {
                    newFuel = (newFuel / 3) - 2;
                    if (newFuel > 0)
                    {
                        fuelRequired += newFuel;
                    }
                    else
                    {
                        break;
                    }
                }

            }

            Console.WriteLine("Part 2 flag: " + fuelRequired);
            Console.ReadLine();
        }

        static List<int> GetInput()
        {
            List<int> tempInput = new List<int>();
            StreamReader inputFile = new StreamReader(@"../../../Day1/Input.txt");
            string line;
            while((line = inputFile.ReadLine()) != null)
            {
                tempInput.Add(Int32.Parse(line));
            }

            return tempInput;
        } 


    }
}