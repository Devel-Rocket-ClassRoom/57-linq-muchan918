using System;
using System.Collections.Generic;
using System.Linq;

int[] numbers = { 1, 2, 3, 4, 5 };

IEnumerable<int> result = numbers.Where(n => n > 3);

foreach(int n in result)
{
    Console.WriteLine(n);
}

string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

IEnumerable<string> filtered = names.Where(n => n.Contains("a"));

foreach(var  n in filtered)
{
    Console.WriteLine(n);
}

string[] names1 = { "Tom", "Dick", "Harry" };

IEnumerable<string> uppercased = names1.Select(n=>n.ToUpper());

foreach (var name in uppercased)
{
    Console.WriteLine(name);
}

string[] colors = { "Red", "Green", "Blue" };

IEnumerable<string> sorted = colors.OrderBy(c => c);

foreach (var c in sorted)
{
    Console.WriteLine(c);
}

int[] numbers1 = { 3, 1, 4, 1, 5, 9, 2, 6 };

var descending = numbers1.OrderByDescending(n => n);

foreach (var n in descending)
{
    Console.Write(n + " ");
}

string[] names2 = { "Tom", "Dick", "Harry", "Mary", "Jay" };

var query = names2
    .Where(n => n.Contains("a"))
    .OrderBy(n => n.Length)
    .Select(n => n.ToUpper());

foreach (var name in query)
{
    Console.WriteLine(name);
}

int[] numbers11 = { 1, 2, 3, 4, 5 };

var query1 = from n in numbers11
            where n % 2 == 0
            select n;

foreach (var n in query1)
{
    Console.WriteLine(n);
}

string[] names111 = { "Tom", "Dick", "Harry", "Mary", "Jay" };


var query111 = from n in names111
            where n.Contains("a")
            orderby n.Length
            select n.ToUpper();

foreach (var name in query111)
{
    Console.WriteLine(name);
}

int[] numbers1111 = { 3, 2, 1, 4, 5 };

var methodResult = numbers1111
    .Where(n => n % 2 == 1)
    .OrderBy(n => n);

var queryResult = from n in numbers1111
                  where n % 2 == 1
                  orderby n
                  select n;

Console.WriteLine("메서드 구문:");
foreach (var n in methodResult)
{
    Console.Write(n + " ");
}

Console.WriteLine("\n쿼리 구문:");
foreach (var n in queryResult)
{
    Console.Write(n + " ");
}