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
    public partial class Form3 : Form
    {
        public int nd;
        public string[] d = new string[100];
        public Form3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            nd = Convert.ToInt32(textBox1.Text);
            Form4 childForm = new Form4(nd);
            d = childForm.d;
            childForm.FormClosed += new FormClosedEventHandler(childForm_FormClosed);
            this.Hide();
            childForm.ShowDialog();
        }

        private void childForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
