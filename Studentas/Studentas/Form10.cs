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
    public partial class Form10 : Form
    {
        public int ns;
        public string[] s = new string[100];
        public int nd;
        public string[] d = new string[100];
        TextBox[] texts = new TextBox[100];
        Label[] labels = new Label[100];
        public int done = 0;
        public int padaryta = 0;
        public int[][] p = new int[10][];
        public int snumeris;
        public int m = 0;
        public int n = 0;
        public int x = 0;
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            if (padaryta == 0)
            {
                for (int i = 0; i < nd; i++)
                {
                    var lbl = new Label();
                    labels[i] = lbl;
                    lbl.Name = Convert.ToString(("lbl_" + i));
                    lbl.Text = Convert.ToString(d[i]) + ": ";
                    lbl.Location = new Point(12, 9 + (i * 33));
                    lbl.Visible = true;
                    Controls.Add(lbl);
                }

                while (m < nd)
                {
                    var txt2 = new TextBox();
                    texts[n] = txt2;
                    txt2.Name = Convert.ToString("txt_" + n);
                    txt2.Width = 20;
                    txt2.Location = new Point(150 + (x * 30), 9 + (m * 33));
                    txt2.Visible = true;
                    Controls.Add(txt2);
                    n++;
                    x++;
                    if (x >= 10)
                    {
                        x = 0;
                        m++;
                    }
                }

                done = 1;
                Button button = new Button();
                button.Name = "button";
                button.Text = "Issaugoti";
                button.Location = new Point(12, 6 + (nd * 33));
                button.Visible = true;
                button.Click += new EventHandler(button_Click);
                Controls.Add(button);
            }
            padaryta = 1;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (done == 1)
            {
                int x = 0;
                int v = 0;

                while (v < n)
                {
                    if (x == 0)
                    {
                        p[snumeris] = new int[100];
                    }
                    if (texts[v].Text == "")
                    {
                        p[snumeris][v] = -1;
                        x = 1;
                        v++;
                    }
                    else
                    {
                        p[snumeris][v] = Convert.ToInt32(texts[v].Text);
                        x = 1;
                        v++;
                    }
                }
            }
        }
    }
}
