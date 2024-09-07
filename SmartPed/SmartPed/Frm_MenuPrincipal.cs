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
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void Btn_ANB_Click(object sender, EventArgs e)
        {
            FRM_ANB f = new FRM_ANB();
            f.ShowDialog();
        }

        private void Btn_GAM_Click(object sender, EventArgs e)
        {
            Frm_GAM f = new Frm_GAM();
            f.ShowDialog();
        }

        private void Btn_Profarma_Click(object sender, EventArgs e)
        {
            Frm_Profarma f = new Frm_Profarma();
            f.ShowDialog();
        }
    }
}
