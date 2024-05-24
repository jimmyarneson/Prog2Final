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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        List<string> list = new List<string> {"Bulgarian split squads 2 x 15 reps", "Jump squat 3 x 15 reps",
            "Bodyweight squats 2 x 20 reps", "Calf raise 2 x 20 reps", "Step-ups 3 x 15 reps", "Hip thrusts 3 x 10 reps",
            "Pistol squats 3 x 3 reps", "Speed skaters 2 x 15 each leg" };
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();

            frm2.Show();
            this.Hide();
        }

        private void Form11_FormClosed(object sender, FormClosedEventArgs e)
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
