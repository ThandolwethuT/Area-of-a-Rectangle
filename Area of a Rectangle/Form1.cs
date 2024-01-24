namespace Area_of_a_Rectangle
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
            double A, H, L, P;

            if (double.TryParse(textBox1.Text, out H) && double.TryParse(textBox2.Text, out L))
            {
                A = H * L;
                P = 2 * (L + H);

                textBox3.Text = A.ToString();
            }
            else
            {
                MessageBox.Show("Enter valid numeric value");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double A, H, L, P;

            if (double.TryParse(textBox1.Text, out H) && double.TryParse(textBox2.Text, out L))
            {
                A = H * L;
                P = 2 * (L + H);

                textBox4.Text = P.ToString();
            }
            else
            {
                MessageBox.Show("Enter valid numeric value");
            }
        }
    }
}
