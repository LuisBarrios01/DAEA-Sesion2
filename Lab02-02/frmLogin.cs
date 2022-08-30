namespace Lab02_02
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            String[] Usuario = { "luis", "elias", "barrios"};
            String[] Clave = { "0808", "0805", "123", "321" };

            if (Usuario.Contains(txtUsuario.Text) && Clave.Contains(txtPassword.Text) && Array.IndexOf(Usuario, txtUsuario.Text) == Array.IndexOf(Clave, txtPassword.Text))
            {
                PrincipalMDI principal = new PrincipalMDI();
                principal.Show();
                this.Hide();
                txtUsuario.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}