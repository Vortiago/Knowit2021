// See https://aka.ms/new-console-template for more information
var input = String.Empty;
using (var streamReader = new StreamReader("Inputs/day1.txt")) {
    input = streamReader.ReadToEnd();
}

var day = new Days.Day1(input);
Console.WriteLine(day.ParseBook().Sum());