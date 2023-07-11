using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Lab09
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = File.ReadAllText("C:\\Users\\user\\source\\repos\\Lab9\\Lab9\\data.json");

            var data = JsonConvert.DeserializeObject<Root>(json);

            Console.WriteLine("Question 1:");
            foreach (var feature in data.Features)
            {
                Console.WriteLine(feature.Properties.Neighborhood);
            }
            Console.WriteLine($"Final Total: {data.Features.Count} neighborhoods");

            Console.WriteLine("\nQuestion 2:");
            var neighborhoodsWithNames = data.Features.FindAll(feature => !string.IsNullOrEmpty(feature.Properties.Neighborhood));
            foreach (var feature in neighborhoodsWithNames)
            {
                Console.WriteLine(feature.Properties.Neighborhood);
            }
            Console.WriteLine($"Final Total: {neighborhoodsWithNames.Count} neighborhoods");

            Console.WriteLine("\nQuestion 3:");
            var uniqueNeighborhoods = new List<string>();
            foreach (var feature in neighborhoodsWithNames)
            {
                if (!uniqueNeighborhoods.Contains(feature.Properties.Neighborhood))
                {
                    uniqueNeighborhoods.Add(feature.Properties.Neighborhood);
                }
            }
            foreach (var neighborhood in uniqueNeighborhoods)
            {
                Console.WriteLine(neighborhood);
            }
            Console.WriteLine($"Final Total: {uniqueNeighborhoods.Count} neighborhoods");

            Console.WriteLine("\nQuestion 4:");
            var consolidatedNeighborhoods = new List<string>();
            foreach (var feature in data.Features)
            {
                if (!string.IsNullOrEmpty(feature.Properties.Neighborhood) && !consolidatedNeighborhoods.Contains(feature.Properties.Neighborhood))
                {
                    consolidatedNeighborhoods.Add(feature.Properties.Neighborhood);
                    Console.WriteLine(feature.Properties.Neighborhood);
                }
            }
            Console.WriteLine($"Final Total: {consolidatedNeighborhoods.Count} neighborhoods");

            Console.WriteLine("\nQuestion 5 (using LINQ Query syntax):");
            var neighborhoodsQuerySyntax = from feature in data.Features
                                           where !string.IsNullOrEmpty(feature.Properties.Neighborhood)
                                           select feature.Properties.Neighborhood;

            foreach (var neighborhood in neighborhoodsQuerySyntax)
            {
                Console.WriteLine(neighborhood);
            }
            Console.WriteLine($"Final Total: {neighborhoodsQuerySyntax.Count()} neighborhoods");

            Console.ReadLine();
        }
    }

    public class Properties
    {
        public string Neighborhood { get; set; }
    }

    public class Geometry
    {
        public List<double> Coordinates { get; set; }
    }

    public class Feature
    {
        public Properties Properties { get; set; }
        public Geometry Geometry { get; set; }
    }

    public class Root
    {
        public List<Feature> Features { get; set; }
    }
}
