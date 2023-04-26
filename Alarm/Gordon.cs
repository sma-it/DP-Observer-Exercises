using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm
{
    internal class Gordon : IListener
    {
        private IAlarm? currentAlarm = null;
        public Gordon(IAlarm alarm)
        {
            alarm.AddListener(this);
        }
        public void OnAlarm()
        {
            Console.WriteLine("Gordon gets out of bed.");
        }

        public void StopListening()
        {
            if (currentAlarm != null)
            {
                currentAlarm.RemoveListener(this);
            }
        }
    }
}
