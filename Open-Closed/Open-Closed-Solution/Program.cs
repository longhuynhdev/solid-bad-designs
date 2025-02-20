using Open_Closed_Solution;

Console.WriteLine("Choose a language: ");
Console.WriteLine("1. English");
Console.WriteLine("2. Norwegian");
Console.WriteLine("3. Swedish");
Console.WriteLine("4. Vietnamese");

var l = Console.ReadLine();
IGreeting? greeting = null;

switch (l)
{
    case "1":
        greeting = new GreetingEn();
        break;

    case "2":
        greeting = new GreetingNor();
        break;

    case "3":
        greeting = new GreetingSwe();
        break;

    case "4":
        greeting = new GreetingVn();
        break;
}

if (greeting != null)
{
    greeting.SayHi();
}
