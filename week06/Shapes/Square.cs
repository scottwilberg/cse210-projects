public class Square : Shape
{
    private double _side;
    
    public Square(double side)
    {
        _side = side;
        SetColor("Green");
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}