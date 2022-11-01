using AlbumAddEditDelete.DAL;
using assignment2prn.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace assignment2prn.GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bindGrid();
        }

        private void bindGrid()
        {
            foreach (DataRow data in GenreDAO.GetInstance().GetDataTable().Rows)
            {
                comboBox1.Items.Add(data["Name"].ToString());
            }
            DataTable dt = AlbumDAO.GetInstance().GetDataTable();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = dt;
            int count = dataGridView1.Columns.Count;
            int countRow = dataGridView1.Rows.Count;
            label3.Text = (countRow).ToString();

            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn
            {
                Text = "Edit",
                Name = "Edit",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Insert(count, btnEdit);
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn
            {
                Text = "Delete",
                Name = "Delete",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Insert(count + 1, btnDelete);
            dataGridView1.AllowUserToAddRows = false;

        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlbumDAO albumDAO = AlbumDAO.GetInstance();
            Album album = new Album
            {
                GenreId = comboBox1.SelectedIndex + 1,
                Title = textBox1.Text.Trim()
            };
            DataTable dt = albumDAO.GetDataTableByGenreAndTitle(album);
            dataGridView1.Columns.Clear();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = dt;
            int count = dataGridView1.Columns.Count;
            int countRow = dataGridView1.Rows.Count;
            label3.Text = (countRow).ToString();
            
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn
            {
                Text = "Edit",
                Name = "Edit",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Insert(count, btnEdit);
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn
            {
                Text = "Delete",
                Name = "Delete",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Insert(count + 1, btnDelete);
            dataGridView1.AllowUserToAddRows = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 AlbumAddEditGUI = new Form2(-1);
            DialogResult dialogResult = AlbumAddEditGUI.ShowDialog();
            if (dialogResult == DialogResult.OK)
                bindGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
            {
                if (MessageBox.Show("Do you want to delete ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int AlbumId = (int)dataGridView1.Rows[e.RowIndex].Cells["AlbumId"].Value;
                    AlbumDAO albumDAO = AlbumDAO.GetInstance();
                    albumDAO.Delete(AlbumId);
                    MessageBox.Show("That album is deleted!");
                    bindGrid();
                }
            }

            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index)
            {
                int AlbumId = (int)dataGridView1.Rows[e.RowIndex].Cells["AlbumId"].Value;
                Form2 AlbumAddEditGUI = new Form2(AlbumId);
                DialogResult dialogResult = AlbumAddEditGUI.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    bindGrid();
                }
            }
        }
    }
}
