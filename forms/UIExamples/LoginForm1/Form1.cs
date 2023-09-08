namespace LoginForm1
{
    public partial class Form1 : Form
    {
        private Form formPrincipal;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txbNomeUsuario.Text == "well" && txbPassword.Text == "123")
            {
                formPrincipal = new frmMain(this);
                formPrincipal.Show();
                this.Hide();
            }
        }
    }
}