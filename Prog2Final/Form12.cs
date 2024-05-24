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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        List<string> list = new List<string> { "Squats 2-3 x 12-15 reps", "Leg curls 3 x 12 reps",
            "Deadlift 2 x 8 reps", "Reverse lunges 3 x 8 reps", "Box jumps 3 x 5 reps", "Front squat 3 x 5 reps",
            "Glute bridges 2 x 15 reps", "Leg extension 3 x 12 reps", "Romanian Deadlifts 3 x 12 reps"};
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();

            frm2.Show();
            this.Hide();
        }

        private void Form12_FormClosed(object sender, FormClosedEventArgs e)
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
