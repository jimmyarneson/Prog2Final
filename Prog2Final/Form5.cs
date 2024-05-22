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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();

            frm.Show();
            this.Hide();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        List<string> list = new List<string> {"Bent Over Row 4 x 8", "Back Extensions 3 x 30 Seconsds",
            "Plank 3 x 30 Seconds", "T-Raises 4 x 8", "Single Arm Dumbell Rows 4 x 8", "Delt Raises 4 x 8",
            "Plank With Laderal Arm Raise 4 x 10 (Each Arm)", "Push Up Hold 3 x 30 Seconds", "Twister 3 x 10",
        "Pilates Press 4 x 8", "Split Stance Row 3 x 30 Seconds", "Plank Pull 3 x 30", };


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
