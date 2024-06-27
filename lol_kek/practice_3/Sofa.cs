namespace lol_kek.practice_3;

public class Sofa
{
    private string? Color;
    private int Width;
    private int Height;

    public void SetWidth(int width)
    {
        if (width > 0)
        {
            this.Width = width;
        }
        else
        {
            throw new ArgumentException("Введите корректную ширину дивана!");
        }
    }

    public void SetHeight(int height)
    {
        if (height > 0)
        {
            this.Height = height;
        }
        else
        {
            throw new ArgumentException("Введите корректную высоту дивана!");
        }
    }

    public void SetColor(string color)
    {
        if (!string.IsNullOrEmpty(color))
        {
            this.Color = color;
        }
        else
        {
            throw new ArgumentException("Введите корректный цвет дивана!");
        }
    }

    public override string ToString()
    {
        return $"Color: {Color}, Width: {Width}, Height: {Height}";
    }
}
