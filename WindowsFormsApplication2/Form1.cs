using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public static List<person> table = new List<person>();

        public Form1()
        {
            InitializeComponent();
        }

        [Serializable]
        public class person
        {
            public string Name { get; set; }
            public string Adress { get; set; }
            public string Job { get; set; }
            public string Education { get; set; }
            public string Rank { get; set; }
            public string DateRank { get; set; }
            public string Post { get; set; }
            public string Unit { get; set; }
            public string ServiceForm { get; set; }
            public string ServicePeriod { get; set; }
            public string Character { get; set; }

            public person(string n, string a, string j, string e, string r, string d, string p, string u, string sf, string sp, string c)
            {
                Name = n;
                Adress = a;
                Job = j;
                Education = e;
                Rank = r;
                DateRank = d;
                Post = p;
                Unit = u;
                ServiceForm = sf;
                ServicePeriod = sp;
                Character = c;
            }

            public person() { }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            if (Data.Ch == 1 && (Data.Row < 0 || Data.Row >= table.Count))
            {
                person p1 = new person(Data.Name, Data.Adress, Data.Job, Data.Education, Data.Rank, Data.DateRank, Data.Post, Data.Unit, Data.ServiceForm, Data.ServicePeriod, Data.Character);
                table.Add(p1);
                Data.Ch = 0;
            }

            else if (Data.Row >= 0 && Data.Row < table.Count)
            {
                table[Data.Row] = new person(Data.Name, Data.Adress, Data.Job, Data.Education, Data.Rank, Data.DateRank, Data.Post, Data.Unit, Data.ServiceForm, Data.ServicePeriod, Data.Character);
                Data.Row = -1;
            }

            for (int i = 0; i < table.Count; i++)
            {
                dataGridView1.Rows.Insert(i, table[i].Name, table[i].Adress, table[i].Job, table[i].Education, table[i].Rank, table[i].DateRank, table[i].Post, table[i].Unit, table[i].ServiceForm, table[i].ServicePeriod, table[i].Character);
            }

            //if (Data.Ch == 2)
            //{
            //    //try
            //    {
            //        int ind = 0;
            //        for (int i = 0; i < table.Count; i++)
            //        {
            //            if (table[i].Name.Contains(txtSearch.Text)) { dataGridView1.Rows.Add(ind, table[i].Name, table[i].Adress, table[i].Job, table[i].Education, table[i].Rank, table[i].DateRank, table[i].Post, table[i].Unit, table[i].ServiceForm, table[i].ServicePeriod, table[i].Character); ind++; break; }
            //            if (table[i].Adress.Contains(txtSearch.Text)) { dataGridView1.Rows.Add(ind, table[i].Name, table[i].Adress, table[i].Job, table[i].Education, table[i].Rank, table[i].DateRank, table[i].Post, table[i].Unit, table[i].ServiceForm, table[i].ServicePeriod, table[i].Character); ind++; break; }
            //            if (table[i].Job.Contains(txtSearch.Text)) { dataGridView1.Rows.Add(ind, table[i].Name, table[i].Adress, table[i].Job, table[i].Education, table[i].Rank, table[i].DateRank, table[i].Post, table[i].Unit, table[i].ServiceForm, table[i].ServicePeriod, table[i].Character); ind++; break; }
            //            if (table[i].Education.Contains(txtSearch.Text)) { dataGridView1.Rows.Add(ind, table[i].Name, table[i].Adress, table[i].Job, table[i].Education, table[i].Rank, table[i].DateRank, table[i].Post, table[i].Unit, table[i].ServiceForm, table[i].ServicePeriod, table[i].Character); ind++; break; }
            //            if (table[i].Rank.Contains(txtSearch.Text)) { dataGridView1.Rows.Add(ind, table[i].Name, table[i].Adress, table[i].Job, table[i].Education, table[i].Rank, table[i].DateRank, table[i].Post, table[i].Unit, table[i].ServiceForm, table[i].ServicePeriod, table[i].Character); ind++; break; }
            //            if (table[i].DateRank.Contains(txtSearch.Text)) { dataGridView1.Rows.Add(ind, table[i].Name, table[i].Adress, table[i].Job, table[i].Education, table[i].Rank, table[i].DateRank, table[i].Post, table[i].Unit, table[i].ServiceForm, table[i].ServicePeriod, table[i].Character); ind++; break; }
            //            if (table[i].Post.Contains(txtSearch.Text)) { dataGridView1.Rows.Add(ind, table[i].Name, table[i].Adress, table[i].Job, table[i].Education, table[i].Rank, table[i].DateRank, table[i].Post, table[i].Unit, table[i].ServiceForm, table[i].ServicePeriod, table[i].Character); ind++; break; }
            //            if (table[i].Unit.Contains(txtSearch.Text)) { dataGridView1.Rows.Add(ind, table[i].Name, table[i].Adress, table[i].Job, table[i].Education, table[i].Rank, table[i].DateRank, table[i].Post, table[i].Unit, table[i].ServiceForm, table[i].ServicePeriod, table[i].Character); ind++; break; }
            //            if (table[i].ServiceForm.Contains(txtSearch.Text)) { dataGridView1.Rows.Add(ind, table[i].Name, table[i].Adress, table[i].Job, table[i].Education, table[i].Rank, table[i].DateRank, table[i].Post, table[i].Unit, table[i].ServiceForm, table[i].ServicePeriod, table[i].Character); ind++; break; }
            //            if (table[i].ServicePeriod.Contains(txtSearch.Text)) { dataGridView1.Rows.Add(ind, table[i].Name, table[i].Adress, table[i].Job, table[i].Education, table[i].Rank, table[i].DateRank, table[i].Post, table[i].Unit, table[i].ServiceForm, table[i].ServicePeriod, table[i].Character); ind++; break; }
            //            if (table[i].Character.Contains(txtSearch.Text)) { dataGridView1.Rows.Add(ind, table[i].Name, table[i].Adress, table[i].Job, table[i].Education, table[i].Rank, table[i].DateRank, table[i].Post, table[i].Unit, table[i].ServiceForm, table[i].ServicePeriod, table[i].Character); ind++; break; }
            //        }
            //        ind = 0;
            //    }
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            //}
        }

        private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            XmlSerializer formatter = new XmlSerializer(typeof(List<person>));
            using (FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.OpenOrCreate))
            {

                table = (List<person>)formatter.Deserialize(fs);
                dataGridView1.Rows.Clear();
                for (int i = 0; i < table.Count; i++)
                {

                    dataGridView1.Rows.Insert(i, table[i].Name, table[i].Adress, table[i].Job, table[i].Education, table[i].Rank, table[i].DateRank, table[i].Post, table[i].Unit, table[i].ServiceForm, table[i].ServicePeriod, table[i].Character);
                }
                //MessageBox.Show("Объект десериализован");

            }
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
                formatter.Serialize(fs, table);

               // MessageBox.Show("Объект сериализован");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow >= 0 && indexRow < table.Count)
            {
                Data.Name = table[indexRow].Name;
                Data.Adress = table[indexRow].Adress;
                Data.Job = table[indexRow].Job;
                Data.Education = table[indexRow].Education;
                Data.Rank = table[indexRow].Rank;
                Data.DateRank = table[indexRow].DateRank;
                Data.Post = table[indexRow].Post;
                Data.Unit = table[indexRow].Unit;
                Data.ServiceForm = table[indexRow].ServiceForm;
                Data.ServicePeriod = table[indexRow].ServicePeriod;
                Data.Character = table[indexRow].Character;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Data.Row = -1;
            Form2 f = new Form2();
            f.Show();
            Hide();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(row);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Data.Row = dataGridView1.CurrentCell.RowIndex;
            Form2 f = new Form2();
            f.Show();
            Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                Data.Search = txtSearch.Text;
                Form3 f = new Form3();
                f.Show();
            }
        }
    }
}
