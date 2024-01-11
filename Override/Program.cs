// Virtual

Uchburchak u = new Uchburchak(3, 4, 5);
u.Shakl();

Tortburchak t = new Tortburchak(4, 4, 5, 5);
t.Shakl();


public abstract class Shape
{
    public virtual void Shakl()
    {
        Console.WriteLine("Shakl chizildi");
    }
}

public class Uchburchak : Shape
{
    private double a;
    private double b;
    private double c;

    public Uchburchak(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public override void Shakl()
    {
        Console.WriteLine($"{a}, {b}, {c} uchburchak chizildi ");
    }
}
public class Tortburchak : Shape
{
    private double a;
    private double b;
    private double c;
    private double d;

    public Tortburchak(double a, double b, double c, double d)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        this.d = d;
    }
    public override void Shakl()
    {
        Console.WriteLine($"{a}, {b}, {c}, {d} to'rt burchak chizildi");
    }
}