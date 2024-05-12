// See https://aka.ms/new-console-template for more information
if (args.Length < 2)
{
    Console.WriteLine("Not enough arguments.");
    Environment.Exit(1);
}

var path = args[0];
var name = args[1];

var dirs = Directory.EnumerateFiles(path, $"*{name}*", SearchOption.AllDirectories);
foreach(var d in dirs)
{
    Console.WriteLine(d);
}
