namespace Agenda_Telefonica
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
            lbl_telefone = new Label();
            txt_telefone = new TextBox();
            tx_senha = new TextBox();
            lbl_senha = new Label();
            lbl_repsenha = new Label();
            txt_repsenha = new TextBox();
            btn_Cancelar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lbl_Nome
            // 
            lbl_Nome.AutoSize = true;
            lbl_Nome.Location = new Point(328, 9);
            lbl_Nome.Name = "lbl_Nome";
            lbl_Nome.Size = new Size(50, 20);
            lbl_Nome.TabIndex = 0;
            lbl_Nome.Text = "Nome";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(295, 51);
            txt_nome.Multiline = true;
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(125, 34);
            txt_nome.TabIndex = 1;
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(295, 159);
            txt_usuario.Multiline = true;
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(125, 34);
            txt_usuario.TabIndex = 2;
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Location = new Point(321, 112);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(59, 20);
            lbl_usuario.TabIndex = 3;
            lbl_usuario.Text = "Usuário";
            // 
            // lbl_telefone
            // 
            lbl_telefone.AutoSize = true;
            lbl_telefone.Location = new Point(321, 216);
            lbl_telefone.Name = "lbl_telefone";
            lbl_telefone.Size = new Size(66, 20);
            lbl_telefone.TabIndex = 4;
            lbl_telefone.Text = "Telefone";
            // 
            // txt_telefone
            // 
            txt_telefone.Location = new Point(295, 255);
            txt_telefone.Multiline = true;
            txt_telefone.Name = "txt_telefone";
            txt_telefone.Size = new Size(125, 27);
            txt_telefone.TabIndex = 5;
            // 
            // tx_senha
            // 
            tx_senha.Location = new Point(295, 320);
            tx_senha.Multiline = true;
            tx_senha.Name = "tx_senha";
            tx_senha.Size = new Size(125, 27);
            tx_senha.TabIndex = 6;
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Location = new Point(331, 285);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(49, 20);
            lbl_senha.TabIndex = 7;
            lbl_senha.Text = "Senha";
            // 
            // lbl_repsenha
            // 
            lbl_repsenha.AutoSize = true;
            lbl_repsenha.Location = new Point(306, 364);
            lbl_repsenha.Name = "lbl_repsenha";
            lbl_repsenha.Size = new Size(96, 20);
            lbl_repsenha.TabIndex = 8;
            lbl_repsenha.Text = "Repita Senha";
            // 
            // txt_repsenha
            // 
            txt_repsenha.Location = new Point(295, 402);
            txt_repsenha.Multiline = true;
            txt_repsenha.Name = "txt_repsenha";
            txt_repsenha.Size = new Size(125, 27);
            txt_repsenha.TabIndex = 9;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.Red;
            btn_Cancelar.Location = new Point(613, 303);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(94, 29);
            btn_Cancelar.TabIndex = 10;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Location = new Point(486, 303);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Cadastar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FrmCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btn_Cancelar);
            Controls.Add(txt_repsenha);
            Controls.Add(lbl_repsenha);
            Controls.Add(lbl_senha);
            Controls.Add(tx_senha);
            Controls.Add(txt_telefone);
            Controls.Add(lbl_telefone);
            Controls.Add(lbl_usuario);
            Controls.Add(txt_usuario);
            Controls.Add(txt_nome);
            Controls.Add(lbl_Nome);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Label lbl_telefone;
        private TextBox txt_telefone;
        private TextBox tx_senha;
        private Label lbl_senha;
        private Label lbl_repsenha;
        private TextBox txt_repsenha;
        private Button btn_Cancelar;
        private Button button1;
    }
}