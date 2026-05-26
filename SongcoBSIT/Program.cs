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

        static void Main(string[] args)
        {
            CarbonFootprint["Car Commute"] = 25.5;
            CarbonFootprint["Daily Electricity Usage"] = 43.3;
            CarbonFootprint["Daily Waste Disposal"] = 32.4;

            EcoActivities.Push("Recycling");
            EcoActivities.Push("Biking to School");
            EcoActivities.Push("Planting Plants in Garden");

            Console.WriteLine("=== Carbon Emmisions ===");
            foreach (var item in CarbonFootprint)
            {
                Console.WriteLine($"{item.Key}: {item.Value} KG in CO2");
            }

            Console.WriteLine();
            Console.WriteLine("=== Recent Eco Activities ===");
            foreach (var item in EcoActivities)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
