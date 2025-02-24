using System;

namespace Liskov_Substitution_Solution;

public class Square : IShape
{
    public int Side { get; set; }

    public Square(int side)
    {
        Side = side;
    }

    public int GetArea()
    {
        return Side * Side;
    }
}
