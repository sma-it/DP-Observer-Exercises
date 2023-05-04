using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm
{
    internal class FancyAlarm : IAlarm
    {
        public event IAlarm.OnBeepHandler? OnBeep;

        public void Beep()
        {
            Console.WriteLine("Alarm says B.E.E.P.!");
            OnBeep?.Invoke();
        }
    }
}
