namespace lol_kek.practice_3;

public abstract class OvalAndSquare
{
    public int X { get; set; }
    public int Y { get; set; }
    public abstract void Draw(Graphics g);
}

public class Oval : OvalAndSquare
{
    public int Width { get; set; }
    public int Height { get; set; }

    public override void Draw(Graphics g)
    {
        g.DrawEllipse(Pens.Black, X, Y, Width, Height);
    }
}

public class FilledSquare : OvalAndSquare
{
    public int SideLength { get; set; }

    public override void Draw(Graphics g)
    {
        g.FillRectangle(Brushes.Black, X, Y, SideLength, SideLength);
    }
}
