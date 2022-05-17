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
    public partial class Group : Form
    {
       public static Groups[] group = new Groups[3];

        public Group()
        {
            InitializeComponent();

            Groups grups = new Groups();

            group[0]= new Groups();
            group[0].Set(1, "ONE", "ПИ");

            group[1]= new Groups();
            group[1].Set(2, "TWO", "ИИСТ");

            group[2]= new Groups();
            group[2].Set(3, "THREE", "ФИОП");

        }

        private void Group_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < group.Length; i++)
            {
                dataGridView1.Rows.Add(group[i].StudentId, group[i].Shifr, group[i].Napravl);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
