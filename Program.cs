using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var bands = new List<string>();
            bands.Add("ACDC");
            bands.Add("Queen");
            bands.Add("Aerosmith");
            bands.Add("Iron Maiden");
            bands.Add("Megadeth");
            bands.Add("Metallica");
            bands.Add("Creen");
            bands.Add("Oasis");
            bands.Add("Abba");
            bands.Add("Blur");
            var newBands = (from p in bands
                            select p).FirstOrDefault();

            var newBands2 = (from p in bands
                             select p).Last();

            var tenthBand = bands.ElementAt(9);


            var numbers = new List<int>();
            numbers.Add(5);
            numbers.Add(4);
            numbers.Add(1);
            numbers.Add(3);
            numbers.Add(9);
            numbers.Add(8);
            numbers.Add(6);
            numbers.Add(7);
            numbers.Add(2);
            numbers.Add(0);

            var oddNumber = numbers.Where(p => p % 2 != 0);
            var numberDescending = oddNumber.OrderByDescending(p => p);
            foreach (int num in numberDescending)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();


            var evenNumber = numbers.Where(p => p % 2 == 0);
            var numberAscending = evenNumber.OrderBy(p => p);
            foreach (int n in numberAscending)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();

            var first = new List<string>();
            first.Add("3");
            first.Add("1");
            first.Add("2");
            first.Add("4");
            first.Add("9");
            first.Add("5");
            first.Add("7");
            first.Add("8");

            var number = (from p in first
                          select Convert.ToInt32(p)).ToList();
            foreach (int n in number)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();
        }
    }
}
