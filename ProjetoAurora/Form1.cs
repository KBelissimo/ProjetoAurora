namespace ProjetoAurora
{
    public partial class Form1 : Form
    {
        int oxigenio = 100;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackOxigenio_Scroll(object sender, EventArgs e)
        {
                oxigenio = (int)trackOxigenio.Value;
                lblPor.Text = oxigenio.ToString() + "%";
        }
    }
}
