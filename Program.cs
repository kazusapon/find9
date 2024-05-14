// See https://aka.ms/new-console-template for more information
if (args.Length < 2)
{
    Console.WriteLine("Not enough arguments.");
    Environment.Exit(1);
}

var path = args[0];
var keywords = args.Skip(1).Select(x => x.ToLower()).ToList();

if (!Directory.Exists(path))
{
    Console.WriteLine("Directory path does not exist.");
    Environment.Exit(1);
} 

var files = Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories)
            .Where(f => File.Exists(f))
            .Where(f => keywords.TrueForAll(x => f.ToLower().Contains(x)))
            .Select(f => new FileInfo(f))
            .ToArray();

foreach (var file in files)
{
    Console.WriteLine(file.FullName);
}
