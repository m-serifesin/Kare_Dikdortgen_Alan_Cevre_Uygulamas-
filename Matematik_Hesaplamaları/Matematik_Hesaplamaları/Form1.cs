namespace Matematik_Hesaplamaları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int birkenar;
            int alan, cevre;

            int dikalan, dikcevre, uzun;

            birkenar=Convert.ToInt32(textBox1.Text);
            uzun=Convert.ToInt32(textBox2.Text);

            alan = birkenar * birkenar;

            cevre = 4 * birkenar;

            dikalan = birkenar * uzun;

            dikcevre = (2 * uzun) + (2 * birkenar);

            label4.Text = alan.ToString();

            label6.Text = cevre.ToString();

            label4.Text = dikalan.ToString();

            label6.Text = dikcevre.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label7.Visible = false;
            textBox2.Visible = false;
            label1.Text = "Kare";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "DİKDÖRTGEN";
            label2.Text = "Kısa Kenar:";
            panel1.Visible = true;

            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}