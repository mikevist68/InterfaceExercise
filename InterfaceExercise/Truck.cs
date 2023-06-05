using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {

        public Truck() 
        {
        
        }

        public double EngineSize { get; set; } = 6.0;
        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "Lariat";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Built Ford tough.";
        public bool HasChangedGears { get; set; }

        public bool HasFourWheelDrive { get; set; } = true;
        public string Logo { get; set; }

        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($" 4 wheel drive {GetType().Name} now driving forward");
            }
            else 
            {
                Console.WriteLine($"{GetType().Name} now driving forward");
            }    
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
