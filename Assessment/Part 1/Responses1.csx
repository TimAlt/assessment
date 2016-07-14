using System;

//Int, Boolean, String, Double, Decimal

var i = 4;
var b = true;
var s = "string";
var dbl = 4.1;
var dec = 4.5m;
var politicians = new[] { "Donald Trump", "Hillary Clinton", "Gary Johnson" };

string Combiner(string partOne, string partTwo)
{
  return $"{partOne} {partTwo}";
}

Console.WriteLine(Combiner(s, i.ToString()));

foreach (string person in politicians)
{
  Console.WriteLine(person);
}