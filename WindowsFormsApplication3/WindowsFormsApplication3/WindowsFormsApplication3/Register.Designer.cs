namespace WindowsFormsApplication3
{
    partial class Register
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
            this.components = new System.ComponentModel.Container();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.ConfirmtextBox = new System.Windows.Forms.TextBox();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.TeltextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.ConfirmLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.TelLabel = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new WindowsFormsApplication3.DatabaseDataSet();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(136, 41);
            this.NametextBox.MaxLength = 20;
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(136, 21);
            this.NametextBox.TabIndex = 0;
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(135, 79);
            this.PasswordtextBox.MaxLength = 16;
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(137, 21);
            this.PasswordtextBox.TabIndex = 1;
            this.PasswordtextBox.UseSystemPasswordChar = true;
            // 
            // ConfirmtextBox
            // 
            this.ConfirmtextBox.Location = new System.Drawing.Point(134, 117);
            this.ConfirmtextBox.MaxLength = 16;
            this.ConfirmtextBox.Name = "ConfirmtextBox";
            this.ConfirmtextBox.Size = new System.Drawing.Size(138, 21);
            this.ConfirmtextBox.TabIndex = 2;
            this.ConfirmtextBox.UseSystemPasswordChar = true;
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(134, 155);
            this.EmailtextBox.MaxLength = 50;
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(138, 21);
            this.EmailtextBox.TabIndex = 3;
            // 
            // TeltextBox
            // 
            this.TeltextBox.Location = new System.Drawing.Point(134, 193);
            this.TeltextBox.MaxLength = 20;
            this.TeltextBox.Name = "TeltextBox";
            this.TeltextBox.Size = new System.Drawing.Size(138, 21);
            this.TeltextBox.TabIndex = 4;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(45, 44);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(53, 12);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "用户名：";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(44, 82);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(41, 12);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "密码：";
            // 
            // ConfirmLabel
            // 
            this.ConfirmLabel.AutoSize = true;
            this.ConfirmLabel.Location = new System.Drawing.Point(43, 120);
            this.ConfirmLabel.Name = "ConfirmLabel";
            this.ConfirmLabel.Size = new System.Drawing.Size(65, 12);
            this.ConfirmLabel.TabIndex = 7;
            this.ConfirmLabel.Text = "确认密码：";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(43, 158);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(41, 12);
            this.EmailLabel.TabIndex = 8;
            this.EmailLabel.Text = "E-mail";
            // 
            // TelLabel
            // 
            this.TelLabel.AutoSize = true;
            this.TelLabel.Location = new System.Drawing.Point(43, 196);
            this.TelLabel.Name = "TelLabel";
            this.TelLabel.Size = new System.Drawing.Size(23, 12);
            this.TelLabel.TabIndex = 9;
            this.TelLabel.Text = "Tel";
            this.TelLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(45, 253);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(63, 23);
            this.Next.TabIndex = 11;
            this.Next.Text = "确定";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(211, 253);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(61, 23);
            this.Cancel.TabIndex = 12;
            this.Cancel.Text = "取消";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.databaseDataSet;
            this.bindingSource1.Position = 0;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "清空";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 335);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.TelLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.ConfirmLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.TeltextBox);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.ConfirmtextBox);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.NametextBox);
            this.Name = "Register";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.TextBox ConfirmtextBox;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.TextBox TeltextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label ConfirmLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label TelLabel;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.Button button1;
    }
}