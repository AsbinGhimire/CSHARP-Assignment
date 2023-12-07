using System;

namespace Exercise1
{
    internal class Program
    {
        //creating instance
        static void Main()
        {
            Car theCar = new Car("mclaren", 2001, 1890000.99f);
            theCar.output();
        }
    }
}