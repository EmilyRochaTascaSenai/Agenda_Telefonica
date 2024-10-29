using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Telefonica.Controller
{
    internal class UsuarioController
    {

        public bool AddUsuario(string nome,string usuario,string telefone,string senha)
        {
            //cria conexão,estou utilizando ConexaoDB que está dentro da pasta DATA
            MySqlConnection conexao = ConexaoDB.Criarconexao();

            //Comando do sql que será executado
            string sql = "INSERT INTO Tbusuaios(nome,usuario,telefone,senha)VALUES(@nome,@usuario,@telefone, @senha);";

            //abrir conexão com o BCD
            conexao.Open();

            //responsavel por executar o comando sql
            MySqlCommand comando =new MySqlCommand(sql, conexao);

            //estou trocando o valor do @ pelas informações que serão cadastradas
            //essas informações vieram dos parametros da função
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@telefone", telefone);
            comando.Parameters.AddWithValue("@senha",senha);

            //executando no BCD
            int linhasafetadas=comando.ExecuteNonQuery();

            //Fechando a conexão
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
