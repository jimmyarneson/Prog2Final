using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2Final
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();

            frm.Show();
            this.Hide();
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        List<string> list = new List<string> {"Dead Lift 4 x 10", "Bent Over Row 3 x 8", "T-Bar Row 4 x 10",
        "Seated Row 4 x 8", "Single Arm Dumbell Row 4 x 8", "Lat Pull Down 4 x 8", "Dumbell Pull Over 4 x 8",
        "Chest Supported Row 4 x 8", "Pull Ups 4 x 8", "Reverse Fly 4 x 8", "Wide Grip Row 4 x 10",
        "Ring Rows 4 x 8"};
        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();


            for (int lcv = 0; lcv < 5; lcv++)
            {
                int r = rnd.Next(list.Count);

                listBox1.Items.Add(list[r]);

                Debug.WriteLine(list.Count);
                list.RemoveAt(r);
                Debug.WriteLine(list.Count);
            }
        }
    }
}
