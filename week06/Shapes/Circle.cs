
public class Circle : Shape
{
    private double _radius;
    public Circle (double radius)
    {
        _radius = radius;
        SetColor("Red");
    }

    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}