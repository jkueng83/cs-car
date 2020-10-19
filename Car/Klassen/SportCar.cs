using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Car.Klassen
{
    class SportCar : Car
    {

        public SportCar(String brand, String type, int horsePower, String color) : base(brand, type, horsePower, color)
        {

        }

        //protected override void WriteCarData()
      //  {
      //      Console.WriteLine("I am a supercar");
      //  }
    }
}
