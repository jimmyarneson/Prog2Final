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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        List<string> list = new List<string> {"Side plank 1 minute each side", "Plank 90 seconds", "Bicycle crunch 1 minute",
            "Russian Twist 90 seconds", "Mountain climbers 1 minute", "Leg raises 2 x 10 reps", "Abdominal crunch 2 x 25 reps"
            , "Windshield wipers 1 minute"};
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();

            frm2.Show();
            this.Hide();
        }

        private void Form9_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

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
