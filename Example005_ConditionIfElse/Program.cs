Console.Write("Enter your name, plese: ");
string username = Console.ReadLine();
string result = "";
if (username.ToLower() == "maria")
{
    result = "Hello, beautiful woman!";
}
else
{
    result = "Hello, " +  username + "!";
}
Console.WriteLine(result);