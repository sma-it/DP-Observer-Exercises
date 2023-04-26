// See https://aka.ms/new-console-template for more information


// the objects
var generator = new Numbers.Generator();

var parrot = new Numbers.Parrot();
var memory = new Numbers.Memory();
var negationist = new Numbers.Negationist();

// the action
void GenerateNumber()
{
    generator.CreateNewNumber();
}

// the program
var menu = new SMUtils.Menu();

menu.AddOption('1', "Generate Number", GenerateNumber);
menu.Start();
