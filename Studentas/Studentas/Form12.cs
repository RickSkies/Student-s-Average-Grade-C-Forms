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
    public partial class Form12 : Form
    {
        public int ns;
        public string[] s = new string[100];
        public Vidurkiai[] vidurkiai = new Vidurkiai[10];
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ns; i++)
            {
                Button button = new Button();
                button.Name = Convert.ToString(Convert.ToString(i));
                button.Text = s[i];
                button.Location = new Point(12, 6 + (i * 33));
                button.Visible = true;
                button.Click += new EventHandler(button_Click);
                Controls.Add(button);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int vidurkis = Convert.ToInt32(btn.Name);
            MessageBox.Show(Convert.ToString("Vidurkis: " + vidurkiai[vidurkis].v));
        }
    }
}
