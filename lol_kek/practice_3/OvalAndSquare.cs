namespace lol_kek.practice_3;

public abstract class OvalAndSquare
{
    public int X { get; set; }
    public int Y { get; set; }
    public Color Color { get; set; } 
    public abstract void Draw(Graphics g);
}

public class Oval : OvalAndSquare
{
    public int Width { get; set; }
    public int Height { get; set; }

    public override void Draw(Graphics g)
    {
        using (Pen pen = new Pen(Color))
        {
            g.DrawEllipse(pen, X, Y, Width, Height); 
        }
    }
}

public class FilledSquare : OvalAndSquare
{
    public int SideLength { get; set; }

    public override void Draw(Graphics g)
    {
        using (Brush brush = new SolidBrush(Color))
        {
            g.FillRectangle(brush, X, Y, SideLength, SideLength); // Используем Color из базового класса
        }
    }
}
