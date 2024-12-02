using Agenda_Telefonica.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_Telefonica
{
    public partial class FrmContato : Form
    {
        private void validar_contato()
        {
            //validação nome//
            bool erro = false;
            if (txtnome.Text == "")
            {
                erro = true;
            }
            //validação contato//
            if (txtcontato.Text == "")
            {
                erro = true;
            }
            //Validação telefone
            if (txttelefone.Text.Length < 15)
            {
                erro |= true;
            }
        }

        public FrmContato()
        {
            InitializeComponent();
        }
       
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //pegando os dados do formulario//
            string nome = txtnome.Text;
            string contato = txtcontato.Text;
            string telefone = txttelefone.Text;

            //Instanciando o objeto UsuarioController//
            ContatoController contatocontrole = new ContatoController();
            //Inserindo o contato//
                bool resultado = contatocontrole.AddContato( nome, contato, telefone);
            if (resultado)
            {
                MessageBox.Show("Cadastro efetuado com sucesso 😎");

            }
            else
            {
                MessageBox.Show("Não foi possivel cadastar o contato");
            }
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {
            validar_contato();
        }

        private void txttelefone_TextChanged(object sender, EventArgs e)
        {
            validar_contato();
        }

        private void txtcontato_TextChanged(object sender, EventArgs e)
        {
            validar_contato();
        }
    }
}
