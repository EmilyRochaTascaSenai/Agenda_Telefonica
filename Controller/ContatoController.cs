using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Telefonica.Controller
{
    internal class ContatoController
    {

        public bool Contato(string cod_contato, string contato, string telefone, string categoria)
        {
            //cria conex�o,estou utilizando ConexaoDB que est� dentro da pasta DATA
            MySqlConnection conexao = ConexaoDB.Criarconexao();

            //Comando do sql que ser� executado
            string sql = "INSERT INTO Tbusuaios(cod_contato,contato,telefone,categoria)VALUES(@cod_contato,@contato,@telefone, @categoria);";

            //abrir conex�o com o BCD
            conexao.Open();

            //responsavel por executar o comando sql
            MySqlCommand comando = new MySqlCommand(sql, conexao);

            //estou trocando o valor do @ pelas informa��es que ser�o cadastradas
            //essas informa��es vieram dos parametros da fun��o
            comando.Parameters.AddWithValue("@cod_contato", nome);
            comando.Parameters.AddWithValue("@contato", usuario);
            comando.Parameters.AddWithValue("@telefone", telefone);
            comando.Parameters.AddWithValue("@categoria", senha);

            //executando no BCD
            int linhasafetadas = comando.ExecuteNonQuery();

            //Fechando a conex�o
            conexao.Close();
            if (linhasafetadas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
