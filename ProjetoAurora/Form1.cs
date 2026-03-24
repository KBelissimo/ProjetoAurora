namespace ProjetoAurora
{
    public partial class Form1 : Form
    {

        int velocidadeTotal = 0;

        int oxigenio = 100;


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)

        private void label1_Click(object sender, EventArgs e)

        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            velocidadeTotal += (int)numPotencia.Value;
            lblv.Text = velocidadeTotal.ToString();

        private void trackOxigenio_Scroll(object sender, EventArgs e)
        {
                oxigenio = (int)trackOxigenio.Value;
                lblPor.Text = oxigenio.ToString() + "%";

        }
    }
}