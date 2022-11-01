using assignment2prn.Models;
using Azure.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace assignment2prn.GUI
{
    public partial class CartGUI : Form
    {
        ShoppingCart shoppingCart;
        MusicStoreContext musicStoreContext;
        private readonly MainGUI mainGUI;
        public CartGUI(MainGUI mainGUI)
        {
            InitializeComponent();
            bidd();
            this.mainGUI = mainGUI;
        }

        private void bidd()
        {
            dataGridView1.AllowUserToAddRows = false;
            musicStoreContext = new MusicStoreContext();
            shoppingCart = new ShoppingCart();
            
            
            shoppingCart = ShoppingCart.GetCart();
            checkOutButton();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            TextboxTotal.Text = (Double)((Double)Math.Ceiling(shoppingCart.GetTotal() *100)/100)+"";
            TextboxTotal.Enabled = false;
            dataGridView1.Width = 4000;
            DataGridViewButtonColumn btnAdd = new DataGridViewButtonColumn
            {
                Text = "Add to cart",
                Name = "Add to cart",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Insert(0, btnAdd);
            DataGridViewButtonColumn AlbumId = new DataGridViewButtonColumn
            {
                Text = "AlbumId",
                Name = "AlbumId",
                UseColumnTextForButtonValue = false
            };
            dataGridView1.Columns.Insert(1, AlbumId);

            DataGridViewButtonColumn Count = new DataGridViewButtonColumn
            {
                Text = "Count",
                Name = "Count",
                UseColumnTextForButtonValue = false
            };
            dataGridView1.Columns.Insert(2, Count);

            DataGridViewButtonColumn DateCreated = new DataGridViewButtonColumn
            {
                Text = "DateCreated",
                Name = "DateCreated",
                UseColumnTextForButtonValue = false
            };
            dataGridView1.Columns.Insert(3, DateCreated);
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 300;
            DataGridViewButtonColumn Remove = new DataGridViewButtonColumn
            {
                Text = "Remove from cart",
                Name = "Remove from cart",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Insert(4, Remove);
            DataGridViewButtonColumn id = new DataGridViewButtonColumn
            {
                Text = "id",
                Name = "id",
                UseColumnTextForButtonValue = false
            };
            dataGridView1.Columns.Insert(5, id);
            dataGridView1.Columns[5].Visible = false;
            
            var x = musicStoreContext.Carts.Where(filter);

            foreach (Cart s in x)
            {
                dataGridView1.Rows.Add(new Object[6] {null,s.AlbumId,s.Count,s.DateCreated,null,s.RecordId});
}
            //int noOfRow = dataGridView1.RowCount;
            //dataGridView1.Rows[noOfRow-1].Visible = false;
            bool filter(Cart s)
            {
                if (s.CartId.Equals(Settings.CartId))
                {
                    return true;
                }
                return false;
            }
        }

        private void checkOutButton()
        {
            if (Settings.UserName != null && shoppingCart.GetCount() > 0)
            {
                ButtonCheckout.Enabled = true;
            }
            else
            {
                ButtonCheckout.Enabled = false;
            }
        }

        private void ButtonCheckout_Click(object sender, EventArgs e)
        {
                CheckoutGUI checkoutGUI = new CheckoutGUI();
                DialogResult dialogResult= checkoutGUI.ShowDialog();
            if(dialogResult == DialogResult.OK)
            {
                bidd();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView1.Columns["AlbumId"].Index)
            {

            }
            else if (e.ColumnIndex == dataGridView1.Columns["Count"].Index)
            {

            }
            else if (e.ColumnIndex == dataGridView1.Columns["DateCreated"].Index)
            {

            }
            else if (e.ColumnIndex == dataGridView1.Columns["id"].Index)
            {

            }
            else if (e.ColumnIndex == dataGridView1.Columns["Add to cart"].Index)
            {
                int albumId = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                shoppingCart.AddToCart2(albumId);
                mainGUI.binddd();
                checkOutButton();
                bidd();
            }
            else if (e.ColumnIndex == dataGridView1.Columns["Remove from cart"].Index)
            {

                int recordId = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                shoppingCart.RemoveFromCart(recordId);
                mainGUI.binddd();
                checkOutButton();
                bidd();

            }
            else { 
            bidd();
        }
        }

        private void TextboxTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
