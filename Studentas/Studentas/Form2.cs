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
    public partial class Form2 : Form
    {
        public string pavadinimas;
        public int semestras;
        public int nd;
        public int ns;
        public string[] s = new string[100];
        public string[] d = new string[100];
        Form3 childForm = new Form3();
        Form5 childForm2 = new Form5();
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            childForm.FormClosed += new FormClosedEventHandler(childForm_FormClosed);
            this.Hide();
            childForm.ShowDialog();
        }

        private void childForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            d = childForm.d;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            pavadinimas = textBox1.Text;
            semestras = Convert.ToInt32(textBox2.Text);
            nd = childForm.nd;
            ns = childForm2.ns;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            childForm2.FormClosed += new FormClosedEventHandler(childForm2_FormClosed);
            this.Hide();
            childForm2.ShowDialog();
        }

        private void childForm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            s = childForm2.s;
            this.Show();
        }
    }
}
