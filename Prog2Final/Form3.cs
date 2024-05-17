using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2Final
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();

            frm2.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int num1 = 1;
            if (num1 == 1) ;
            listBox1.Items.Add("Alternating curls 3 sets x 8 reps\nAlternating barbell culrs 3 stes x 20 reps\nCable rope hammer curls 3 sets x 10 reps\nDumbbell kickback 3 sets x 10 reps");

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)

        {

        }
    }
}
