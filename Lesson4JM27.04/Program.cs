
Console.WriteLine("start");

//Console.WriteLine("Write your age please");
//string userAgeText = Console.ReadLine();
//int age = int.Parse(userAgeText);

//if (age >= 18)
//{
//    Console.WriteLine("You are adult.");
//}
//if (age >= 13)
//{
//    Console.WriteLine("You are tennager.");
//}
//else 
//{
//    Console.WriteLine("You are a child.");
//}

Console.WriteLine("Please enter your name");

string name = Console.ReadLine();

if (string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("You did not write you name.");
    Console.WriteLine("Try one more time.");
    name = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(name))
    {
        Console.Write("I will not try anymore");
    }
    else 
    {
        Console.WriteLine($"Your name is:{name}");
    }


}
else 
{
    Console.WriteLine($"Your name is: {name}.");
}






Console.WriteLine("end");
