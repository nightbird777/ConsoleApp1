





Console.WriteLine("Welcome to the movie palace!");

do
{
    string result;

    Console.WriteLine("enter your Name: ");
    string name = Console.ReadLine();
    Console.WriteLine("enter your age");
    int age = Convert.ToInt32(Console.ReadLine());

    if (age > 0 && age < 17)
    {
        Console.WriteLine("Hello " + name + " You are Minor!");
    }
    else if (age > 18 && age <= 61)
    {
        Console.WriteLine("Hello " + name + " You are Adult!");
    }
    else
    {
        Console.WriteLine("Hello " + name + " You are Old enough!");
    }

    Console.WriteLine("want to verify again? (Y/N)");
    result = Console.ReadLine();
    result = result.ToUpper();

    if(result == "Y")
    {
        Console.WriteLine("");
    }
    else
    {
        Console.WriteLine("");
    }

    Console.ReadLine();
}while(true);