using assignment2prn.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2prn.GUI
{
    public partial class MainGUI : Form
    {
        public ShoppingCart ShoppingCart = new ShoppingCart();
        public MainGUI()
        {
            InitializeComponent();
            ShoppingCart=ShoppingCart.GetCart();
            binddd();


        }
        public void binddd()
        {
            toolStripStatusLabel1.Text = "SE1634, Group 6: Tống Sỹ Nhật, Nguyễn Minh Tân, Cấn Phương Nam, Đỗ Đức Việt, Nguyễn Đức Chiến";
            cartToolStripMenuItem.Text="Cart("+ ShoppingCart.GetCount() + ")";
            if (Settings.UserName != null)
            {
                loginToolStripMenuItem.Text = "Logout";
                if (Settings.Role == 1)
                {
                    albumsToolStripMenuItem.Enabled = true;
                    albumsToolStripMenuItem.Visible = true;
                }
            }
            else
            {
                loginToolStripMenuItem.Text = "Login";
                albumsToolStripMenuItem.Enabled = false;
                albumsToolStripMenuItem.Visible = false;
            }
        }


        private void shopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShoppingGUI shopGUI = new ShoppingGUI();
            shopGUI.TopLevel = false;
            shopGUI.FormBorderStyle= FormBorderStyle.None;
            shopGUI.Show();

            toolStripContainer1.ContentPanel.Controls.Clear();
            toolStripContainer1.ContentPanel.Controls.Add(shopGUI);
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginBackGround loginBackGround = new LoginBackGround();
            loginBackGround.TopLevel = false;
            loginBackGround.FormBorderStyle = FormBorderStyle.None;
            loginBackGround.Show();

            toolStripContainer1.ContentPanel.Controls.Clear();
            toolStripContainer1.ContentPanel.Controls.Add(loginBackGround);
            if (Settings.UserName == null)
            {
                LoginGUI loginGUI = new LoginGUI();
                DialogResult dialogResult = loginGUI.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                {
                    
                    ShoppingCart.MigrateCart();
                    ShoppingCart = ShoppingCart.GetCart();
                    binddd();
                }
                if (dialogResult == DialogResult.None)
                {
                    binddd();
                }
                

                //Settings.UserName = "huong";
                //Settings.CartId = "huong";
                //Settings.Role = 1;
                //Settings.UserID = 9;
                
            }
            else
            {
                Settings.UserName = null;
                Settings.Role = -1;
                Settings.CartId = null;
                Settings.UserID = -1;
                ShoppingCart=ShoppingCart.GetCart();
                binddd();
            }
        }

        void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {
            
        }

        private void cartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                CartGUI cartGUI = new CartGUI(this);
            cartGUI.TopLevel = false;
            cartGUI.FormBorderStyle = FormBorderStyle.None;
            cartGUI.Show();

            toolStripContainer1.ContentPanel.Controls.Clear();
            toolStripContainer1.ContentPanel.Controls.Add(cartGUI);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void albumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();

            toolStripContainer1.ContentPanel.Controls.Clear();
            toolStripContainer1.ContentPanel.Controls.Add(form);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            shopToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            cartToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            loginToolStripMenuItem_Click(sender, e);
        }

        private void hahaha(object sender, EventArgs e)
        {
            //cartToolStripMenuItem.Text="Cart("+ ShoppingCart.GetCount()+ ")";
        }

        private void haha(object sender, MouseEventArgs e)
        {
            //cartToolStripMenuItem.Text = "Cart(" + ShoppingCart.GetCount() + ")";
        }

        private void haha(object sender, EventArgs e)
        {
            //cartToolStripMenuItem.Text = "Cart(" + ShoppingCart.GetCount() + ")";
        }

        private void haha2(object sender, EventArgs e)
        {
            //cartToolStripMenuItem.Text = "Cart(" + ShoppingCart.GetCount() + ")";
        }

        private void MainGUI_Load(object sender, EventArgs e)
        {

        }

        private void isActivated(object sender, EventArgs e)
        {
            binddd();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
