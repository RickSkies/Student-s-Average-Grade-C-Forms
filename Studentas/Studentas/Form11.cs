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
    public partial class Form11 : Form
    {
        public int ns;
        public string[] s = new string[100];
        public int nd;
        public string[] d = new string[100];
        TextBox[] texts = new TextBox[100];
        Label[] labels = new Label[100];
        public int done = 0;
        public int padaryta = 0;
        public int[][] k = new int[10][];
        public int snumeris;
        public int x = 0;
        public int v = 0;
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            if (padaryta == 0)
            {
                x = 0;
                v = 0;
                for (int i = 0; i < nd; i++)
                {
                    var lbl = new Label();
                    labels[i] = lbl;
                    lbl.Name = Convert.ToString(("lbl_" + i));
                    lbl.Text = Convert.ToString(d[i]) + ": ";
                    lbl.Location = new Point(12, 9 + (i * 33));
                    lbl.Visible = true;
                    Controls.Add(lbl);

                    var txt2 = new TextBox();
                    texts[i] = txt2;
                    txt2.Name = Convert.ToString("txt_" + i);
                    txt2.Location = new Point(150, 6 + (i * 33));
                    txt2.Visible = true;
                    Controls.Add(txt2);
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
                int v = 0;
                int x = 0;

                while (v < nd)
                {
                    if (x == 0)
                    {
                        k[snumeris] = new int[100];
                        x = 1;
                    }
                    if (x == 1)
                    {
                        k[snumeris][v] = Convert.ToInt32(texts[v].Text);
                        v++;
                        x = 1;
                    }
                    else
                    {
                        k[snumeris][v] = Convert.ToInt32(texts[v].Text);
                        v++;
                        x = 1;
                    }
                }
            }
        }
    }
}
