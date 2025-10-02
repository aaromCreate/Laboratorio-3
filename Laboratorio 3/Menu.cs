using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_3
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        

        

        

        



        private void MnuBanco_Click(object sender, EventArgs e)
        {
            Problema1 problema1 = new Problema1();
            problema1.MdiParent = this;
            problema1.WindowState = FormWindowState.Maximized;
            problema1.Show();
        }

        private void MnuNumero_Click(object sender, EventArgs e)
        {
            Problema2 problema2 = new Problema2();
            problema2.MdiParent = this;
            problema2.WindowState = FormWindowState.Maximized;
            problema2.Show();
        }

        private void MnuImporte_Click(object sender, EventArgs e)
        {
            Problema3 problema3 = new Problema3();
            problema3.MdiParent = this;
            problema3.WindowState = FormWindowState.Maximized;
            problema3.Show();
        }

        private void MnuSesion_Click(object sender, EventArgs e)
        {
            Problema4 problema4 = new Problema4();
            problema4.MdiParent = this;
            problema4.WindowState = FormWindowState.Maximized;
            problema4.Show();
        }
    }
}
