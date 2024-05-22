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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();

            frm2.Show();
            this.Hide();
        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        List<string> list = new List<string> {"Regular Push Ups 4 x 10", "Incline Push Ups 4 x 10",
        "Decline Push Ups 4 x 10", "Plyometric Push Ups 4 x 10", "Dumbell Bench Press 4 x 10",
        "Incline Dumbell Bench Press 4 x 10", "Decline Dumbell Bench Press", "Dumbell Chest Flys 4 x 10",
        "Chest Dips 4 x 10", "Wide Push Ups 4 x 5"};
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
