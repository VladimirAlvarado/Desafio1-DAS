namespace Desafio1
{
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
        }

        private void timerWelcome_Tick(object sender, EventArgs e)
        {
            timerWelcome.Stop();

            FormLogin formLogin = new FormLogin();
            formLogin.Show();

            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}