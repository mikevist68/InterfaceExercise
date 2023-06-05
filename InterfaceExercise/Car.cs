using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle , ICompany
    {

        public Car() 
        {
            
        }
        // below are properties
        public double EngineSize { get; set; } = 4.6;
        public string Make { get; set; } = "Camry";
        public string Model { get; set; } = "SE";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Toyota";
        public string Motto { get; set; } = "There very reliable";
        public bool HasChangedGears { get; set; }
        public string Logo { get; set; }

        public void Drive() 
        {
            Console.WriteLine($"{GetType().Name} now driving forward");
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing");
                HasChangedGears = false;
            }
            else
            { 
                Console.WriteLine("Cant reverse until we change gears.");
            
            }     
        }

        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now parked");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Cant park until we change gears.");

            }

        }

        public void ChangeGears(bool isChanged) 
        {
            HasChangedGears = isChanged;    
        }
    }
}
