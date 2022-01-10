// See https://aka.ms/new-console-template for more information
String test = "Hello, can you C#? y/n";
Console.WriteLine(test);
string test2 = "";
test2 = Console.ReadLine();
if (test2.ToLower() == "y" || test2.ToLower() == "n")
{
    Console.WriteLine("Input accepted");
}
else {
    Console.WriteLine("Input rejected");
}