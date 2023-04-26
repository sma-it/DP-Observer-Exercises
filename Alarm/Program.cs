// See https://aka.ms/new-console-template for more informati
//

// the objects
var alarm1 = new Alarm.MyAlarm();
var alarm2 = new Alarm.FancyAlarm();

var dog = new Alarm.Dog(alarm1);
var fritz = new Alarm.Fritz(alarm2);
var gordon = new Alarm.Gordon(alarm2);

// the action
void SoundAlarm()
{
    alarm1.Beep();
}

void SoundAlarm2()
{
    alarm2.Beep();
}

void AddDog()
{
    alarm2.AddListener(dog);
}

void RemoveDog()
{
    alarm2.RemoveListener(dog);
}


// the program
var menu = new SMUtils.Menu();

menu.AddOption('1', "Sound Alarm 1", SoundAlarm);
menu.AddOption('2', "Sound Alarm 2", SoundAlarm2);
menu.AddOption('3', "Add Dog", AddDog);
menu.AddOption('4', "Remove Dog", RemoveDog);

menu.Start();
