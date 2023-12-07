using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Car
    {
        private string Brand;
        private int Year;
        private float Price;

       //constructor
        public Car(string brand, int year, float price)
        {
            Brand = brand;
            Year = year;
            Price = price;
        }
        //method
        public void output()
        {
            Console.WriteLine($"The brand of car is {Brand}, it is launched at {Year} AD and it's price is {Price}.");
        }
    }
}