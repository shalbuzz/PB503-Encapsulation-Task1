namespace Encapsulation
    
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Gallery gallery = new Gallery(1, "Luxury Cars",500);

            // Car obyektləri yaratmaq
            Car car1 = new Car(1, "Lamborghini", 320);
            Car car2 = new Car(2, "Maserati", 280);
            Car car3 = new Car(3, "Ferrari", 310);

            // Avtomobilləri Gallery'ə əlavə etmək
            gallery.AddCars(car1);
            gallery.AddCars(car2);
            gallery.AddCars(car3);

            // Bütün avtomobilləri göstərmək
            Console.WriteLine("All Cars in Gallery:");
             gallery.ShowAllCars();
            
            

            // GetAllCars metodunu çağırmaq
            Console.WriteLine("\nAll Cars (from GetAllCars method):");
            var allCars = gallery.GetAllCars();
            foreach (var car in allCars)
            {
                Console.WriteLine(car.Name);
            }

            // FindCarById metodunu yoxlamaq
            Console.WriteLine("\nFind Car by ID :");
            var foundCarById = gallery.GetCarById(1);
            if (foundCarById != null)
            {
                Console.WriteLine($"Found: {foundCarById.Name}");
            }
            else
            {   
                Console.WriteLine("Car not found!");
            }

            // FindCarByCarCode metodunu yoxlamaq
            Console.WriteLine("\nFind Car by CarCode :");
            var foundCarByCode = gallery.FindCarByCarCode("LA1001");
            if (foundCarByCode != null)
            {
                Console.WriteLine($"Found: {foundCarByCode.Name}");
            }
            else
            {
                Console.WriteLine("Car not found!");
            }

            // FindCarsBySpeedInterval metodunu yoxlamaq
            Console.WriteLine("\nFind Cars by Speed :");
            var carsInSpeedRange = gallery.FindCarsBySpeedInterval(350.3, 300.4);
            foreach (var c in carsInSpeedRange)
            {
                Console.WriteLine($"Found: {c.Name}, Speed: {c.Speed}, CarCode: {c.CarCode}");
            }
        }
    }
}