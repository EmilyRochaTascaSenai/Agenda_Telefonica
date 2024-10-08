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
            SuspendLayout();
            // 
            // lbl_Nome
            // 
            lbl_Nome.AutoSize = true;
            lbl_Nome.Location = new Point(328, 18);
            lbl_Nome.Name = "lbl_Nome";
            lbl_Nome.Size = new Size(50, 20);
            lbl_Nome.TabIndex = 0;
            lbl_Nome.Text = "Nome";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(295, 71);
            txt_nome.Multiline = true;
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(125, 34);
            txt_nome.TabIndex = 1;
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(295, 169);
            txt_usuario.Multiline = true;
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(125, 34);
            txt_usuario.TabIndex = 2;
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Location = new Point(328, 132);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(59, 20);
            lbl_usuario.TabIndex = 3;
            lbl_usuario.Text = "Usuário";
            // 
            // lbl_telefone
            // 
            lbl_telefone.AutoSize = true;
            lbl_telefone.Location = new Point(321, 226);
            lbl_telefone.Name = "lbl_telefone";
            lbl_telefone.Size = new Size(66, 20);
            lbl_telefone.TabIndex = 4;
            lbl_telefone.Text = "Telefone";
            // 
            // txt_telefone
            // 
            txt_telefone.Location = new Point(295, 273);
            txt_telefone.Name = "txt_telefone";
            txt_telefone.Size = new Size(125, 27);
            txt_telefone.TabIndex = 5;
            // 
            // FrmCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}