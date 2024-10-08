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
    }
}
