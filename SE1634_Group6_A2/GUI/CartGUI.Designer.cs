namespace assignment2prn.GUI
{
    partial class CartGUI
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
            this.ButtonCheckout = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TextboxTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonCheckout
            // 
            this.ButtonCheckout.Location = new System.Drawing.Point(65, 32);
            this.ButtonCheckout.Name = "ButtonCheckout";
            this.ButtonCheckout.Size = new System.Drawing.Size(150, 46);
            this.ButtonCheckout.TabIndex = 0;
            this.ButtonCheckout.Text = "Checkout";
            this.ButtonCheckout.UseVisualStyleBackColor = true;
            this.ButtonCheckout.Click += new System.EventHandler(this.ButtonCheckout_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(88, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 41;
            this.dataGridView1.Size = new System.Drawing.Size(939, 459);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 640);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total:";
            // 
            // TextboxTotal
            // 
            this.TextboxTotal.Location = new System.Drawing.Point(401, 640);
            this.TextboxTotal.Name = "TextboxTotal";
            this.TextboxTotal.Size = new System.Drawing.Size(200, 39);
            this.TextboxTotal.TabIndex = 3;
            this.TextboxTotal.TextChanged += new System.EventHandler(this.TextboxTotal_TextChanged);
            // 
            // CartGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 744);
            this.Controls.Add(this.TextboxTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ButtonCheckout);
            this.Name = "CartGUI";
            this.Text = "CartGUI";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonCheckout;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox TextboxTotal;
    }
}