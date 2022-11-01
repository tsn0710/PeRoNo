using assignment2prn.Models;
using Azure.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace assignment2prn.GUI
{
    public partial class CheckoutGUI : Form
    {
        MusicStoreContext musicStoreContext;
        ShoppingCart shoppingCart;
        public CheckoutGUI()
        {
            InitializeComponent();
            goioioi();

        }

        private void goioioi()
        {
            musicStoreContext = new MusicStoreContext();
            shoppingCart = ShoppingCart.GetCart();

            var ssss = musicStoreContext.Users.Where(e => e != null).Select(x => x);
            var x = ssss.Where(ss => ss.Id == Settings.UserID);
            foreach (User? a in x)
            {
                fname.Text = a.FirstName;
                lname.Text = a.LastName;
                
                if (a.Address == null)
                {
                    address.Text = "";
                }
                else { address.Text = a.Address; }
                
                if (a.City == null)
                {
                    city.Text = "";
                }
                else { city.Text = a.City; }
                
                if (a.State == null)
                {
                    state.Text = "";
                }
                else { state.Text = a.State; }
                
                if (a.Country == null)
                {
                    country.Text = "";
                }
                else { country.Text = a.Country; }
                
                if (a.Phone == null)
                {
                    phone.Text = "";
                }
                else { phone.Text = a.Phone; }
                
                if (a.Email == null)
                {
                    email.Text = "";
                }
                else { email.Text = a.Email; }
                total.Text = (Double)((Double)Math.Ceiling(shoppingCart.GetTotal() * 100) / 100) + "";
                total.Enabled = false;
                break;
            }
            


        }

        private void fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int i=shoppingCart.CreateOrder(new Order()
            {
                OrderDate = DateTime.Now,
                UserName = Settings.UserName,
                FirstName = fname.Text,
                LastName = lname.Text,
                Address = address.Text,
                City = city.Text,
                State = state.Text,
                Country = country.Text,
                Phone = phone.Text,
                Email = email.Text,
                Total = shoppingCart.GetTotal()
            });
            MessageBox.Show("Order id "+i+" is saved");
            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void CheckoutGUI_Load(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void total_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
