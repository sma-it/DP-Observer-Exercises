using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm
{
    internal interface IAlarm
    {
        delegate void OnBeepHandler();
        event OnBeepHandler? OnBeep;
    }
}
