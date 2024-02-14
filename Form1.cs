namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numbone = int.Parse(numone.Text);
            int numbtwo = int.Parse(numtwo.Text);
            int output = numbone + numbtwo;
            outputbox.Text = output.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int numbone = int.Parse(numone.Text);
            int numbtwo = int.Parse(numtwo.Text);
            int output = numbone * numbtwo;
            outputbox.Text = output.ToString();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            int numbone = int.Parse(numone.Text);
            int numbtwo = int.Parse(numtwo.Text);
            int output = numbone - numbtwo;
            outputbox.Text = output.ToString();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            int numbone = int.Parse(numone.Text);
            int numbtwo = int.Parse(numtwo.Text);
            int output = numbone / numbtwo;
            outputbox.Text = output.ToString();
        }

        private void modulus_Click(object sender, EventArgs e)
        {
            int numbone = int.Parse(numone.Text);
            int numbtwo = int.Parse(numtwo.Text);
            int output = numbone % numbtwo;
            outputbox.Text = output.ToString();
        }

        private void power_Click(object sender, EventArgs e)
        {
            int numbone = int.Parse(numone.Text);
            int numbtwo = int.Parse(numtwo.Text);
            double output = Math.Pow(numbone, numbtwo);
            outputbox.Text = output.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int numbone = int.Parse(numone.Text);
            int numbtwo = int.Parse(numtwo.Text);
            double output = Math.Pow(numbone, (1 / numbtwo));
            outputbox.Text = output.ToString();
        }
    }
}
