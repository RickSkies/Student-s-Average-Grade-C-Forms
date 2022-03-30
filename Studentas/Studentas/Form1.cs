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
    public partial class Form1 : Form
    {
        public string pavadinimas;
        public int semestras;
        public int nd;
        public int ns;
        public int[][] p = new int[10][];
        public string[] s = new string[100];
        public string[] d = new string[100];
        public int[][] k = new int[10][];
        Form2 childForm = new Form2();
        Form7 childForm2 = new Form7();
        Form12 childForm3 = new Form12();
        public int d1 = 0;
        public int baigta = 0;
        Student[] student = new Student[10];
        Dalykas[] dalykas = new Dalykas[10];
        Pazymis[] pazymis = new Pazymis[10];
        Kreditai[] kreditai = new Kreditai[10];
        public Vidurkiai[] vidurkiai = new Vidurkiai[10];
        public Form1()
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
            pavadinimas = childForm.pavadinimas;
            semestras = childForm.semestras;
            nd = childForm.nd;
            ns = childForm.ns;
            s = childForm.s;
            d = childForm.d;
            childForm2.s = s;
            childForm2.ns = ns;
            childForm2.nd = nd;
            childForm2.d = d;
            d1 = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (d1 == 0)
            {
                MessageBox.Show("Ispirmo reikia sukurti grupe!");
            }
            else
            {
                childForm2.FormClosed += new FormClosedEventHandler(childForm2_FormClosed);
                this.Hide();
                childForm2.ShowDialog();
            }
        }

        private void childForm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            p = childForm2.p;
            k = childForm2.k;
            for (int i = 0; i < 2; i++)
            baigta = 1;
            this.Show();
            if (baigta == 1)
            {
                for (int i = 0; i < ns; i++)
                {
                    student[i] = new Student(s[i], ns);
                }

                for (int i = 0; i < nd; i++)
                {
                    dalykas[i] = new Dalykas(d[i], nd);
                }

                for (int i = 0; i < ns; i++)
                {
                    pazymis[i] = new Pazymis(p[i]);
                }

                for (int i = 0; i < nd; i++)
                {
                    kreditai[i] = new Kreditai(k[i]);
                }

                for (int i = 0; i < ns; i++)
                {
                    int vidurkis;
                    int suma = 0;
                    int sandaugosSuma = 0;
                    int kredituSuma = 0;
                    int dabar = 0;
                    for (int j = 0; j < 10 * nd; j++)
                    {
                        //if (pazymis[i].p[j] == -1)
                        if (p[i][j] == -1)
                        {
                            if (j % 10 == 0 || j == (10 * nd) - 1)
                            {
                                //sandaugosSuma += suma * kreditai[i].k[dabar];
                                //kredituSuma += kreditai[i].k[dabar];
                                sandaugosSuma += suma * k[i][dabar];
                                kredituSuma += k[i][dabar];
                                dabar++;
                            }
                            continue;
                        }
                        else
                        {
                            if (j % 10 == 0 || j == (10 * nd) - 1)
                            {
                                //sandaugosSuma += suma * kreditai[i].k[dabar];
                                //kredituSuma += kreditai[i].k[dabar];
                                sandaugosSuma += suma * k[i][dabar];
                                kredituSuma += k[i][dabar];
                                dabar++;
                            }
                            //suma += pazymis[i].p[j];
                            suma += p[i][j];
                        }
                    }
                    vidurkis = sandaugosSuma / kredituSuma;
                    vidurkiai[i] = new Vidurkiai(vidurkis);
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (d1 == 0)
            {
                MessageBox.Show("Ispirmo reikia sukurti grupe!");
            }
            else
            {
                childForm3.s = s;
                childForm3.ns = ns;
                childForm3.vidurkiai = vidurkiai;
                childForm3.FormClosed += new FormClosedEventHandler(childForm3_FormClosed);
                this.Hide();
                childForm3.ShowDialog();
            }
        }

        private void childForm3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int vidurkis = 0;
            for (int i = 0; i < ns; i++)
            {
                vidurkis += vidurkiai[i].v;
            }
            vidurkis = vidurkis / ns;
            MessageBox.Show(Convert.ToString("Grupes vidurkis: " + vidurkis));
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            int nsns = ns;
            int[] vidurkis = new int[10];
            for (int i = 0; i < ns; i++)
            {
                vidurkis[i] = vidurkiai[i].v;
            }

            int temp = 0;

            for (int i = 0; i < ns; i++)
            {
                for (int j = 0; j < ns - 1; j++)
                {
                    if (vidurkis[j] < vidurkis[j + 1])
                    {
                        temp = vidurkis[j + 1];
                        vidurkis[j + 1] = vidurkis[j];
                        vidurkis[j] = temp;
                    }
                }
            }
            MessageBox.Show(Convert.ToString("Top 3 Vidurkiai:" + "\r\n" + vidurkis[0]) + "\r\n" + vidurkis[1] + "\r\n" + vidurkis[2]);
        }
    }
}
