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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }
        List<string> list = new List<string> { "Dumbell Press 2 x 12-15 reps", "Lateral Raise 3x8 reps",
            "Overhead press 3 x 5 reps", "Face pull 3 x 15 reps", "Shoulder press 3 x 8 reps", "Barbell shrugs 5 x 10 reps",
            "Seated row 12-15 reps", "Rear delt reps 2 x 8 reps"};
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();

            frm2.Show();
            this.Hide();
        }

        private void Form14_FormClosed(object sender, FormClosedEventArgs e)
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
