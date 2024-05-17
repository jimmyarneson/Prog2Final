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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form14 frm14 = new Form14();
            Form13 frm13 = new Form13();
            Form12 frm12 = new Form12();
            Form11 frm11 = new Form11();
            Form10 frm10 = new Form10();
            Form9 frm9 = new Form9();
            Form8 frm8 = new Form8();
            Form7 frm7 = new Form7();
            Form6 frm6 = new Form6();
            Form5 frm5 = new Form5();
            Form4 frm4 = new Form4();
            Form3 frm3 = new Form3();

            if (radioButton1.Checked && radioButton4.Checked)
            {
                frm3.Show();
                this.Hide();
            }
            else if (radioButton2.Checked && radioButton4.Checked)
            {
                frm4.Show();
                this.Hide();
            }
            else if (radioButton1.Checked && radioButton3.Checked)
            {
                frm5.Show();
                this.Hide();
            }
            else if (radioButton2.Checked && radioButton3.Checked)
            {
                frm6.Show();
                this.Hide();
            }
            else if (radioButton1.Checked && radioButton5.Checked)
            {
                frm7.Show();
                this.Hide();
            }
            else if (radioButton2.Checked && radioButton5.Checked)
            {
                frm8.Show();
                this.Hide();
            }
            else if (radioButton1.Checked && radioButton6.Checked)
            {
                frm9.Show();
                this.Hide();
            }
            else if (radioButton2.Checked && radioButton6.Checked)
            {
                frm10.Show();
                this.Hide();
            }
            else if (radioButton1.Checked && radioButton7.Checked)
            {
                frm11.Show();
                this.Hide();
            }
            else if (radioButton2.Checked && radioButton7.Checked)
            {
                frm12.Show();
                this.Hide();
            }
            else if (radioButton1.Checked && radioButton8.Checked)
            {
                frm13.Show();
                this.Hide();
            }
            else if (radioButton2.Checked && radioButton8.Checked)
            {
                frm14.Show();
                this.Hide();
            }

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
    }

