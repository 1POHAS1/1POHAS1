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
    public partial class Form1 : Form
    {
        String[] imgList = new String[]
            {"1.jpeg", "2.jpg", "3.jpg", "1.jpeg", "2.jpg"};
        int index = 0;

        Country[] countries = new Country[5];

        Player[] players = new Player[5];
        public Form1()
        {
            InitializeComponent();
            pictureBox2.Load("../../Pictures/" + imgList[0]);
            pictureBox3.Load("../../Pictures/" + imgList[1]);
            pictureBox4.Load("../../Pictures/" + imgList[2]);


                Country country = new Country();

                // 5 элементов
                country.Set("ARG", "Argentina");
                countries[0] = country;

                country.Set("AT", "Austria");
                countries[1] = country;

                country.Set("AUS", "Australia");
                countries[2] = country;

                country.Set("BI", "Bosnia");
                countries[3] = country;

                country.Set("BIH", "Bosnia Herzegovina");
                countries[4] = country;
            
                Player player = new Player();

            player.Set(1, "Mo Williams", 1, "23.05.2000", 1.85, 89.8, "19.12.1982", "US", "M");
            players[0] = player;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            index++;
            if (index == 3) index = 0;
            pictureBox2.Load("../../Pictures/" + imgList[index + 0]);
            pictureBox3.Load("../../Pictures/" + imgList[index + 1]);
            pictureBox4.Load("../../Pictures/" + imgList[index + 2]);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            index--;
            if (index == -1) index = 2;
            pictureBox2.Load("../../Pictures/" + imgList[index + 0]);
            pictureBox3.Load("../../Pictures/" + imgList[index + 1]);
            pictureBox4.Load("../../Pictures/" + imgList[index + 2]);
        }
    }
}
