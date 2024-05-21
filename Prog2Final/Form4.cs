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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();

            frm2.Show();
            this.Hide();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        List<string> list = new List<string> {"Preacher Curl 4 x 8", "Concentration Curl 4 x 8" ,
                                              "Cable Curl 4 x 8", "E Z Bar Curls 4 x 8", "Decline Dumbell Curls",
                                              "Chin Ups 3 x 10", "Dips 4 x 8", "Barbell Rows 3 x 10",
                                              "Suspension Trainer Curl 3 x 10", "Close Grip Bench Press 3 x 10",
                                              "Tricep Kick Backs 4 x 8", "Dumbell Floor Press 4 x 8", "Skull Crushers 4 x 8",
                                              "Cable Kick Backs 3 x 10", "Push Ups 4 x 10", "Diamond Push Ups 4 x 10"};
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
