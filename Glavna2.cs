using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basta
{
    public partial class Glavna2 : Form
    {
        public Glavna2()
        {
            InitializeComponent();
        }
        private void Glavna2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



        private void Glavna2_Load(object sender, EventArgs e)
        {

        }

        private void pozicijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pozicija frm_pozicija = new Pozicija();
            frm_pozicija.Show();
        }

        private void tipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tip frm_Tip = new Tip();
            frm_Tip.Show();
        }

        private void obradaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sadiocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sadioc frm_Sadioc = new Sadioc();
            frm_Sadioc.Show();
        }

        private void sadnjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sadnja frm_Sadnja = new Sadnja();
            frm_Sadnja.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Glavna2_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
