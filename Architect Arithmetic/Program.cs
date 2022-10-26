using System;

namespace ArchitectArithmetic
{
    class Program
    { //haven't done the calculations for other locations
        public static void Main(string[] args)
        {
            Console.WriteLine("Do you want the cost for Teotihuacan, Taj Mahal or Great Mosque of Mecca?");
            string location = Console.ReadLine();
            double cost = Calculation(location);
            Console.WriteLine($"The flooring cost of {location} is {cost}.");


        }

        static double Calculation(string location)
        {
            switch (location)
            {
                case "Teotihuacan":
                    double totalArea = Triangle(750, 500) + Rectangle(2500, 1500) + 0.5 * Circle(375);
                    double cost = totalArea * 180;
                    cost = Math.Round(cost, 2);
                    return cost;
                case "Taj Mahal":
                    totalArea = 1;
                    cost = totalArea * 180;
                    cost = Math.Round(cost, 2);
                    return cost;
                case "Great Mosque of Mecca":
                    totalArea = 1;
                    cost = totalArea * 180;
                    cost = Math.Round(cost, 2);
                    return cost;
                default:
                    return cost = 0;
            }
        }

        static double Rectangle(double length, double width)
        {
            return length * width;
        }

        static double Circle(double radius)
        {
            return (Math.PI * (Math.Pow(radius, 2)));
        }

        static double Triangle(double bottom, double height)
        {
            return 0.5 * bottom * height;
        }
    }
}
