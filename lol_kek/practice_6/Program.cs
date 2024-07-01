using System;
using System.IO;

class Program
{
    static void Main()
    {
        double x = 0.7;
        int n = 10;
        double y = (Math.Exp(x) + Math.Exp(-x)) / 2;
        double s = 1;

        string logFilePath = "log.txt";
        using (StreamWriter writer = new StreamWriter(logFilePath))
        {
            DateTime startTime = DateTime.Now;
            writer.WriteLine("====== Начало программы ======");
            writer.WriteLine($"Время начала: {startTime}");
            writer.WriteLine($"Значение x: {x}");
            writer.WriteLine($"n: {n}");
            writer.WriteLine($"Точное значение cosh(x): {y}");
            writer.WriteLine($"Начальное значение s: {s}");
            writer.WriteLine("| x\t| y\t| s\t| i\t| k\t| slag\t|");

            for (int i = 2; i <= n; i += 2) // ряде Тейлора степень у x начинается с 2, а не с 1
            {
                int k = 1; // факториал
                writer.WriteLine($"Вычисление факториала для i = {i}");
                for (int j = 2; j <= i; j++)
                {
                    k *= j;
                    writer.WriteLine($"j = {j}, k = {k}");
                }
                double slag = Math.Pow(x, i) / k;
                s += slag;
                string logEntry = $"| x = {x}\t| y = {y}\t| s = {s}\t| i = {i}\t| k = {k}\t| slag = {slag}\t|";

                string res = $"| {x}\t| {y}\t| {s}\t| {i}\t| {k}\t| {slag}\t|";
                writer.WriteLine(logEntry);
                Console.WriteLine(res);
            }

            DateTime endTime = DateTime.Now;
            writer.WriteLine("====== Конец программы ======");
            writer.WriteLine($"Время конца: {endTime}");
        }
    }
}
