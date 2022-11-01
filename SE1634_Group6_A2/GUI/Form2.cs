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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace assignment2prn.GUI
{
    public partial class Form2 : Form
    {
        public int type;
        public Form2(int AlbumId)
        {
            InitializeComponent();
            type = AlbumId;
            bindGrid();
        }

        private void bindGrid()
        {
            foreach (DataRow data in GenreDAO.GetInstance().GetDataTable().Rows)
            {
                comboBox1.Items.Add(data["Name"].ToString());
            }
            foreach (DataRow data in ArtistDAO.GetInstance().GetDataTable().Rows)
            {
                comboBox2.Items.Add(data["Name"].ToString());
            }
            AlbumDAO albumDAO = AlbumDAO.GetInstance();
            DataTable dt = albumDAO.GetDataTableById(type);
            if(type != -1)
            {
                foreach (DataRow data in dt.Rows)
                {
                    textBox1.Text = data["Title"].ToString();
                    textBox2.Text = data["Price"].ToString();
                    textBox3.Text = data["AlbumUrl"].ToString();
                    pictureBox1.ImageLocation = data["AlbumUrl"].ToString().Trim();
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n;
            int output;
            Album album;
            AlbumDAO albumDAO = AlbumDAO.GetInstance();
            // ADD: carId == -1
            if (type == -1)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please Enter Title", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(textBox2.Text == ""){
                    MessageBox.Show("Please Enter Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Double.TryParse(textBox2.Text, out n))
                {
                    MessageBox.Show("Price must be Number!");
                }
                else if (Double.Parse(textBox2.Text) < 0)
                {
                    MessageBox.Show("Price must be >= 0!");
                }
                else
                {
                    Random rnd = new Random();
                    album = new Album
                    {
                        AlbumId = rnd.Next(),
                        GenreId = comboBox1.SelectedIndex + 1,
                        ArtistId = comboBox2.SelectedIndex + 1,
                        Title = textBox1.Text,
                        Price = Convert.ToDecimal(textBox2.Text),
                        AlbumUrl = textBox3.Text
                    };
                        if (albumDAO.Insert(album))
                        {
                        MessageBox.Show("A new album is added!");
                        this.Close();
                        }

                        else
                            MessageBox.Show("Error");
                };
                               
                
                

            }
            else
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please Enter Title", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBox2.Text == ""){
                    MessageBox.Show("Please Enter Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Double.TryParse(textBox2.Text, out n))
                {
                    MessageBox.Show("Price must be Number!");
                }
                else if (Double.Parse(textBox2.Text) < 0)
                {
                    MessageBox.Show("Price must be >= 0!");
                }
                else
                {
                    album = new Album
                    {
                        AlbumId = type,
                        GenreId = comboBox1.SelectedIndex + 1,
                        ArtistId = comboBox2.SelectedIndex + 1,
                        Title = textBox1.Text,
                        Price = Convert.ToDecimal(textBox2.Text),
                        AlbumUrl = textBox3.Text
                    };
                    if (albumDAO.Edit(album))
                    {
                        MessageBox.Show("A new album is updated!");
                        this.Close();
                    }

                    else
                        MessageBox.Show("Error");
                }
                
            }
        }
    


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = " \"jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*\"";
                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    pictureBox1.ImageLocation = imageLocation;
                    textBox3.Text = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
