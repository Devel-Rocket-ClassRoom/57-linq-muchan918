using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

List<Product> products = new List<Product>
{
    new Product("Laptop", "Electronics", 1200),
    new Product("Mouse", "Electronics", 25),
    new Product("Keyboard", "Electronics", 75),
    new Product("Shirt", "Clothing", 50),
    new Product("Pants", "Clothing", 100),
    new Product("Desk", "Furniture", 250),
    new Product("Chair", "Furniture", 150),
    new Product("Monitor", "Electronics", 300)
};

Console.WriteLine("=== 문제 1: 가격 100 이상 ===");
var query1 = products
    .Where(p => p.Price >= 100)
    .Select(p => p.Name);
foreach(var product in query1)
{
    Console.WriteLine(product);
}
Console.WriteLine();

Console.WriteLine("=== 문제 2: Electronics 카테고리 ===");
var query2 = products
    .Where(p => p.Category == "Electronics")
    .Select(p => $"{p.Name} - {p.Category} - {p.Price}원");
foreach (var product in query2)
{
    Console.WriteLine(product);
}
Console.WriteLine();

Console.WriteLine("=== 문제 3: 이름순 정렬 ===");
var query3 = products
    .OrderBy(p => p.Name)
    .Select(p => p.Name);
foreach (var product in query3)
{
    Console.WriteLine(product);
}
Console.WriteLine();

Console.WriteLine("=== 문제 4: 평균 가격 ===");
var query4 = products
    .Average(p => p.Price);
Console.WriteLine($"{query4}원");
Console.WriteLine();

Console.WriteLine("=== 문제 5: 가장 저렴한 상품 ===");
var query5 = products
    .OrderBy(p => p.Price)
    .First();
Console.WriteLine($"{query5.Name} - {query5.Price}원");
Console.WriteLine();

Console.WriteLine("=== 문제 6: 가장 비싼 상품 ===");
var query6 = products
    .OrderByDescending(p => p.Price)
    .First();
Console.WriteLine($"{query6.Name} - {query6.Price}원");
Console.WriteLine();

Console.WriteLine("=== 문제 7: Electronics 평균 가격 ===");
var query7 = products
    .Where(p=>p.Category == "Electronics")
    .Average(p=>p.Price);
Console.WriteLine($"{query7}원");
Console.WriteLine();

Console.WriteLine("=== 문제 8: 'o' 포함 상품 (대문자) ===");
var query8 = products
    .Where(p => p.Name.Contains("o"))
    .Select(p => p.Name.ToUpper());
foreach (var product in query8)
{
    Console.WriteLine(product);
}
Console.WriteLine();

Console.WriteLine("=== 문제 9: Clothing 역순 ===");
var query9 = products
    .Where(p => p.Category == "Clothing")
    .Select(p => p.Name);
foreach (var product in query9)
{
    Console.WriteLine(product);
}
Console.WriteLine();

Console.WriteLine("=== 문제 10: 가격 50~300, 복합 정렬 ===");
var query10 = products
    .Where(p => p.Price >= 50 && p.Price <= 300)
    .OrderBy(p => p.Price)
    .Select(p => $"{p.Name} - {p.Price}원");
foreach (var product in query10)
{
    Console.WriteLine(product);
}