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


        List<string> list = new List<string> {"Over Head Tricep Extensions 4 x 8",
                "Bicep Curls 4 x 8", "Tricep Kick Backs 4 x 8", "Push Ups 4 x 10",
                "Body Weight Dips 4 x 12", "Side Planks 3 x 30 seconds", "Barbell Curls 4 x 8",
                "Pull ups 3 x 10", "Over Head Press 4 x 8", "Isometric Bicep Hold 3 x 30 Seconds",
                "Dumbell Punch 3 x 10"};
        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();


            for (int lcv = 0 ; lcv < 5; lcv++)
            {
                int r = rnd.Next(list.Count);

                listBox1.Items.Add(list[r]);

                Debug.WriteLine(list.Count);
                list.RemoveAt(r);
                Debug.WriteLine(list.Count);
            }

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
