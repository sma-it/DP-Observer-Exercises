// See https://aka.ms/new-console-template for more information


// the objects
var generator = new Numbers.Generator();

List<Numbers.IObserver> observers = new List<Numbers.IObserver>();
Random random = new Random();

// the action
void GenerateNumber()
{
    generator.CreateNewNumber();
}

void CreateObserver()
{
    int id = random.Next(3);

    switch(id)
    {
        case 0: 
            observers.Add(new Numbers.Parrot(generator));
            Console.WriteLine("Parrot Added");
            break;
        case 1:
            observers.Add(new Numbers.Memory(generator));
            Console.WriteLine("Memory Added");
            break;
        case 2:
            observers.Add(new Numbers.Negationist(generator));
            Console.WriteLine("Negationist Added");
            break;
    }
}

void RemoveLastObserver()
{
    if (observers.Count == 0) return;

    //observers.Last().Unsubscribe();
    observers.Remove(observers.Last());
}

// the program
var menu = new SMUtils.Menu();

menu.AddOption('1', "Generate Number", GenerateNumber);
menu.AddOption('2', "Create Observer", CreateObserver);
menu.AddOption('3', "Remove Last Observer", RemoveLastObserver);

menu.Start();
