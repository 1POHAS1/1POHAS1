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
        public Form1()
        {
            InitializeComponent();
            pictureBox2.Load("../../Pictures/" + imgList[0]);
            pictureBox3.Load("../../Pictures/" + imgList[1]);
            pictureBox4.Load("../../Pictures/" + imgList[2]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            index++;
            if (index == 3) index = 0;
            pictureBox2.Load("../../Pictures/" + imgList[index + 0]);
            pictureBox3.Load("../../Pictures/" + imgList[index + 1]);
            pictureBox4.Load("../../Pictures/" + imgList[index + 2]);
        }
    }
}
