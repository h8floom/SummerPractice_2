using System;
using System.Windows.Forms;

namespace lol_kek.practice_4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            if (int.TryParse(textBoxInitialPrisoners.Text, out int initialPrisoners))
            {
                const int prisonCapacity = 15000;
                double prisoners = initialPrisoners;
                int year = 2024;

                if (dataGridView1.Columns.Count == 0)
                {
                    dataGridView1.Columns.Add("CurrentYear", "Текущий год");
                    dataGridView1.Columns.Add("CurrentPrisoners", "Текущее количество заключенных");
                    dataGridView1.Columns.Add("NextYear", "Следующий год");
                    dataGridView1.Columns.Add("NextPrisoners", "Количество заключенных в следующем году");
                }

                while (prisoners < prisonCapacity)
                {
                    double nextPrisoners = prisoners * 1.05;
                    if (year % 2 == 1)
                    {
                        nextPrisoners *= 0.94;
                    }

                    dataGridView1.Rows.Add(year, prisoners, year + 1, nextPrisoners);

                    year++;
                    prisoners = nextPrisoners;
                }

                int filledRowIndex = dataGridView1.Rows.Add(year, prisoners, "Тюрьма заполнена", prisoners);
                dataGridView1.Rows[filledRowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Yellow;

                MessageBox.Show($"Тюрьма заполнится полностью в {year} году, так как кол-во заключенных ({prisoners} превысило 15000)");
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректное начальное количество заключенных.");
            }
        }
    }
}
