using assignment2prn.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace assignment2prn.GUI
{
    public partial class ShoppingGUI : Form
    {
        ShoppingCart ShoppingCart=new ShoppingCart();
        MusicStoreContext musicStoreContext;
        PageList<Album> pageList;
        int[] AlbumID= new int[3];
        int i=0;
        public ShoppingGUI()
        {
            InitializeComponent();
            musicStoreContext = new MusicStoreContext();
            
            Bind2(1);
            BindNextPreviousButton();
            ShoppingCart=ShoppingCart.GetCart();
            
        }

        private void BindNextPreviousButton()
        {

            if (pageList.HasPreviousPage==false)
            {
                btnPrevious.Enabled = false;
            }
            else if (pageList.HasNextPage==false)
            {
                btnNext.Enabled = false;
            }
            else 
            {
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
            }
        }

        private void Bind2(int pageIndex)
        {
            //var x1 = musicStoreContext.Genres.Where(filtee);
            //bool filtee(Genre a){ return true; }
            //foreach(Genre aaa in x1)
            //{
            //    comboBox1.Items.Add(aaa.Name);
            //}

            IQueryable<Album> albums = musicStoreContext.Albums.Select(row=>row);
            pageList = PageList<Album>.Create(albums, pageIndex, 3);
            panel1.Controls.Clear();
            int height = panel1.Height - 20;
            int width = (panel1.Width - 20)/3;
            int i = 0;
            foreach(Album a in pageList)
            {
                GroupBox groupBox = new GroupBox();
                groupBox.Height = height;
                groupBox.Width= width;
                groupBox.Location = new Point(10 + i * width, 10);

                PictureBox picture = new PictureBox
                {
                    Name = "pictureBox",
                    //Size = new Size(100, 100),
                    Location = new Point(40, 40)
                };
                picture.ImageLocation = "Images/placeholder.gif";
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                groupBox.Controls.Add(picture);

                Label lbl0 = new Label();
                lbl0.AutoSize = true;
                lbl0.Text = a.Title;
                lbl0.Location = new Point(10, 0);
                groupBox.Controls.Add(lbl0);

                Label lbl1 = new Label();
                lbl1.AutoSize = true;
                lbl1.Text = "$" + a.Price;
                lbl1.Location = new Point(10, 250);
                groupBox.Controls.Add(lbl1);

                Label lbl2 = new Label();
                lbl2.AutoSize = true;
                var x =musicStoreContext.Artists.Where(filter);
                foreach(Artist artist in x)
                {
                    lbl2.Text=artist.Name;
                    break;
                }
                bool filter(Artist s)
                {
                    if (s.ArtistId.Equals(a.ArtistId))
                    {
                        return true;
                    }
                    return false;
                }
                lbl2.Location = new Point(10, 300);
                groupBox.Controls.Add(lbl2);

                
                
                Button btn1 = new Button();
                btn1.AutoSize = true;
                btn1.Text = "Add to cart";
                if (i == 0)
                {
                    btn1.Click += new System.EventHandler(this.btn1_Click0);
                }else if (i == 1)
                {
                    btn1.Click += new System.EventHandler(this.btn1_Click1);
                }
                else if (i == 2)
                {
                    btn1.Click += new System.EventHandler(this.btn1_Click2);
                }
                AlbumID[i] = a.AlbumId;
                btn1.Location = new Point(10, 450);
                groupBox.Controls.Add(btn1);

                i++;
                panel1.Controls.Add(groupBox);
            }
        }

        private void BindSearch(string genre, string title, int pageIndex)
        {
            //IQueryable<Album> albums = musicStoreContext.Albums.Where(albums => albums.Genre.Name == genre && title == albums.Title);
            //IQueryable<Album> albums = musicStoreContext.Albums.Where(albums =>albums.Title.ToLower().Contains(title.ToLower()));

            IQueryable<Album> albums;
            if (genre == "") { albums = musicStoreContext.Albums.Where(albums => albums.Title.ToLower().Contains(title.ToLower())); }
            else if (title == "") { albums = musicStoreContext.Albums.Where(albums => albums.Genre.Name.ToLower() == genre.ToLower()); }
            else
            {
                albums = musicStoreContext.Albums.Where(albums => albums.Title.ToLower().Contains(title.ToLower()) && albums.Genre.Name.ToLower() == genre.ToLower());
            }


            pageList = PageList<Album>.Create(albums, pageIndex, 3);

            panel1.Controls.Clear();
            int height = panel1.Height - 20;
            int width = (panel1.Width - 20) / 3;
            int i = 0;
            foreach (Album a in pageList)
            {
                GroupBox groupBox = new GroupBox();
                groupBox.Height = height;
                groupBox.Width = width;
                groupBox.Location = new Point(10 + i * width, 10);

                PictureBox picture = new PictureBox
                {
                    Name = "pictureBox",
                    //Size = new Size(100, 100),
                    Location = new Point(20, 20)
                };
                picture.ImageLocation = "Images/placeholder.gif";
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                groupBox.Controls.Add(picture);

                Label lbl0 = new Label();
                lbl0.AutoSize = true;
                lbl0.Text = a.Title;
                lbl0.Location = new Point(10, 300);
                groupBox.Controls.Add(lbl0);

                Label lbl1 = new Label();
                lbl1.AutoSize = true;
                lbl1.Text = "$" + a.Price;
                lbl1.Location = new Point(10, 350);
                groupBox.Controls.Add(lbl1);

                Label lbl2 = new Label();
                lbl2.AutoSize = true;
                var x = musicStoreContext.Artists.Where(filter);
                foreach (Artist artist in x)
                {
                    lbl2.Text = artist.Name;
                    break;
                }
                bool filter(Artist s)
                {
                    if (s.ArtistId.Equals(a.ArtistId))
                    {
                        return true;
                    }
                    return false;
                }
                lbl2.Location = new Point(10, 400);
                groupBox.Controls.Add(lbl2);



                Button btn1 = new Button();
                btn1.AutoSize = true;
                btn1.Text = "Add to cart";
                if (i == 0)
                {
                    btn1.Click += new System.EventHandler(this.btn1_Click0);
                }
                else if (i == 1)
                {
                    btn1.Click += new System.EventHandler(this.btn1_Click1);
                }
                else if (i == 2)
                {
                    btn1.Click += new System.EventHandler(this.btn1_Click2);
                }
                AlbumID[i] = a.AlbumId;
                btn1.Location = new Point(10, 450);
                groupBox.Controls.Add(btn1);

                i++;
                panel1.Controls.Add(groupBox);
            }
        }

        private void ShoppingGUI_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            
            
                Bind2(pageList.PageIndex - 1);
            BindNextPreviousButton();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Bind2(pageList.PageIndex + 1);
            BindNextPreviousButton();
        }
        private void btn1_Click0(object sender, EventArgs e)
        {
            var x = musicStoreContext.Albums.Where(filter);
            bool filter(Album a)
            {
                if (a.AlbumId.Equals(AlbumID[0]))
                {
                    return true;
                }
                return false;
            }
            foreach (Album a in x)
            {
                ShoppingCart.AddToCart(a);
                MessageBox.Show("Album " + a.Title + " added to card");
                break;
            }
        }


        private void btn1_Click1(object sender, EventArgs e)
        {
            var x = musicStoreContext.Albums.Where(filter);
            bool filter(Album a)
            {
                if (a.AlbumId.Equals(AlbumID[1]))
                {
                    return true;
                }
                return false;
            }
            foreach (Album a in x)
            {
                ShoppingCart.AddToCart(a);
                MessageBox.Show("Album " + a.Title + " added to card");
                break;
            }
        }
        private void btn1_Click2(object sender, EventArgs e)
        {

            var x = musicStoreContext.Albums.Where(filter);
            bool filter(Album a)
            {
                if (a.AlbumId.Equals(AlbumID[2]))
                {
                    return true;
                }
                return false;
            }
            foreach (Album a in x)
            {
                ShoppingCart.AddToCart(a);
                MessageBox.Show("Album " + a.Title + " added to card");
                break;
            }
            
        }

        public Boolean ssssss()
        {
            return true;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string Genre = comboBoxGenre.GetItemText(comboBoxGenre.SelectedValue);
            string Title = txtTitle.Text;
            BindSearch(Genre, Title, 1);
        }
    }
}
