using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Encapsulation
{
    public class Gallery:Car
    {

        
        
        public Car[] cars= new Car[0];
       

        public void AddCars(Car car)
        {
            Array.Resize(ref cars, cars.Length + 1);
            cars[cars.Length - 1] = car;

            
        }
        public void ShowAllCars()
        {
            foreach (var c in cars) {
                Console.WriteLine($"Id: {c.Id}, Name: {c.Name}, Speed: {c.Speed}, CarCode: {c.CarCode}");
              
            }
        }
        public Car[] GetAllCars()
        {
            return cars;
        }

        public Car GetCarById(int id)
        {
            foreach (var c in cars)
            {
                if (c.Id == id)
                {
                    return c;
                }
            }
            return null;
        }
       public Car FindCarByCarCode(string carCode)
        {
            foreach (var c in cars)
            {
                if (c.CarCode==carCode)
                {
                    return c;
                }
            }
            return null;
        }

        public Car[] FindCarsBySpeedInterval(double maxSpeed, double minSpeed)
        {

            Car[] filteredCars = new Car[0]; 
            

            
            foreach (var car in cars)
            {
                if (car.Speed >= minSpeed && car.Speed <= maxSpeed)
                {
                    
                 Array.Resize(ref filteredCars, filteredCars.Length+1);
                    filteredCars[filteredCars.Length-1] = car;
                }
            }

           
            return filteredCars;
        }
        public Gallery(int id, string name, double speed):base(id,name,speed)
        {
            Id = id;
            Name = name;
            cars = new Car[0]; 
        }







    }
}
