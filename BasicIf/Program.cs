
//bool isComplete = false;

//if (isComplete)
//{
//    Console.WriteLine("True");
//}
//else
//{
//    Console.WriteLine("False");
//}

Console.Write("What is your name: ");
string? firstName = Console.ReadLine();

if (firstName.ToLower() == "mohammad")
{
    Console.WriteLine("Hello Mr. Jabir");
}
else
{
    Console.WriteLine($"Hello {firstName}");
}
