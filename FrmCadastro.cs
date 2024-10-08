using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_Telefonica
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }
        private void validar_cadastro()
        {
            if (txt_nome.Text.Length > 8)
            {
                Btn_cd.Enabled = true;
            }
            else
            {
                Btn_cd.Enabled = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            validar_cadastro();
        }
    }
}
