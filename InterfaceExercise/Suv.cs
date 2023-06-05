using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Suv : IVehicle, ICompany
    {
        public int SeatCount { get; set; } = 6;
        public string Horn { get; set; } = "honk honk";
        public string CompanyName { get; set; }
        public string Motto { get; set; }
        public double EngineSize { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool HasChangedGears { get; set; }
        public string Logo { get; set; }

        public void ChangeGears(bool isChanged)
        {
            throw new NotImplementedException();
        }

        public void Drive()
        {
            Console.WriteLine("Were driving forward.");
        }

        public void Park()
        {
            throw new NotImplementedException();
        }

        public void Reverse()
        {
            throw new NotImplementedException();
        }
    }
}
