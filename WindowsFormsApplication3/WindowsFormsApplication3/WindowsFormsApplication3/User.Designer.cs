namespace WindowsFormsApplication3
{
    partial class User
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
            this.welcome = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_user = new System.Windows.Forms.Button();
            this.button_order = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Location = new System.Drawing.Point(12, 29);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(35, 12);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "欢迎:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(660, 326);
            this.dataGridView1.TabIndex = 1;
            // 
            // button_user
            // 
            this.button_user.Location = new System.Drawing.Point(440, 25);
            this.button_user.Name = "button_user";
            this.button_user.Size = new System.Drawing.Size(94, 21);
            this.button_user.TabIndex = 2;
            this.button_user.Text = "返回个人信息";
            this.button_user.UseVisualStyleBackColor = true;
            this.button_user.Click += new System.EventHandler(this.button_user_Click);
            // 
            // button_order
            // 
            this.button_order.Location = new System.Drawing.Point(580, 25);
            this.button_order.Name = "button_order";
            this.button_order.Size = new System.Drawing.Size(94, 21);
            this.button_order.TabIndex = 3;
            this.button_order.Text = "已订购商品";
            this.button_order.UseVisualStyleBackColor = true;
            this.button_order.Click += new System.EventHandler(this.button_order_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 413);
            this.Controls.Add(this.button_order);
            this.Controls.Add(this.button_user);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.welcome);
            this.Name = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_user;
        private System.Windows.Forms.Button button_order;
    }
}