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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();

            frm.Show();
            this.Hide();
        }

        private void Form8_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        List<string> list = new List<string> {"Barbell Bench Press 4 x 8", "Dumbell Bench Press 4 x 8",
        "Incline Barbell Bench Press 4 x 8", "Decline Barbell Bench Press 4 x 8", "Machine Chest Press 4 x 8",
        "Push Ups 4 x 8", "Dips 4 x 8", "Chest Flys 4 x 8", "Dumbell Pull Over 4 x 8", "Machine Chest Fly 4 x 10",
        "Cable Cross Over 4 x 8", "Incline Dumbell Bench Press 4 x 8", "Decline Dumbell Bench Press 4 x 8"};
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
