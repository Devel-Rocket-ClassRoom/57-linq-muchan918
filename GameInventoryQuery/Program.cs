using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Quic;

List<GameItem> gameItems = new List<GameItem>
{
    new GameItem("나무 검", "무기", "일반", 100, 3),
    new GameItem("강철 대검", "무기", "희귀", 800, 1),
    new GameItem("용의 검", "무기", "전설", 5000, 1),
    new GameItem("가죽 값옷", "방어구", "일반", 200, 2),
    new GameItem("미스릴 값옷", "방어구", "희귀", 1200, 1),
    new GameItem("드래곤 갑옷", "방어구", "전설", 8000, 0),
    new GameItem("체력 물약", "소비", "일반", 50, 10),
    new GameItem("마나 물약", "소비", "일반", 80, 5),
    new GameItem("고급 물약", "소비", "희귀", 500, 0),
    new GameItem("엘릭서", "소비", "전설", 3000, 2)
};

var query1 = from gameItem in gameItems
             where gameItem.Price >= 500
             orderby gameItem.Price descending
             select gameItem;

Console.WriteLine("=== 쿼리 1: 가격 500 이상 (가격 내림차순) ===");
foreach  (var gameItem in query1)
{
    Console.WriteLine(gameItem);
}
Console.WriteLine();

var  query2 = from gameItem in gameItems
              where gameItem.Type == "무기"
              orderby gameItem.Grade == "일반" ? 0 :
                      gameItem.Grade == "희귀" ? 1 : 2
              select gameItem;

Console.WriteLine("=== 쿼리 2: 무기 타입 (등급순) ===");
foreach (var gameItem in query2)
{
    Console.WriteLine(gameItem);
}
Console.WriteLine();

var query3 = from gameItem in gameItems
             let totalValue = gameItem.Price * gameItem.Quantity
             where totalValue >= 1000
             select gameItem;

Console.WriteLine("=== 쿼리 3: 총 가치 1000 이상 ===");
foreach (var gameItem in query3)
{
    Console.WriteLine(gameItem);
}
Console.WriteLine();

var query4 = from gameItem in gameItems
             where gameItem.Quantity == 0
             orderby gameItem.Name
             select gameItem;

Console.WriteLine("=== 쿼리 4: 품절 아이템 (이름순) ===");
foreach (var gameItem in query4)
{
    Console.WriteLine(gameItem.Name);
}
Console.WriteLine();

var query5 = from gameItem in gameItems
             where gameItem.Grade == "전설"
             select new {Name = gameItem.Name, Price = gameItem.Price};

Console.WriteLine("=== 쿼리 5: 전설 등급 (이름과 가격) ===");
foreach (var gameItem in query5)
{
    Console.WriteLine($"{gameItem.Name} - {gameItem.Price}");
}
Console.WriteLine();