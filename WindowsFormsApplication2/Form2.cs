using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApplication2.Form1;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            Data.Name = textBox1.Text;
            Data.Adress = textBox2.Text;
            Data.Job = textBox3.Text;
            Data.Education = textBox4.Text;
            Data.Rank = textBox5.Text;
            Data.DateRank = textBox11.Text;
            Data.Post = textBox6.Text;
            Data.Unit = textBox7.Text;
            Data.ServiceForm = textBox8.Text;
            Data.ServicePeriod = textBox9.Text;
            Data.Character = textBox10.Text;
            Data.Ch = 1;
            f.Show();
            this.Hide();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Data.Row >= 0 && Data.Row < table.Count)
            {
                textBox1.Text = Data.Name;
                textBox2.Text = Data.Adress;
                textBox3.Text = Data.Job;
                textBox4.Text = Data.Education;
                textBox5.Text = Data.Rank;
                textBox6.Text = Data.Post;
                textBox7.Text = Data.Unit;
                textBox8.Text = Data.ServiceForm;
                textBox9.Text = Data.ServicePeriod;
                textBox10.Text = Data.Character;
                textBox11.Text = Data.DateRank;
            }
        }
    }
}
