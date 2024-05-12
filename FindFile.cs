using System.IO;

class FindFile
{
    private string _path;

    private string _name;

    public FindFile(string path, string name)
    {
        this._path = path;
        this._name = name;
    }

    public void Find()
    {
        var dirs = Directory.EnumerateFiles(_path, $"*{_name}*", SearchOption.AllDirectories);
        foreach(var d in dirs)
        {
            Console.WriteLine(d);
        }
    }
}
