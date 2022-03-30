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
    public partial class Form8 : Form
    {
        public int ns;
        public string[] s = new string[100];
        public int nd;
        public string[] d = new string[100];
        public int[][] p = new int[10][];
        Form10 childForm = new Form10();
        public int snumeris;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ns; i++)
            {
                Button button = new Button();
                button.Name = Convert.ToString(i);
                button.Text = s[i];
                button.Location = new Point(12, 6 + (i * 33));
                button.Visible = true;
                button.Click += new EventHandler(button_Click);
                Controls.Add(button);
            }
            childForm.nd = nd;
            childForm.d = d;
            childForm.ns = ns;
            childForm.s = s;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            snumeris = Convert.ToInt32(btn.Name);
            childForm.snumeris = snumeris;
            childForm.FormClosed += new FormClosedEventHandler(childForm_FormClosed);
            this.Hide();
            childForm.ShowDialog();
        }

        private void childForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            p = childForm.p;
            this.Show();
        }
    }
}
