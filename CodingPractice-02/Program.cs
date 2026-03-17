using System;
using System.Collections.Generic;
using System.Linq;

int[] numbers = { 1, 2, 3, 4, 5 };

int sum = numbers.Sum();
int count = numbers.Count();
double average = numbers.Average();

Console.WriteLine($"합계: {sum}");
Console.WriteLine($"개수: {count}");
Console.WriteLine($"평균: {average}");

numbers = new int[]{ 3, 1, 4, 1, 5, 9, 2, 6 };

int min = numbers.Min();
int max = numbers.Max();

Console.WriteLine($"최솟값: {min}");
Console.WriteLine($"최댓값: {max}");

numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int evenSum = numbers.Where(n => n % 2 == 0).Sum();

int countOver5 = numbers.Count(n => n > 5);

Console.WriteLine($"짝수 합계: {evenSum}");
Console.WriteLine($"5보다 큰 숫자 개수: {countOver5}");

numbers = new int[]{ 10, 20, 30, 40, 50 }
;

int first = numbers.First();
int last = numbers.Last();

Console.WriteLine($"첫 번째: {first}");
Console.WriteLine($"마지막: {last}");

numbers = new int[]{ 1, 2, 3, 4, 5 }
;

// 3보다 큰 첫 번째 숫자
int firstOver3 = numbers.First(n => n > 3);

Console.WriteLine($"3보다 큰 첫 번째: {firstOver3}");

numbers = new int[] { 10, 20, 30, 40, 50 };

// 처음 3개
var firstThree = numbers.Take(3);

// 처음 2개 건너뛰기
var skipTwo = numbers.Skip(2);

Console.WriteLine("처음 3개:");
foreach (var n in firstThree)
{
    Console.Write(n + " ");
}

Console.WriteLine("\n2개 건너뛴 후:");
foreach (var n in skipTwo)
{
    Console.Write(n + " ");
}

numbers = new int[]{ 1, 2, 3, 4, 5 }
;

// 요소가 하나라도 있는지
bool hasAny = numbers.Any();

// 짝수가 하나라도 있는지
bool hasEven = numbers.Any(n => n % 2 == 0);

// 모든 요소가 양수인지
bool allPositive = numbers.All(n => n > 0);

Console.WriteLine($"요소 존재: {hasAny}");
Console.WriteLine($"짝수 존재: {hasEven}");
Console.WriteLine($"모두 양수: {allPositive}");

numbers = new int[]{ 1, 2, 3, 4, 5 }
;

bool has3 = numbers.Contains(3);
bool has10 = numbers.Contains(10);

Console.WriteLine($"3 포함: {has3}");
Console.WriteLine($"10 포함: {has10}");

numbers = new int[]{ 1, 2, 2, 3, 3, 3, 4, 5 };

var distinct = numbers.Distinct();

foreach (var n in distinct)
{
    Console.Write(n + " ");
}
Console.WriteLine();

int[] first1 = { 1, 2, 3 };
int[] second = { 3, 4, 5 };

// 단순 연결 (중복 포함)
var concat = first1.Concat(second);

// 합집합 (중복 제거)
var union = first1.Union(second);

Console.WriteLine("Concat:");
foreach (var n in concat)
{
    Console.Write(n + " ");
}

Console.WriteLine("\nUnion:");
foreach (var n in union)
{
    Console.Write(n + " ");
}

Console.WriteLine();

var numbers1 = new List<int> { 1, 2, 3 };
var query = numbers1.Where(n => n > 1);

numbers1.Add(4);

Console.WriteLine("결과:");
foreach (var n in query)
{
    Console.WriteLine(n);
}

numbers1 = new List<int> { 1, 2, 3 };

// 즉시 실행됨
int count1 = numbers1.Count();

numbers1.Add(4);

Console.WriteLine($"개수: {count1}");

numbers1 = new List<int> { 1, 2, 3 };
var result111 = numbers1.Where(n => n > 1).ToList();

numbers1.Add(4);

Console.WriteLine("결과:");
foreach (var n in result111)
{
    Console.WriteLine(n);
}

var names = new List<string> { "홍길동", "김철수", "이영희" };

var result = names.Select(n => new {Name = n, Length = n.Length});

foreach (var item in result)
{
    Console.WriteLine($"이름: {item.Name}, 길이: {item.Length}");
}

string[] names1 = { "Tom", "Dick", "Harry", "Marry", "Jay" };

count = (from n in names1
             where n.Contains("a")
             select n).Count();
Console.WriteLine($"'a' 포함 이름 개수: {count}");

string firs11t = (from n in names1
                orderby n
                select n).First();

Console.WriteLine($"알파벳 순 첫 번째: {firs11t}");