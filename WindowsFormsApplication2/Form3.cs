using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static WindowsFormsApplication2.Form1;

namespace WindowsFormsApplication2
{
    public partial class Form3 : Form
    {
        static List<person> table1 = new List<person>();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (Data.WhatSearch == "all")
            {
                for (int i = 0; i < table.Count; i++)
                {
                    if (table[i].Name.Contains(Data.Search)) { dataGridView1.Rows.Add(table[i].Name, table[i].Adress, table[i].Job, table[i].Education, table[i].Rank, table[i].DateRank, table[i].Post, table[i].Unit, table[i].ServiceForm, table[i].ServicePeriod, table[i].Character); Table1Add(i); continue; }
                    if (table[i].Adress.Contains(Data.Search)) { dataGridView1.Rows.Add(table[i].Name, table[i].Adress, table[i].Job, table[i].Education, table[i].Rank, table[i].DateRank, table[i].Post, table[i].Unit, table[i].ServiceForm, table[i].ServicePeriod, table[i].Character); Table1Add(i); continue; }
                    if (table[i].Job.Contains(Data.Search)) { dataGridView1.Rows.Add(table[i].Name, table[i].Adress, table[i].Job, table[i].Education, table[i].Rank, table[i].DateRank, table[i].Post, table[i].Unit, table[i].ServiceForm, table[i].ServicePeriod, table[i].Character); Table1Add(i); continue; }
                    if (table[i].Education.Contains(Data.Search)) { dataGridView1.Rows.Add(table[i].Name, table[i].Adress, table[i].Job, table[i].Education, table[i].Rank, table[i].DateRank, table[i].Post, table[i].Unit, table[i].ServiceForm, table[i].ServicePeriod, table[i].Character); Table1Add(i); continue; }
                    if (table[i].Rank.Contains(Data.Search)) { dataGridView1.Rows.Add(table[i].Name, table[i].Adress, table[i].Job, table[i].Education, table[i].Rank, table[i].DateRank, table[i].Post, table[i].Unit, table[i].ServiceForm, table[i].ServicePeriod, table[i].Character); Table1Add(i); continue; }
                    if (table[i].DateRank.Contains(Data.Search)) { dataGridView1.Rows.Add(table[i].Name, table[i].Adress, table[i].Job, table[i].Education, table[i].Rank, table[i].DateRank, table[i].Post, table[i].Unit, table[i].ServiceForm, table[i].ServicePeriod, table[i].Character); Table1Add(i); continue; }
                    if (table[i].Post.Contains(Data.Search)) { dataGridView1.Rows.Add(table[i].Name, table[i].Adress, table[i].Job, table[i].Education, table[i].Rank, table[i].DateRank, table[i].Post, table[i].Unit, table[i].ServiceForm, table[i].ServicePeriod, table[i].Character); Table1Add(i); continue; }
                    if (table[i].Unit.Contains(Data.Search)) { dataGridView1.Rows.Add(table[i].Name, table[i].Adress, table[i].Job, table[i].Education, table[i].Rank, table[i].DateRank, table[i].Post, table[i].Unit, table[i].ServiceForm, table[i].ServicePeriod, table[i].Character); Table1Add(i); continue; }
                    if (table[i].ServiceForm.Contains(Data.Search)) { dataGridView1.Rows.Add(table[i].Name, table[i].Adress, table[i].Job, table[i].Education, table[i].Rank, table[i].DateRank, table[i].Post, table[i].Unit, table[i].ServiceForm, table[i].ServicePeriod, table[i].Character); Table1Add(i); continue; }
                    if (table[i].ServicePeriod.Contains(Data.Search)) { dataGridView1.Rows.Add(table[i].Name, table[i].Adress, table[i].Job, table[i].Education, table[i].Rank, table[i].DateRank, table[i].Post, table[i].Unit, table[i].ServiceForm, table[i].ServicePeriod, table[i].Character); Table1Add(i); continue; }
                    if (table[i].Character.Contains(Data.Search)) { dataGridView1.Rows.Add(table[i].Name, table[i].Adress, table[i].Job, table[i].Education, table[i].Rank, table[i].DateRank, table[i].Post, table[i].Unit, table[i].ServiceForm, table[i].ServicePeriod, table[i].Character); Table1Add(i); continue; }
                }
            }
            else if (Data.WhatSearch == "unit")
            {
                for (int i = 0; i < table.Count; i++)
                {
                    if (table[i].Unit == (Data.Search)) { dataGridView1.Rows.Add(table[i].Name, table[i].Adress, table[i].Job, table[i].Education, table[i].Rank, table[i].DateRank, table[i].Post, table[i].Unit, table[i].ServiceForm, table[i].ServicePeriod, table[i].Character); Table1Add(i); }
                }
            }
            else if (Data.WhatSearch == "rank")
            {
                for (int i = 0; i < table.Count; i++)
                {
                    if (table[i].Rank == Data.Search) { dataGridView1.Rows.Add(table[i].Name, table[i].Adress, table[i].Job, table[i].Education, table[i].Rank, table[i].DateRank, table[i].Post, table[i].Unit, table[i].ServiceForm, table[i].ServicePeriod, table[i].Character); Table1Add(i); }
                }
            }
        }

        private void Table1Add(int i)
        {
            person p1 = new person(table[i].Name, table[i].Adress, table[i].Job, table[i].Education, table[i].Rank, table[i].DateRank, table[i].Post, table[i].Unit, table[i].ServiceForm, table[i].ServicePeriod, table[i].Character);
            table1.Add(p1);
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            XmlSerializer formatter = new XmlSerializer(typeof(List<person>));
            using (FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, table1);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Ви впевнені, що хочете видалити цей рядок?", "Попередження", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                int row = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(row);
                table1.RemoveAt(row);
            }
        }
    }
}
