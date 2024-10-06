namespace Prueba3._0
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

        private void btn1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Visible = true;


        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Visible = true;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Visible = true;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Visible = true;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Visible = true;
        }
    }
}