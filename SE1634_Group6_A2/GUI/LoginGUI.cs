using assignment2prn.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace assignment2prn.GUI
{
    
    public partial class LoginGUI : Form
    {
        MusicStoreContext musicStoreContext;
        public LoginGUI()
        {
            InitializeComponent();
            musicStoreContext = new MusicStoreContext();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if (musicStoreContext.Users.Select(s=>s.UserName).Where(user => user.UserName.Equals(txtUsername.Text) && user.Password.Equals(txtPassword.Text)).FirstOrDefault().UserName == null)
            //{
            //    MessageBox.Show("the member does not exist");
            //}
            var ssss = musicStoreContext.Users.Select(x => new { x.Id, x.UserName, x.Password, x.Role });
            var s2 = ssss.Where(user => user.UserName.Equals(txtUsername.Text) && user.Password.Equals(txtPassword.Text));
            if(s2.Count() == 0)
            {
                MessageBox.Show("the member does not exist");
            }
            foreach (var a in s2)
            {
                Settings.UserName = "" + a.UserName;
                Settings.UserID = a.Id;
                Settings.Role = a.Role;
                Settings.CartId = null;
                this.DialogResult = DialogResult.Yes;
                this.Close();
                break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
