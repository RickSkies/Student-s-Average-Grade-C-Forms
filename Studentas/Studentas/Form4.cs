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
    public partial class Form4 : Form
    {
        public string[] d = new string[100];
        public int nd;
        TextBox[] texts = new TextBox[100];
        Label[] labels = new Label[100];
        int done = 0;
        public Form4(int nd)
        {
            InitializeComponent();
            this.nd = nd;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            for (int i=0; i<nd; i++)
            {
                var txt2 = new TextBox();
                texts[i] = txt2;
                txt2.Name = Convert.ToString("txt_" + i);
                txt2.Location = new Point(95, 6 + (i*33));
                txt2.Visible = true;
                Controls.Add(txt2);

                var lbl = new Label();
                labels[i] = lbl;
                lbl.Name = Convert.ToString(("lbl_" + i));
                lbl.Text = Convert.ToString(i + 1) + " Dalykas: ";
                lbl.Location = new Point(12, 9 + (i * 33));
                lbl.Visible = true;
                Controls.Add(lbl);
            }

            done = 1;
            Button button = new Button();
            button.Name = "button";
            button.Text = "Issaugoti";
            button.Location = new Point(95, 6 + (nd * 33));
            button.Visible = true;
            button.Click += new EventHandler(button_Click);
            Controls.Add(button);    
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (done == 1)
            {
                for (int i = 0; i < nd; i++)
                {
                    d[i] = texts[i].Text;
                }
            }
        }
    }
}
