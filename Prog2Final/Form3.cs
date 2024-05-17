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
            Random rnd = new Random();

            List<string> list = new List<string> {"Over Head Tricep Extensions 4 x 8",
                "Bicep Curls 4 x 8", "Tricep Kick Backs 4 x 8", "Push Ups 4 x 10",
                "Body Weight Dips 4 x 12", "Side Planks 3 x 30 seconds", "Barbell Curls 4 x 8"};

            int random = rnd.Next(1,5);

            listBox1.Text = ((String)list[random]);

            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
