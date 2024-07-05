using lol_kek.practice_3;

namespace lol_kek
{
    public partial class Form3 : Form
    {
        private List<OvalAndSquare> figures = new List<OvalAndSquare>();
        private List<Sofa> sofas = new List<Sofa>();
        private Color selectedColor;

        public Form3()
        {
            InitializeComponent();
        }

        private void buttonCreateObject_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(textBoxWidth.Text) ||
            //    string.IsNullOrWhiteSpace(textBoxHeight.Text) ||
            //    comboBoxColor.SelectedItem == null)
            //{
            //    MessageBox.Show("Пожалуйста, заполните все поля!");
            //    return;
            //}

            int width = int.Parse(textBoxWidth.Text);
            int height = int.Parse(textBoxHeight.Text);
            string colorName = comboBoxColor.Text;

            Sofa newSofa = new Sofa();
            newSofa.SetWidth(width);
            newSofa.SetHeight(height);
            newSofa.SetColor(colorName);

            sofas.Add(newSofa);
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(textBoxWidth.Text) ||
            //    string.IsNullOrWhiteSpace(textBoxHeight.Text) ||
            //    string.IsNullOrWhiteSpace(textBoxColor.Text))
            //{
            //    MessageBox.Show("Пожалуйста, заполните все поля!");
            //    return;
            //}

            listBoxSofa.Items.Clear();
            foreach (var sofa in sofas)
            {
                listBoxSofa.Items.Add(sofa.ToString());
            }
        }
        
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string curIndex = listBoxSofa.SelectedItems.ToString();
            int index = listBoxSofa.FindString(curIndex);

            sofas.RemoveAt(index+1);
            //if (int.TryParse(textBoxDelete.Text, out int indToDel))
            //{
            //    if (indToDel >= 0 && indToDel < sofas.Count)
            //    {
            //        sofas.RemoveAt(indToDel);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Некорректный индекс. Пожалуйста, введите правильный индекс.");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Пожалуйста, введите корректный индекс.");
            //}
        }

        private void buttonCreateOval_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxOvalWidth.Text) ||
                string.IsNullOrWhiteSpace(textBoxOvalHeight.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля для овала!");
                return;
            }

            int width = int.Parse(textBoxOvalWidth.Text);
            int height = int.Parse(textBoxOvalHeight.Text);

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedColor = colorDialog1.Color; 
            }

            Oval newOval = new Oval
            {
                Width = width,
                Height = height,
                X = new Random().Next(pictureBoxFigures.Width - width),
                Y = new Random().Next(pictureBoxFigures.Height - height),
                Color = selectedColor
            };

            figures.Add(newOval);
        }

        private void buttonCreateSquare_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSquareSize.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля для закрашенного квадрата!");
                return;
            }

            int sideLength = int.Parse(textBoxSquareSize.Text);

            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                selectedColor = colorDialog2.Color; 
            }

            FilledSquare newSquare = new FilledSquare
            {
                SideLength = sideLength,
                X = new Random().Next(pictureBoxFigures.Width - sideLength),
                Y = new Random().Next(pictureBoxFigures.Height - sideLength),
                Color = selectedColor 
            };

            figures.Add(newSquare);
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            pictureBoxFigures.Refresh();
            using (Graphics g = pictureBoxFigures.CreateGraphics())
            {
                foreach (var figure in figures)
                {
                    figure.Draw(g);
                }
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFirstValue.Text) || string.IsNullOrWhiteSpace(textBoxSecondValue.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return;
            }

            int value_1 = int.Parse(textBoxFirstValue.Text);
            int value_2 = int.Parse(textBoxSecondValue.Text);

            Multiplier multiply = new Multiplier();
            double result = multiply.Calculate(value_1, value_2);

            this.textBoxCalculatorResult.Text = "Произведение: " + result;
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFirstValue.Text) || string.IsNullOrWhiteSpace(textBoxSecondValue.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return;
            }

            int num1 = int.Parse(textBoxFirstValue.Text);
            int num2 = int.Parse(textBoxSecondValue.Text);

            AdvancedCalculator advancedMultiply = new AdvancedCalculator();
            double result = advancedMultiply.Calculate(num1, num2);

            this.textBoxCalculatorResult.Text = "Корень суммы: " + result;
        }

        
    }
}
