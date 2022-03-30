using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentas
{
    public partial class Form7 : Form
    {
        public int ns;
        public string[] s = new string[100];
        public int nd;
        public string[] d = new string[100];
        public int[][] p = new int[10][];
        public int[][] k = new int[10][];
        Form8 childForm = new Form8();
        Form9 childForm2 = new Form9();
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            childForm.nd = nd;
            childForm.d = d;
            childForm.ns = ns;
            childForm.s = s;
            childForm.FormClosed += new FormClosedEventHandler(childForm_FormClosed);
            this.Hide();
            childForm.ShowDialog();
        }

        private void childForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            p = childForm.p;
            this.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            childForm2.nd = nd;
            childForm2.d = d;
            childForm2.ns = ns;
            childForm2.s = s;
            childForm2.FormClosed += new FormClosedEventHandler(childForm2_FormClosed);
            this.Hide();
            childForm2.ShowDialog();
        }

        private void childForm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            k = childForm2.k;
            this.Show();
        }
    }
}
