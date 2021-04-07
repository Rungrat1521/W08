using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class TextAlbum : Form
    {
        public TextAlbum()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            string[] row0 = { "11/22/1968", "29", "Revolution 9",
            "Beatles", "The Beatles [White Album]" };
            string[] row1 = { "1960", "6", "Fools Rush In",
            "Frank Sinatra", "Nice 'N' Easy" };
            string[] row2 = { "11/11/1971", "1", "One of These Days",
            "Pink Floyd", "Meddle" };
            string[] row3 = { "1988", "7", "Where Is My Mind?",
            "Pixies", "Surfer Rosa" };
            string[] row4 = { "5/1981", "9", "Can't Find My Mind",
            "Cramps", "Psychedelic Jungle" };
            string[] row5 = { "6/10/2003", "13",
            "Scatterbrain. (As Dead As Leaves.)",
            "Radiohead", "Hail to the Thief" };
            string[] row6 = { "6/30/1992", "3", "Dress", "P J Harvey", "Dry" };

            dataGridViewDemo.Rows.Add(row0);
            dataGridViewDemo.Rows.Add(row1);
            dataGridViewDemo.Rows.Add(row2);
            dataGridViewDemo.Rows.Add(row3);
            dataGridViewDemo.Rows.Add(row4);
            dataGridViewDemo.Rows.Add(row5);
            dataGridViewDemo.Rows.Add(row6);

            dataGridViewDemo.Columns[0].DisplayIndex = 0;
            dataGridViewDemo.Columns[1].DisplayIndex = 1;
            dataGridViewDemo.Columns[2].DisplayIndex = 2;
            dataGridViewDemo.Columns[3].DisplayIndex = 3;
            dataGridViewDemo.Columns[4].DisplayIndex = 4;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewDemo.SelectedRows.Count > 0 &&
                this.dataGridViewDemo.SelectedRows[0].Index !=
                this.dataGridViewDemo.Rows.Count - 1)
            {
                this.dataGridViewDemo.Rows.RemoveAt(
                    this.dataGridViewDemo.SelectedRows[0].Index);
            }
        }
        private void SetupLayout()
        {
            this.Size = new Size(600, 500);

            btnAdd.Text = "Add Row";
            btnAdd.Location = new Point(10, 10);
            btnAdd.Click += new EventHandler(btnAdd_Click);

            btnDelete.Text = "Delete Row";
            btnDelete.Location = new Point(100, 10);
            btnDelete.Click += new EventHandler(btnDelete_Click);

            btnPanel.Controls.Add(btnAdd);
            btnPanel.Controls.Add(btnDelete);
            btnPanel.Height = 50;
            btnPanel.Dock = DockStyle.Bottom;

            this.Controls.Add(this.btnPanel);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataGridViewDemo.Rows.Add(this);
        }
            private void btnCustomPopulate_Click(object sender, EventArgs e)
        //Album Artist Title Track ReleaseDate
        {

            Album a1 = new Album();

            dataGridViewDemo.Rows.Add(a1.aa);
            dataGridViewDemo.Rows.Add(a1.bb);
            dataGridViewDemo.Rows.Add(a1.cc);
            dataGridViewDemo.Rows.Add(a1.dd);
            dataGridViewDemo.Rows.Add(a1.ee);
            dataGridViewDemo.Rows.Add(a1.ff);
        }

        private void btnDeleteAllrow_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will delete all rows in DataGridView, Confirm?", "Confirm Delete?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                MessageBox.Show("Rows Deleted");
                dataGridViewDemo.Rows.Clear();
            }
            else
            {
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Exit Program?", "Exit Program", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNewpopulate_Click(object sender, EventArgs e)
        {
            string talbum = abtext.Text;
            string tartist = TextArtist.Text;
            string ttitle = TextTitle.Text;
            string ttrack = TextTrack.Text;
            string tdate = DateTime.Now.ToString();
            dataGridViewDemo.Rows.Add(talbum, tartist, ttitle, ttrack, tdate);
        }
    }
}
