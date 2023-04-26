using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    internal class Generator
    {
        public int LastNumber { get; set; }
        private Random random = new Random();

        public void CreateNewNumber()
        {
            LastNumber = random.Next(10);
            Console.WriteLine("Generator creates a " + LastNumber);
        }
    }
}
