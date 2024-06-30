namespace lol_kek.practice_5
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            using (StreamWriter log = new StreamWriter("log.txt", true))
            {
                log.WriteLine($"Запуск расчета: {DateTime.Now}");

                if (double.TryParse(textBoxX.Text, out double x) && int.TryParse(textBoxN.Text, out int n))
                {
                    if (Math.Abs(x) >= 1)
                    {
                        MessageBox.Show("Значение x должно быть в пределах от -1 до 1 (не включая).");
                        log.WriteLine("Некорректное значение x: выходит за пределы допустимых значений.");
                        return;

                        // ограничение (-1;1), тк Ln всегда > 0
                    }

                    double sum = 0.0;
                    double actualY = Math.Log(1 - x * x);
                    log.WriteLine($"Значение x: {x}");
                    log.WriteLine($"Количество слагаемых n: {n}");

                    for (int i = 1; i <= n; i++)
                    {
                        double term = Math.Pow(x, 2 * i) / i;
                        sum -= term;
                        log.WriteLine($"Слагаемое {i}: {-term}, Текущая сумма: {sum}");
                    }

                    MessageBox.Show($"Сумма ряда Тейлора: {sum:F4}\nТочное значение: {actualY:F4}");

                    log.WriteLine($"Сумма ряда Тейлора: {sum:F4}");
                    log.WriteLine($"Точное значение: {actualY:F4}");
                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите корректные значения для x и n.");
                    log.WriteLine("Некорректные данные для x или n.");
                }

                log.WriteLine($"Завершение расчета: {DateTime.Now}");
                log.WriteLine();
            }
        }
    }
}
