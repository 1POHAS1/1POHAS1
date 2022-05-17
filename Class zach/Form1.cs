using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_zach
{
    public partial class Form1 : Form
    {
       public Ocenki[] ocenki = new Ocenki[3];

        public Form1()
        {
            InitializeComponent();

            Ocenki ocenkii = new Ocenki();
        
            ocenki[0]= new Ocenki();
            ocenki[0].Set("Математика", "Басков Н.В.", "5");

            ocenki[1] = new Ocenki();
            ocenki[1].Set("Математика", "Васницов Г.С.", "5");

            ocenki[2] = new Ocenki();
            ocenki[2].Set("Математика", "Левшов А.В.", "5");

            for (int i = 0; i < ocenki.Length; i++)
            {
                this.panel1.Controls["label" + 1 + i].Text = ocenki[i].Lessons;
                this.panel1.Controls["label" + 2 + i].Text = ocenki[i].FIO;
                this.panel1.Controls["label" + 3 + i].Text = ocenki[i].Ocenka;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Group Grup = new Group();
            Grup.Show();
        }
    }
}
