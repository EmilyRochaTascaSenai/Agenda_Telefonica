﻿using Agenda_Telefonica.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_Telefonica
{
    public partial class FrmCadastro : Form
    {
        private void validar_cadastro()
        {
            // Validação do nome
            bool erro = false;
            if (txt_nome.Text == "")
            {
                erro = true;
            }
            // Validação do usuário
            if (txt_usuario.Text == "")
            {
                erro = true;
            }
            //Validação telefone
            if (Btn_cd.Text.Length < 15)
            {
                erro |= true;
            }
            // Validação da senha
            if (tx_senha.Text.Length < 8)
            {
                erro = true;
            }

            // Validação da confirmação da senha
            if (txt_repsenha.Text.Length < 8)
            {
                erro = true;
            }

            // Verificação se a senha e a confirmação são iguais
            if (tx_senha.Text != txt_repsenha.Text)
            {
                erro = true;
            }
            // Habilitar ou desabilitar o botão com base na validação
            {
                erro = true;
            }
            if (erro == false)
            {
                Btn_cd.Enabled = true;
            }
            else
            {
                Btn_cd.Enabled = false;
            }

        }
        public FrmCadastro()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //pegando os dados do formulario
            string nome = txt_nome.Text;
            string usuario = txt_usuario.Text;
            string telefone = Btn_cd.Text;
            string senha = tx_senha.Text;

            //Instanciando o objeto UsuarioController
            UsuarioController usuarioController = new UsuarioController();

            //Inserindo o usuario
            bool resultado = usuarioController.AddUsuario(nome, usuario, telefone, senha);
            if (resultado)
            {
                MessageBox.Show("Cadastro efetuado com sucesso");

            }
            else
            {
                MessageBox.Show("Não foi possivel cadastar o usuario!!!!");
            }
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            validar_cadastro();
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {
            validar_cadastro();
        }

        private void tx_senha_TextChanged(object sender, EventArgs e)
        {
            validar_cadastro();
        }

        private void txt_repsenha_TextChanged(object sender, EventArgs e)
        {
            validar_cadastro();
        }

        
       
    }
}
