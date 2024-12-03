namespace Agenda_Telefonica
{
    partial class FrmContato
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
            AtualizadataGridView = new DataGridView();
            lblnome = new Label();
            lblTelefone = new Label();
            lblConatato = new Label();
            txtnome = new TextBox();
            txttelefone = new TextBox();
            txtcontato = new TextBox();
            btnExcluir = new Button();
            btnInserir = new Button();
            btnAlterar = new Button();
            ((System.ComponentModel.ISupportInitialize)AtualizadataGridView).BeginInit();
            SuspendLayout();
            // 
            // AtualizadataGridView
            // 
            AtualizadataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AtualizadataGridView.Location = new Point(499, 12);
            AtualizadataGridView.Name = "AtualizadataGridView";
            AtualizadataGridView.Size = new Size(289, 400);
            AtualizadataGridView.TabIndex = 0;
            AtualizadataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Location = new Point(101, 57);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(40, 15);
            lblnome.TabIndex = 1;
            lblnome.Text = "Nome";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(246, 57);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 2;
            lblTelefone.Text = "Telefone";
            // 
            // lblConatato
            // 
            lblConatato.AutoSize = true;
            lblConatato.Location = new Point(385, 60);
            lblConatato.Name = "lblConatato";
            lblConatato.Size = new Size(50, 15);
            lblConatato.TabIndex = 3;
            lblConatato.Text = "Contato";
            // 
            // txtnome
            // 
            txtnome.Location = new Point(69, 92);
            txtnome.Multiline = true;
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(100, 23);
            txtnome.TabIndex = 4;
            txtnome.TextChanged += txtnome_TextChanged;
            // 
            // txttelefone
            // 
            txttelefone.Location = new Point(203, 92);
            txttelefone.Multiline = true;
            txttelefone.Name = "txttelefone";
            txttelefone.Size = new Size(103, 22);
            txttelefone.TabIndex = 5;
            txttelefone.TextChanged += txttelefone_TextChanged;
            // 
            // txtcontato
            // 
            txtcontato.Location = new Point(367, 91);
            txtcontato.Multiline = true;
            txtcontato.Name = "txtcontato";
            txtcontato.Size = new Size(100, 23);
            txtcontato.TabIndex = 6;
            txtcontato.TextChanged += txtcontato_TextChanged;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(367, 199);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExclui_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(246, 199);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 8;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(147, 199);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 23);
            btnAlterar.TabIndex = 9;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // FrmContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnAlterar);
            Controls.Add(btnInserir);
            Controls.Add(btnExcluir);
            Controls.Add(txtcontato);
            Controls.Add(txttelefone);
            Controls.Add(txtnome);
            Controls.Add(lblConatato);
            Controls.Add(lblTelefone);
            Controls.Add(lblnome);
            Controls.Add(AtualizadataGridView);
            Name = "FrmContato";
            Text = "FrmContato";
            ((System.ComponentModel.ISupportInitialize)AtualizadataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView AtualizadataGridView;
        private Label lblnome;
        private Label lblTelefone;
        private Label lblConatato;
        private TextBox txtnome;
        private TextBox txttelefone;
        private TextBox txtcontato;
        private Button btnExcluir;
        private Button btnInserir;
        private Button btnAlterar;
    }
}