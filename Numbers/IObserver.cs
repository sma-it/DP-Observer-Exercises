using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    internal interface IObserver
    {
        void OnNewNumber(int number);
        void Unsubscribe();
    }
}
