using System;

namespace Zoo.BusinessLogic.Models.Animals
{
    public class Rabbit : Animal, ICanBeGroomed, ISmallAnimal
    {
        private DateTime lastGroomed;

        public Rabbit(DateTime dateOfBirth) : base(dateOfBirth)
        {
        }

        public override void Feed()
        {
            // Console.WriteLine("<Munch, munch>");
            base.Feed();
        }

        public bool Groom()
        {
            lastGroomed = DateTime.Now;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("         Groomed");
            Console.ResetColor();

            return (DateTime.Now - lastGroomed).TotalSeconds > Config.GroomingFrequency;
            
        }

        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return base.ToString() + $"; Last Groomed {lastGroomed}";
            
        }
    }
}