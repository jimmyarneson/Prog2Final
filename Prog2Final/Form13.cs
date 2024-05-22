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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();

            frm2.Show();
            this.Hide();
        }

        private void Form13_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        List<string> list = new List<string> { "Dumbbell Shoulder 3 x 10 reps" ,
        "Pushups 5 x 20 reps", "Lateral Raise 3 x 10 reps", "Dumbell Front Raise 3 x 12 reps",
            "Arnold Presses 3 x 8 reps", "Dumbell Lateral Raise 3 x 15 reps", "Military Press 2 sets of 10 at 25% bodyweight",
            "Push Press 3 x 4-6 reps", "Reverse flys 3 x 15 reps", "Plank 1-2 mins" };
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
