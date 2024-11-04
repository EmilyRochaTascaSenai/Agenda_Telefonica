using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using System;
using System.Windows.Forms;

namespace ProjetoAgenda.Controller
{
    internal class UsuarioController
    {
        public bool AddUsuario(string nome, string usuario, string telefone, string senha)
        {
            try
            {
                // Cria a conexão, estou utilizando a classe ConexaoDB que está dentro da pasta DATA
                using (MySqlConnection conexao = ConexaoDB.CriarConexao())
                {
                    // Comando SQL que será executado
                    string sql = "INSERT INTO tbUsuarios (nome, usuario, telefone, senha) VALUES (@nome, @usuario, @telefone, @senha);";

                    // Abri a conexão com o banco
                    conexao.Open();

                    // Esse cara é o responsavel por executar o comando SQL
                    using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                    {
                        // Estou trocando o valor dos @ pelas informações que serão cadastradas
                        // Essas informações vieram dos parametros da função
                        comando.Parameters.AddWithValue("@nome", nome);
                        comando.Parameters.AddWithValue("@usuario", usuario);
                        comando.Parameters.AddWithValue("@telefone", telefone);
                        comando.Parameters.AddWithValue("@senha", senha);

                        // Executando no banco de dados
                        int linhasAfetadas = comando.ExecuteNonQuery();

                        return linhasAfetadas > 0;
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao cadastrar: {erro.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }
    }
}
