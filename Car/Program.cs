using Car.Klassen;
using System;



namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {

           
         //   Console.WriteLine("Aufgabe Auto");

            CarConfigurator carConfigurator = new CarConfigurator();

            carConfigurator.configurator();





           // Klassen.Car car = new Klassen.Car();


            

          // WriteInputs("", car);
         
            // user name
         //   string userName = GetUserName();

          //  WriteInputs(userName, car);


            // car type: normal car - sport car

          //  CarType carType = GetCarType();

          //  if(carType == CarType.NormalCar)
          //  {

            //    car = new Klassen.Car();

          //  } else if(carType == CarType.SportCar)
          //  {

            //    car = new SporCarClass();

          //  }

         //   WriteInputs(userName, car);

            // brand
        //    car.Brand = GetBrand();
        //    WriteInputs(userName, car);

            // type
          //  car.Type = GetType();
         //   WriteInputs(userName, car);

            // car color
          //  car.Color = GetCarColor();
         //   WriteInputs(userName, car);

            // car horse power

          //  car.HorsePower = GetHorsePower();

          //  WriteInputs(userName, car);

          //  Console.ReadLine();



        }


        


        public static CarType GetCarType()
        {

            DeleteInputLines();

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

                DeleteInputLines();

            }

            return carType;
        }

        public enum CarType { Unknown = -1 , NormalCar = 1 , SportCar = 2 };

        public static int GetHorsePower()
        {

            DeleteInputLines();
            Console.WriteLine("Bitte geben Sie die Leistung in PS ein:");

            int hp = int.Parse(Console.ReadLine());

            DeleteInputLines();

            return hp;
        }
    

        public static string GetType()
        {
            DeleteInputLines();
            Console.WriteLine("Bitte geben Sie die Type ein:");
            return Console.ReadLine();
        }
        public static string GetBrand()
        {
            DeleteInputLines();
            Console.WriteLine("Bitte geben Sie den Hersteller an:");
            string brand = Console.ReadLine();

            return brand;

        }
        public static string GetCarColor()
        {

            DeleteInputLines();
                   
            Console.WriteLine("Welche Farbe soll das Auto haben?");
            
            string carColor = Console.ReadLine();

            return carColor;
        }

        public static string GetUserName()
        {
            string userName = "";

            Boolean userNameIsOk = false;
            while (!userNameIsOk)
            {
                DeleteInputLines();

                Console.WriteLine("Wie heißen Sie?");
                userName = Console.ReadLine();
                if (userName.Length < 3)
                    Console.WriteLine("Ihr Name ist zu kurz");
                else
                    userNameIsOk = true;
                

            }

            return userName;
        }



        public static void WriteInputs(string userName, Klassen.Car car )
        {
            int line = 2;
            Console.SetCursorPosition(0, line);
           
            Console.WriteLine("Kundenname: " + userName);
                 

            car.ToString();
            
        }


       public static void DeleteInputLines()  {
            int line = 10;
            Console.SetCursorPosition(0, line);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("                                                                                        ");
            }
                     
            Console.SetCursorPosition(0, line);

        }
}
}
