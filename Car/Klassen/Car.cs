using System;
using System.Collections.Generic;
using System.Text;

namespace Car.Klassen
{
    class Car
    {


        private String brand;
        private String type;
        private int horsePower;
        private String color;

        public Car(   String brand, String type,int horsePower,String color)
        {
            this.brand = brand;
            this.type = type;
            this.horsePower = horsePower;
            this.color = color;
        }

        public String Brand
        {
            get { return this.brand; }
            set { this.brand = value; }


        }

        public String Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public int HorsePower
        {
            get { return this.horsePower; }
            set { this.horsePower = value; }
        }

        public String Color
        {
            get { return this.color; }
            set { this.color = value; }
        }


        protected virtual void WriteCarData()
        {
            Console.WriteLine("Autohersteller: " + this.brand);
            Console.WriteLine("Autotype: " + this.type);
            Console.WriteLine("Autofarbe: " + this.color);
            if (this.horsePower > 0)
            {
                Console.WriteLine("Leistung: " + this.horsePower + " PS");
            }
            else
            {
                Console.WriteLine("Leistung: " +"___"+ " PS");
            }
           
        }

        public override string ToString()
        {
            WriteCarData();
            return base.ToString();
        }
    }
}
