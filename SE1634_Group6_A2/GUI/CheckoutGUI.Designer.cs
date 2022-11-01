namespace assignment2prn.GUI
{
    partial class CheckoutGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.TextBox();
            this.country = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(72, 39);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(130, 32);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(75, 108);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(127, 32);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "State:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Country:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 485);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(126, 570);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 32);
            this.label8.TabIndex = 7;
            this.label8.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(130, 640);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 32);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total:";
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(222, 39);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(408, 39);
            this.fname.TabIndex = 9;
            this.fname.TextChanged += new System.EventHandler(this.fname_TextChanged);
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(222, 108);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(408, 39);
            this.lname.TabIndex = 10;
            this.lname.TextChanged += new System.EventHandler(this.lname_TextChanged);
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(222, 245);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(408, 39);
            this.city.TabIndex = 11;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(222, 172);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(408, 39);
            this.address.TabIndex = 12;
            this.address.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // state
            // 
            this.state.Location = new System.Drawing.Point(222, 326);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(408, 39);
            this.state.TabIndex = 13;
            // 
            // country
            // 
            this.country.Location = new System.Drawing.Point(222, 409);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(408, 39);
            this.country.TabIndex = 14;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(222, 485);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(408, 39);
            this.phone.TabIndex = 15;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(222, 570);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(408, 39);
            this.email.TabIndex = 16;
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(222, 640);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(408, 39);
            this.total.TabIndex = 17;
            this.total.TextChanged += new System.EventHandler(this.total_TextChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(154, 725);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(150, 46);
            this.SaveButton.TabIndex = 18;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(426, 725);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(150, 46);
            this.CancelButton.TabIndex = 19;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CheckoutGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 819);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.total);
            this.Controls.Add(this.email);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.country);
            this.Controls.Add(this.state);
            this.Controls.Add(this.address);
            this.Controls.Add(this.city);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "CheckoutGUI";
            this.Text = "CheckoutGUI";
            this.Load += new System.EventHandler(this.CheckoutGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox fname;
        private TextBox lname;
        private TextBox city;
        private TextBox address;
        private TextBox state;
        private TextBox country;
        private TextBox phone;
        private TextBox email;
        private TextBox total;
        private Button SaveButton;
        private Button CancelButton;
    }
}