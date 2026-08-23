// este es un comentario

using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

Console.WriteLine("Hello, World!");
Console.WriteLine("This is a sample C# program.");
Console.WriteLine($"Current Date and Time: {DateTime.Now}");
Console.WriteLine($"Plataform: {Environment.OSVersion}");
Console.WriteLine($".NET Version: {Environment.Version}");
Console.WriteLine($"Assembly Version: {version}");