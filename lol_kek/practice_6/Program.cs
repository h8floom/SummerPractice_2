double x = 0.7;
int n = 10;
double y = (Math.Exp(x) + Math.Exp(-x)) / 2;
double s = 1;
for (int i = 2; i <= n; i += 2) // исправление (в ряде тейлора степень у x начинается с 2, а не с 1)
{
    int k = 1; // факториал
    for (int j = 2; j <= i; j++)
        k *= j;
    double slag = Math.Pow(x, i) / k;
    s += slag;
    Console.WriteLine("| {0}\t| {1}\t| {2}\t|", x, y, s);
}