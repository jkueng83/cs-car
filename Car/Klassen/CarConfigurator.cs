using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


public enum CarType { Unknown = -1, NormalCar = 1, SportCar = 2 };

namespace Car.Klassen
{
    class CarConfigurator
    {
        string userName = "";

        private int conter;

        List<Car> cars ;

        public void configurator()
        {

            cars = new List<Car>();

            Console.WriteLine("Bitte geben Sie ihren Name ein:");
            this.userName = Console.ReadLine();

            Boolean exitProgamm = false;

            while (!exitProgamm)
            {

                string configuratinMode = configurationModes();

                switch (configuratinMode)
                {
                    case "1":
                        Console.WriteLine("Es wird ein neues Auto konfiguriert.");
                        configNewCar();
                        break;

                    case "2":

                        Console.WriteLine("Sie haben folgende Autos konfiguriert:");
                        printAllCars();
                        break;

                    case "9":

                        Console.WriteLine("Das Programm wird beendet.");
                        exitProgamm = true;
                        break;

                    default:
                        break;
                }



            }


        }

        private void printAllCars()
        {

            Console.WriteLine("Anzahl der konfigurierten Autos: " );

            foreach (var car in cars)
            {

                conter++;
                Console.WriteLine(conter);
                car.ToString();


            }
        }

        private void configNewCar()
        {

            CarType carType = GetCarType();

            string brand = GetBrand();

            string type = GetType();

            string color = GetCarColor();

            int hp = GetHorsePower();

            Car car = null;

            if(carType == CarType.NormalCar)
            {
                car = new Car(brand, type, hp, color);
                     
            }else if(carType == CarType.SportCar)
            {
                car = new SportCar(brand,type,hp,color);
            }

            cars.Add(car);


           


        }

        public static int GetHorsePower()
        {
            Console.WriteLine("Bitte geben Sie die Leistung in PS ein:");
            int hp = int.Parse(Console.ReadLine());
            return hp;
        }

        private string GetCarColor()
        {
            Console.WriteLine("Welche Farbe soll das Auto haben?");
            string carColor = Console.ReadLine();
            return carColor;
        }

        private string GetType()
        {
            Console.WriteLine("Bitte geben Sie die Type ein:");
            return Console.ReadLine();
        }

        private string GetBrand()
        {
            
            Console.WriteLine("Bitte geben Sie den Hersteller an:");
            string brand = Console.ReadLine();

            return brand;
        }

        private CarType GetCarType()
        {
            
            CarType carType = CarType.Unknown;

            while (carType == CarType.Unknown)
            {

                Console.WriteLine("Bitte geben Sie die Autotype ein:");
                Console.WriteLine("1 - Normales Auto");
                Console.WriteLine("2 - Sport Auto");

                int carTypeInt = int.Parse(Console.ReadLine());


                if (carTypeInt == 1)
                {
                    carType = CarType.NormalCar;
                }
                else if (carTypeInt == 2)
                {
                    carType = CarType.SportCar;
                }
                else
                {
                    Console.WriteLine("Ihre Angaben sind nicht zulässig.");
                    Console.WriteLine("Bitte machen Sie eine neue Eingabe.");
                }
                                
            }

            return carType;
        }

        private string configurationModes()
        {

            string value = "";

            Boolean inputIsOk = false;

            while (!inputIsOk)
            {

                Console.WriteLine("Hallo " + this.userName + " was möchten Sie machen?");
                Console.WriteLine("1 - ein neuens Auto konfigurieren");
                Console.WriteLine("2 - Konfigurierte Autos drucken");
                Console.WriteLine("9 - Programm beenden.");

                value = Console.ReadLine();

                if (value.Equals("1") || value.Equals("2") || value.Equals("9"))
                {
                    inputIsOk = true;
                }
                else
                {
                    Console.WriteLine("Ihre Eingabe ist nicht nicht möglich, bitte machen Sie eine neue Eingabe");
                }

            }

            return value;

        }

    }
}
