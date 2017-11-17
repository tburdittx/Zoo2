using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.BusinessLogic.Models.Animals
{
    public class Lion : Animal, ILargeAnimal, ICanBeMucked
    {
        private DateTime lastMucked;
        public Lion(DateTime dateOfBirth) : base(dateOfBirth)
        {
        }

        public bool Muck()
        {
            lastMucked = DateTime.Now;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("                     Mucked");
            Console.ResetColor();
            return (DateTime.Now - lastMucked).TotalSeconds > Config.MuckFrequency;

        }
      
        public override string ToString()
        {
            return base.ToString() + $";                            Last Mucked: {lastMucked}";
        }
    }
}
