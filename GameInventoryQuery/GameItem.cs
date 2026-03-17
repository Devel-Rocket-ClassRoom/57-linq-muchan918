using System;

class GameItem
{
    public string Name;
    public string Type;
    public string Grade;
    public int Price;
    public int Quantity;

    public GameItem(string name, string type, string grade, int price, int quantity)
    {
        Name = name;
        Type = type;
        Grade = grade;
        Price = price;
        Quantity = quantity;
    }

    public override string ToString()
    {
        return $"{Name} - {Type} - {Price}원";
    }
}