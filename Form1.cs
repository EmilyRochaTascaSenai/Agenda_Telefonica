namespace Agenda_Telefonica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastro formulariocadastro = new FrmCadastro();
            formulariocadastro.ShowDialog();
        }

        private void textusuario_TextChanged(object sender, EventArgs e)
        {
            //Se o usuario for diferente diferente de vazio e a quantidade de caracteres na Senha for maior ou igual a 8 abilita o botão entrar//
            if (textusuario.Text!= "" && textBox2.Text.Length >= 8) 
            {
                btn_Entrar.Enabled = true;
            }
            else
            {
                btn_Entrar.Enabled=false;
            }
            

        }

    }
}

