using Agenda_Telefonica.Controller;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Agenda_Telefonica.Contato;

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

        private void btnExclui_Click(object sender, EventArgs e)
        {
            // Exemplo de exclusão de um contato
            string nome = txtnome.Text;

            var contato = Contatos.Find(c => c.Nome == nome);
            if (contato != null)
            {
                Contatos.Remove(contato);
                MessageBox.Show("Contato excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Contato não encontrado!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AtualizadataGridView.DataSource = null;
            //dataGridView1.DataSource = contato;//
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            // Exemplo de inserção de um novo contato
            string nome = txtnome.Text;
            string telefone = txttelefone.Text;

            Contatos.Add(new Contatos(nome, telefone));
            MessageBox.Show("Contato inserido com sucesso!");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // Exemplo de alteração de um contato
            string nome = txtnome.Text;
            string novoTelefone = txttelefone.Text;

            var contato = Contatos.Find(c => c.Nome == nome);
            if (contato != null)
            {
                contato.Telefone = novoTelefone;
                MessageBox.Show("Contato alterado com sucesso!");
            }
            else
            {
                MessageBox.Show("Contato não encontrado!");
            }
        }
        public class Agenda
        {
            // Lista de contatos
            private List<Contatos> listaContatos;

            public Agenda()
            {
                // Inicializa a lista
                listaContatos = new List<Contatos>();
            }

            public void AdicionarContato(string nome, string telefone)
            {
                // Adiciona um novo contato à lista
                listaContatos.Add(new Contatos(nome, telefone));
            }

            public void ExibirContatos()
            {
                foreach (var contato in listaContatos)
                {
                    Console.WriteLine($"Nome: {contato.Nome}, Telefone: {contato.Telefone}");
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Agenda minhaAgenda = new Agenda();
                minhaAgenda.AdicionarContato("Ana", "1234-5678");
                minhaAgenda.AdicionarContato("Livia", "8765-4321");

                minhaAgenda.ExibirContatos(); // Exibe os contatos
            }
        }
}
