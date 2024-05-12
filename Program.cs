// See https://aka.ms/new-console-template for more information
if (args.Length < 2)
{
    Console.WriteLine("Not enough arguments.");
    Environment.Exit(1);
}

var path = args[0];
var keywords = args.Skip(1).ToList();

var files = Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories)
            .Where(f => File.Exists(f))
            .Where(f => keywords.TrueForAll(x => f.ToLower().Contains(x.ToLower())))
            .ToArray();

foreach (var file in files)
{
    Console.WriteLine(file);
}
