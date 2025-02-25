﻿using System;
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
    public partial class FRM_ANB : Form
    {
        public FRM_ANB()
        {
            InitializeComponent();
        }

        private void Btn_GerarEmail_Click(object sender, EventArgs e)
        {
            DateTime horaAtual = DateTime.Now;
            string bom;
            if (horaAtual.Hour < 12)
            {
                bom = "Bom dia!";
            }
            else
            {
                bom = "Boa tarde!";
            }

            LblSaidaEmail.Text = $"Assunto: Criação de FTP com API: {Box_CNPJ.Text}\n\n{bom}.\nPrecisamos criar FTP para envio de pedido integrado:" +
                $"\nDados do Cliente: {Box_Razao.Text}\nCNPJ: {Box_CNPJ.Text}\nCódigo do Cliente: {Box_Codigo.Text}\nLayout: 25\nAtt;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(LblSaidaEmail.Text);
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            LblSaidaEmail.Text = "";
        }
    }
}
