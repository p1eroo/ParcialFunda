namespace APDAYC_Ejercicio1_EP202302
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formDirector form = new();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formPelicula form = new();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formReportPrincipal form = new();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            formAgregarDirectorApeli form = new();
            form.Show();
        }
    }
}