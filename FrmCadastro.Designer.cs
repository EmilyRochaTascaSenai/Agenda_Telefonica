﻿namespace Agenda_Telefonica
{
    partial class FrmCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastro));
            lbl_Nome = new Label();
            txt_nome = new TextBox();
            txt_usuario = new TextBox();
            lbl_usuario = new Label();
            tx_senha = new TextBox();
            lbl_senha = new Label();
            lbl_repsenha = new Label();
            txt_repsenha = new TextBox();
            btn_Cancelar = new Button();
            Btn_cd = new Button();
            SuspendLayout();
            // 
            // lbl_Nome
            // 
            lbl_Nome.AutoSize = true;
            lbl_Nome.Location = new Point(287, 7);
            lbl_Nome.Name = "lbl_Nome";
            lbl_Nome.Size = new Size(40, 15);
            lbl_Nome.TabIndex = 0;
            lbl_Nome.Text = "Nome";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(258, 38);
            txt_nome.Margin = new Padding(3, 2, 3, 2);
            txt_nome.Multiline = true;
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(110, 26);
            txt_nome.TabIndex = 1;
            txt_nome.TextChanged += txt_nome_TextChanged;
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(258, 119);
            txt_usuario.Margin = new Padding(3, 2, 3, 2);
            txt_usuario.Multiline = true;
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(110, 26);
            txt_usuario.TabIndex = 2;
            txt_usuario.TextChanged += txt_usuario_TextChanged;
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Location = new Point(281, 84);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(47, 15);
            lbl_usuario.TabIndex = 3;
            lbl_usuario.Text = "Usuário";
            // 
            // tx_senha
            // 
            tx_senha.Location = new Point(258, 215);
            tx_senha.Margin = new Padding(3, 2, 3, 2);
            tx_senha.Multiline = true;
            tx_senha.Name = "tx_senha";
            tx_senha.Size = new Size(110, 21);
            tx_senha.TabIndex = 6;
            tx_senha.TextChanged += tx_senha_TextChanged;
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Location = new Point(288, 173);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(39, 15);
            lbl_senha.TabIndex = 7;
            lbl_senha.Text = "Senha";
            // 
            // lbl_repsenha
            // 
            lbl_repsenha.AutoSize = true;
            lbl_repsenha.Location = new Point(269, 260);
            lbl_repsenha.Name = "lbl_repsenha";
            lbl_repsenha.Size = new Size(75, 15);
            lbl_repsenha.TabIndex = 8;
            lbl_repsenha.Text = "Repita Senha";
            // 
            // txt_repsenha
            // 
            txt_repsenha.Location = new Point(258, 288);
            txt_repsenha.Margin = new Padding(3, 2, 3, 2);
            txt_repsenha.Multiline = true;
            txt_repsenha.Name = "txt_repsenha";
            txt_repsenha.Size = new Size(110, 21);
            txt_repsenha.TabIndex = 9;
            txt_repsenha.TextChanged += txt_repsenha_TextChanged;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.Red;
            btn_Cancelar.Location = new Point(536, 227);
            btn_Cancelar.Margin = new Padding(3, 2, 3, 2);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(82, 22);
            btn_Cancelar.TabIndex = 10;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            // 
            // Btn_cd
            // 
            Btn_cd.BackColor = Color.FromArgb(0, 192, 0);
            Btn_cd.Enabled = false;
            Btn_cd.Location = new Point(425, 227);
            Btn_cd.Margin = new Padding(3, 2, 3, 2);
            Btn_cd.Name = "Btn_cd";
            Btn_cd.Size = new Size(82, 22);
            Btn_cd.TabIndex = 11;
            Btn_cd.Text = "Cadastar";
            Btn_cd.UseVisualStyleBackColor = false;
            Btn_cd.Click += button1_Click;
            // 
            // FrmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(700, 338);
            Controls.Add(Btn_cd);
            Controls.Add(btn_Cancelar);
            Controls.Add(txt_repsenha);
            Controls.Add(lbl_repsenha);
            Controls.Add(lbl_senha);
            Controls.Add(tx_senha);
            Controls.Add(lbl_usuario);
            Controls.Add(txt_usuario);
            Controls.Add(txt_nome);
            Controls.Add(lbl_Nome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmCadastro";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Nome;
        private TextBox txt_nome;
        private TextBox txt_usuario;
        private Label lbl_usuario;
        private TextBox tx_senha;
        private Label lbl_senha;
        private Label lbl_repsenha;
        private TextBox txt_repsenha;
        private Button btn_Cancelar;
        private Button Btn_cd;
    }
}