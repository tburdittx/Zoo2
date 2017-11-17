using System;

namespace Zoo.BusinessLogic.Models.Animals
{
    public class Zebra : Animal, ICanBeGroomed, ILargeAnimal
    {
        private DateTime lastGroomed;


        public Zebra(DateTime dateOfBirth) : base(dateOfBirth)
        {
        }

        public bool Groom()
        {
          
            lastGroomed = DateTime.Now;
            return (DateTime.Now - lastGroomed).TotalSeconds > Config.GroomingFrequency;
            
        }

        public override string ToString()
        {
            return base.ToString() + $"; Last Groomed {lastGroomed}";
        }

    }
}