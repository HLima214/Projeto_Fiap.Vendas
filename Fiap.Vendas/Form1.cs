namespace Fiap.Vendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Usuário_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void validarUsuario(string usuario, string senha)
        {
            if (usuario == "fiap" && senha == "2025")
            {
                Inicio telaNova = new Inicio();
                telaNova.Show();
            }
            else
            {
                MessageBox.Show("Usuário e senha inválidos");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            validarUsuario(txtUsuario.Text, txtsenha.Text);
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {

        }
    }
}
