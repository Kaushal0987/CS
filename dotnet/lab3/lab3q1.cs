/*
// Multicast delegate example in C#
using System;

namespace MultDel {
public class Rectangle {
  
   public delegate void RectDelegate(double Width, double Height);
    public void Area(double Width, double Height)
    {
        Console.WriteLine($"Area of rectangle is {Width * Height}.");
    }
    public void Perimeter(double Width, double Height)
    {
        Console.WriteLine($"Perimeter of rectangle is {2 * (Width + Height)}.");
    }
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle();
        RectDelegate obj = rect.Area;
        obj += rect.Perimeter;
        // We can call area and perimeter by invoking a single delegate.
        obj.Invoke(11.27, 35.75);
    }
}
}
*/