using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    internal class Parrot
    {
        public void OnNewNumber(int number)
        {
            Console.WriteLine("Parrot says: " + number);
        }
    }
}
