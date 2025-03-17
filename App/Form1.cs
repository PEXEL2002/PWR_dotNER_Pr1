using PWR_dotNER_Pr1;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Resetujemy kolory pól tekstowych
            ResetTextBoxColors();

            try
            {
                // Sprawdzamy, czy wszystkie wartoœci to liczby
                if (!int.TryParse(textBox1.Text, out int n) || n <= 0)
                {
                    textBox1.BackColor = System.Drawing.Color.LightCoral;
                    throw new Exception("Liczba przedmiotów musi byæ wiêksza od zera.");
                }

                if (!int.TryParse(textBox2.Text, out int seed))
                {
                    textBox2.BackColor = System.Drawing.Color.LightCoral;
                    throw new Exception("Niepoprawna wartoœæ dla 'seed'.");
                }

                if (!int.TryParse(textBox3.Text, out int capacity) || capacity <= 0)
                {
                    textBox3.BackColor = System.Drawing.Color.LightCoral;
                    throw new Exception("Pojemnoœæ plecaka musi byæ wiêksza od zera.");
                }

                // Tworzenie problemu i wywo³anie solvera
                Problem problem = new Problem(n, seed);
                textBox4.Text = problem.ToString();
                textBox5.Text = problem.Solver(capacity);
            }
            catch (Exception ex)
            {
                // Wyœwietlenie komunikatu o b³êdzie
                MessageBox.Show(ex.Message, "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ResetTextBoxColors()
        {
            textBox1.BackColor = SystemColors.Window;
            textBox2.BackColor = SystemColors.Window;
            textBox3.BackColor = SystemColors.Window;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
