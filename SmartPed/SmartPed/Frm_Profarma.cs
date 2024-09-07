using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPed
{
    public partial class Frm_Profarma : Form
    {
        public Frm_Profarma()
        {
            InitializeComponent();
        }

        private void Btn_GerarFTP_Click(object sender, EventArgs e)
        {
            Lbl_Saida.Text = $"ftp://{Box_Codigo.Text}:{Box_Senha.Text}@edi.profarma.com.br";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Lbl_Saida.Text);
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Lbl_Saida.Text = "";
        }
    }
}
