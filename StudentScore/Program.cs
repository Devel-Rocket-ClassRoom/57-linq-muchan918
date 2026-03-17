using System;
using System.Collections.Generic;
using System.Linq;

List<Student> students = new List<Student>()
{
    new Student("김철수", "수학", 85),
    new Student("김철수", "영어", 78),
    new Student("이영희", "수학", 92),
    new Student("이영희", "영어", 88),
    new Student("박민수", "수학", 76),
    new Student("박민수", "영어", 82),
    new Student("정지은", "수학", 95),
    new Student("정지은", "영어", 91)
};

Console.WriteLine("=== 문제 1: 85점 이상 ===");
var query1 = students
    .Where(s => s.Score >= 85)
    .Select(s => $"{s.Name} - {s.Subject}: {s.Score}점");
foreach (var student in query1)
{
    Console.WriteLine(student); 
}
Console.WriteLine();

Console.WriteLine("=== 문제 2: 수학 과목 ===");
var query2 = students
    .Where(s => s.Subject == "수학")
    .Select(s => $"{s.Name} - {s.Subject}: {s.Score}점");
foreach (var student in query2)
{
    Console.WriteLine(student);
}
Console.WriteLine();

Console.WriteLine("=== 문제 3: 점수 내림차순 ===");
var query3 = students
    .OrderByDescending(s => s.Score)
    .Select(s => $"{s.Name} - {s.Subject}: {s.Score}점");
foreach (var student in query3)
{
    Console.WriteLine(student);
}
Console.WriteLine();

Console.WriteLine("=== 문제 4: 전체 평균 ===");
var query4 = students
    .Average(s => s.Score);
Console.WriteLine($"{query4}점");
Console.WriteLine();

Console.WriteLine("=== 문제 5: 수학 최고/최저 점수 ===");
var query51 = students
    .Min(s => s.Score);
var query52 = students
    .Max(s => s.Score);
Console.WriteLine($"최고: {query52}점");
Console.WriteLine($"최저: {query51}점");
Console.WriteLine();

Console.WriteLine("=== 문제 6: 영어 90점 이상 존재 여부 ===");
bool query6 = students.Any(s => s.Score >= 90);
Console.WriteLine(query6);
Console.WriteLine();

Console.WriteLine("=== 문제 7: 모두 70점 이상 여부 ===");
bool query7 = students.All(s => s.Score >= 70);
Console.WriteLine(query7);
Console.WriteLine();

Console.WriteLine("=== 문제 8: 학생 이름 (중복 제거) ===");
var query8 = students.Select(s => s.Name).Distinct();
foreach (var student in query8)
{
    Console.WriteLine(student);
}
Console.WriteLine();

Console.WriteLine("=== 문제 9: 수학 최고점 학생 ===");
var query9 = students
    .Where(s => s.Subject == "수학")
    .OrderByDescending(s => s.Score)
    .Select(s => s.Name)
    .First();
Console.WriteLine(query9);
Console.WriteLine();

Console.WriteLine("=== 문제 10: 과목별 정렬 ===");
var query10 = students
    .GroupBy(s => s.Subject)
    .SelectMany(group => group
        .OrderByDescending(s => s.Score)
    );

foreach (var student in query10)
{
    Console.WriteLine($"{student.Name} - {student.Subject}: {student.Score}점");
}

