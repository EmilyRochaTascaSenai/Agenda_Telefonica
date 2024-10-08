namespace Agenda_Telefonica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbl_usuario = new Label();
            lbl_Senha = new Label();
            textusuario = new TextBox();
            textBox2 = new TextBox();
            btn_Cadastrar = new Button();
            btn_Entrar = new Button();
            SuspendLayout();
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Location = new Point(267, 49);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(59, 20);
            lbl_usuario.TabIndex = 0;
            lbl_usuario.Text = "Usuário";
            // 
            // lbl_Senha
            // 
            lbl_Senha.AutoSize = true;
            lbl_Senha.Location = new Point(267, 215);
            lbl_Senha.Name = "lbl_Senha";
            lbl_Senha.Size = new Size(49, 20);
            lbl_Senha.TabIndex = 1;
            lbl_Senha.Text = "Senha";
            // 
            // textusuario
            // 
            textusuario.Location = new Point(242, 97);
            textusuario.Multiline = true;
            textusuario.Name = "textusuario";
            textusuario.Size = new Size(125, 34);
            textusuario.TabIndex = 2;
            textusuario.TextChanged += textusuario_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(227, 274);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // btn_Cadastrar
            // 
            btn_Cadastrar.BackColor = Color.Red;
            btn_Cadastrar.Location = new Point(414, 370);
            btn_Cadastrar.Name = "btn_Cadastrar";
            btn_Cadastrar.Size = new Size(94, 29);
            btn_Cadastrar.TabIndex = 4;
            btn_Cadastrar.Text = "Cadastrar";
            btn_Cadastrar.UseVisualStyleBackColor = false;
            btn_Cadastrar.Click += btn_Cadastrar_Click;
            // 
            // btn_Entrar
            // 
            btn_Entrar.BackColor = Color.FromArgb(0, 192, 0);
            btn_Entrar.Enabled = false;
            btn_Entrar.Location = new Point(71, 370);
            btn_Entrar.Name = "btn_Entrar";
            btn_Entrar.Size = new Size(94, 29);
            btn_Entrar.TabIndex = 5;
            btn_Entrar.Text = "Entrar";
            btn_Entrar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(655, 450);
            Controls.Add(btn_Entrar);
            Controls.Add(btn_Cadastrar);
            Controls.Add(textBox2);
            Controls.Add(textusuario);
            Controls.Add(lbl_Senha);
            Controls.Add(lbl_usuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_usuario;
        private Label lbl_Senha;
        private TextBox textusuario;
        private TextBox textBox2;
        private Button btn_Cadastrar;
        private Button btn_Entrar;
    }
}
