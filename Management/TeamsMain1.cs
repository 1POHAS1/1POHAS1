using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management
{
    public partial class TeamsMain1 : Form
    {
        String[] imgList = new String[]
        {
            "1.jpg", "2.jpg"
        };
        int index = 0;
        Team[] teams = new Team[5];
        public TeamsMain1()
        {
            InitializeComponent();

            Team team = new Team();

            teams[0] = new Team();
            teams[0].Set(1, "Miami Heat", "MIA", "1.jpg");

            teams[1] = new Team();
            teams[1].Set(2, "Orlando Magic", "ORL", "2.jpg");

            teams[2] = new Team();
            teams[2].Set(3, "Atlanta Hawks", "ATL", "3.jpg");

            teams[3] = new Team();
            teams[3].Set(4, "Washington Wizards", "WSH", "4.jpg");

            teams[4] = new Team();
            teams[4].Set(5, "Charlotte Hornets", "CHA", "5.jpg");

            label10.Text = teams[0].Name;
            /*   label11.Text = teams[1].Name;
               label12.Text = teams[2].Name;
               label13.Text = teams[3].Name;
               label14.Text = teams[4].Name;*/

            //for (int i=0; i<5; i++)
           // panel1.Controls["panel2"].Controls["panel3"].Controls["tabControl1"].Controls["tabPage1"].Controls["label"+10].Text = teams[0].Name;
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
