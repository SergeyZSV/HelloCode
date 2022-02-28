Console.Write("Write Username: ");
string user = Console.ReadLine();

if(user.ToLower() == "masha")
{
    Console.WriteLine("Hooray, thats Masha");
}
else
{
    Console.Write("Hi, ");
    Console.WriteLine(user);
}