using System;

class Number
{
    public int Value;

    public Number(int value)
    {
        Value = value;
    }

    public static Number operator -(Number n)
    {
        return new Number(-n.Value);
    }
}

class Program
{
    static void Main()
    {
        Number num = new Number(10);
        Number negatedNum = -num;
        Console.WriteLine(negatedNum.Value); // Output: -10
    }
}