namespace ProjetoAurora
{
    public partial class Form1 : Form
    {
        int velocidadeTotal = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            velocidadeTotal += (int)numPotencia.Value;
            lblv.Text = velocidadeTotal.ToString();
        }
    }
}