using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongcoBSIT
{
    internal class Program
    {
        static Dictionary<string,double> CarbonFootprint = new Dictionary<string,double>();
        static Stack<string> EcoActivities = new Stack<string>();

        static void AddCarbon()
        {
            Console.Write("Add Your Carbon Footprint: ");
            string name = Console.ReadLine();

            Console.Write("Add Your Carbon CO2 in KG: ");
            double value = Convert.ToDouble(Console.ReadLine());

            CarbonFootprint.Add(name, value);
        }

        static void AddEcoActivities()
        {
            Console.Write("Add Your Recent Eco Activity: ");
            string activity = Console.ReadLine();

            EcoActivities.Push(activity);
        }

        static void Main(string[] args)
        {
            bool Loop = true;

            CarbonFootprint["Car Commute"] = 25.5;
            CarbonFootprint["Daily Electricity Usage"] = 43.3;
            CarbonFootprint["Daily Waste Disposal"] = 32.4;

            EcoActivities.Push("Recycling");
            EcoActivities.Push("Biking to School");
            EcoActivities.Push("Planting Plants in Garden");

            while (Loop)
            {
                Console.WriteLine("=== Carbon Emmisions ===");
                foreach (var item in CarbonFootprint)
                {
                    Console.WriteLine($"{item.Key}: {item.Value} KG in CO2");
                }

                Console.WriteLine();
                Console.WriteLine("=== Recent Eco Activities ===");
                int Count = 1;
                foreach (var item in EcoActivities)
                {
                    Console.WriteLine($"[{Count}] {item}");
                    Count++;
                }

                Console.WriteLine();
                Console.WriteLine("== Choose Which to Add");
                Console.WriteLine("[1] Carbon Emmisions");
                Console.WriteLine("[2] Eco Activities");
                Console.Write("Enter Your Choice: ");
                string Choice = Console.ReadLine();

                switch (Choice)
                {
                    case "1":
                        AddCarbon();
                        break;
                    case "2":
                        AddEcoActivities();
                        break;
                    default:
                        Loop = false;
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
