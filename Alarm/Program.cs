// See https://aka.ms/new-console-template for more informati
//

// the objects
var alarm1 = new Alarm.MyAlarm();

var dog = new Alarm.Dog();
var fritz = new Alarm.Fritz();
var gordon = new Alarm.Gordon();

// the action
void SoundAlarm()
{
    alarm1.Beep();
}


// the program
var menu = new SMUtils.Menu();

menu.AddOption('1', "Sound Alarm", SoundAlarm);
menu.Start();
