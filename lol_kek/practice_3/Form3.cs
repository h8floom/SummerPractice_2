using lol_kek.practice_3;

namespace lol_kek
{
    public partial class Form3 : Form
    {

        private List<Sofa> sofas = new List<Sofa>();

        public Form3()
        {
            InitializeComponent();
        }

        private void buttonCreateObject_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxWidth.Text) ||
                string.IsNullOrWhiteSpace(textBoxHeight.Text) ||
                string.IsNullOrWhiteSpace(textBoxColor.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return;
            }

            int width = int.Parse(textBoxWidth.Text);
            int height = int.Parse(textBoxHeight.Text);
            string color = textBoxColor.Text;

            Sofa newSofa = new Sofa();
            newSofa.SetWidth(width);
            newSofa.SetHeight(height);
            newSofa.SetColor(color);

            sofas.Add(newSofa);
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            listBoxSofa.Items.Clear();
            foreach (var sofa in sofas)
            {
                listBoxSofa.Items.Add(sofa.ToString());
            }
        }

    }

}
