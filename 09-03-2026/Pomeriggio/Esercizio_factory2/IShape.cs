public interface IShape
{
    void Draw();
}

public class Quadrato : IShape
{
    public void Draw()
    {
        Console.WriteLine("*******");
        Console.WriteLine("*     *");
        Console.WriteLine("*     *");
        Console.WriteLine("*******");
    }
}

public class Cerchio : IShape
{
    public void Draw()
    {
        Console.WriteLine("  *   * ");
        Console.WriteLine("*       *");
        Console.WriteLine("*       *");
        Console.WriteLine("  *   * ");
    }
}

public abstract class ShapeCreator
{
    public abstract IShape CreateShape(string type);
}

public class SquareCreator : ShapeCreator
{
    public override IShape CreateShape(string type)
    {
        if(type.ToLower() == "quadrato") return new Quadrato();
        else return null;
    }
}

public class CircleCreator : ShapeCreator
{
    public override IShape CreateShape(string type)
    {
        if(type.ToLower() == "cerchio") return new Cerchio();
        else return null;
    }
}