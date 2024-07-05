using System;
using System.Windows.Forms;

namespace lol_kek.practice_5
{
    public partial class Form5 : Form
    {
        private SimpleLogger logger = new SimpleLogger("log.txt");

        public Form5()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            logger.LogInfo($"Запуск расчета: {DateTime.Now}");

            if (double.TryParse(textBoxX.Text, out double x) && int.TryParse(textBoxN.Text, out int n))
            {
                if (Math.Abs(x) >= 1)
                {
                    MessageBox.Show("Значение x должно быть в пределах от -1 до 1 (не включая).");
                    logger.LogError("Некорректное значение x: выходит за пределы допустимых значений.");
                    return;
                }

                double sum = 0.0;
                double actualY = Math.Log(1 - x * x);
                logger.LogInfo($"Значение x: {x}");
                logger.LogInfo($"Количество слагаемых n: {n}");

                for (int i = 1; i <= n; i++)
                {
                    double term = Math.Pow(x, 2 * i) / i;
                    sum -= term;
                    logger.LogInfo($"Слагаемое {i}: {-term}, Текущая сумма: {sum}");
                }

                MessageBox.Show($"Сумма ряда Тейлора: {sum:F4}\nТочное значение: {actualY:F4}");

                logger.LogInfo($"Сумма ряда Тейлора: {sum:F4}");
                logger.LogInfo($"Точное значение: {actualY:F4}");
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные значения для x и n.");
                logger.LogError("Некорректные данные для x или n.");
            }

            logger.LogInfo($"Завершение расчета: {DateTime.Now}");
        }

        private void buttonShowLogs_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("C:\\Users\\floom\\source\\repos\\SummerPractice_2\\lol_kek\\bin\\Debug\\net8.0-windows\\log.txt");
            textBoxLogs.Text = reader.ReadToEnd();
        }
    }
}

