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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        List<string> list = new List<string> {"Cable rotation 3 x 10 reps", "Decline situps 3 x 30 reps", "Palloff press 3 x 15 reps",
            "Hanging knee raises 3 x 15 reps", "Barbell Rollout 2 x 10-30 reps", "Crable crunch 2 x 10 reps", "Machine crunch 2 x 10 reps" };
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();

            frm2.Show();
            this.Hide();
        }

        private void Form10_FormClosed(object sender, FormClosedEventArgs e)
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
