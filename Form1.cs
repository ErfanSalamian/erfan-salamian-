namespace erfansalamian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x, y, w;
            x = textBox1.Text;
            y = textBox2.Text;
            string z = textBox3.Text;
            w = x + ',' + y + ',' + z;
            File.AppendAllText("320.csv", w + "\n");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var text = File.Create("320.csv");
            text.Close();
        }
    }
}
