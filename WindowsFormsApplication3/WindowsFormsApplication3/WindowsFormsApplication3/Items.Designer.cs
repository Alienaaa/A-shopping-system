namespace WindowsFormsApplication3
{
    partial class Items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Items));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.ItemClasslabel = new System.Windows.Forms.Label();
            this.ItemPricelabel = new System.Windows.Forms.Label();
            this.ItemDescriptionlabel = new System.Windows.Forms.Label();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.ItemNumlabel = new System.Windows.Forms.Label();
            this.Nextbutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.remark = new System.Windows.Forms.TextBox();
            this.tuijian = new System.Windows.Forms.CheckBox();
            this.recomlabel = new System.Windows.Forms.Label();
            this.axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(85, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 90);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Location = new System.Drawing.Point(312, 53);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(59, 12);
            this.ItemNameLabel.TabIndex = 1;
            this.ItemNameLabel.Text = "商品名称:";
            // 
            // ItemClasslabel
            // 
            this.ItemClasslabel.AutoSize = true;
            this.ItemClasslabel.Location = new System.Drawing.Point(312, 90);
            this.ItemClasslabel.Name = "ItemClasslabel";
            this.ItemClasslabel.Size = new System.Drawing.Size(59, 12);
            this.ItemClasslabel.TabIndex = 2;
            this.ItemClasslabel.Text = "商品类别:";
            // 
            // ItemPricelabel
            // 
            this.ItemPricelabel.AutoSize = true;
            this.ItemPricelabel.Location = new System.Drawing.Point(312, 131);
            this.ItemPricelabel.Name = "ItemPricelabel";
            this.ItemPricelabel.Size = new System.Drawing.Size(59, 12);
            this.ItemPricelabel.TabIndex = 3;
            this.ItemPricelabel.Text = "商品单价:";
            // 
            // ItemDescriptionlabel
            // 
            this.ItemDescriptionlabel.AutoSize = true;
            this.ItemDescriptionlabel.Location = new System.Drawing.Point(313, 251);
            this.ItemDescriptionlabel.Name = "ItemDescriptionlabel";
            this.ItemDescriptionlabel.Size = new System.Drawing.Size(65, 12);
            this.ItemDescriptionlabel.TabIndex = 4;
            this.ItemDescriptionlabel.Text = "商品描述：";
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Location = new System.Drawing.Point(313, 206);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(59, 12);
            this.TotalPriceLabel.TabIndex = 5;
            this.TotalPriceLabel.Text = "商品总价:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(381, 165);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(44, 21);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // ItemNumlabel
            // 
            this.ItemNumlabel.AutoSize = true;
            this.ItemNumlabel.Location = new System.Drawing.Point(312, 169);
            this.ItemNumlabel.Name = "ItemNumlabel";
            this.ItemNumlabel.Size = new System.Drawing.Size(59, 12);
            this.ItemNumlabel.TabIndex = 7;
            this.ItemNumlabel.Text = "订购数量:";
            // 
            // Nextbutton
            // 
            this.Nextbutton.Location = new System.Drawing.Point(85, 422);
            this.Nextbutton.Name = "Nextbutton";
            this.Nextbutton.Size = new System.Drawing.Size(75, 23);
            this.Nextbutton.TabIndex = 8;
            this.Nextbutton.Text = "购买";
            this.Nextbutton.UseVisualStyleBackColor = true;
            this.Nextbutton.Click += new System.EventHandler(this.Nextbutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(423, 422);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.TabIndex = 9;
            this.Cancelbutton.Text = "取消";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // Clearbutton
            // 
            this.Clearbutton.Location = new System.Drawing.Point(253, 422);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(75, 23);
            this.Clearbutton.TabIndex = 10;
            this.Clearbutton.Text = "清空";
            this.Clearbutton.UseVisualStyleBackColor = true;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // remark
            // 
            this.remark.Location = new System.Drawing.Point(85, 327);
            this.remark.Multiline = true;
            this.remark.Name = "remark";
            this.remark.Size = new System.Drawing.Size(413, 57);
            this.remark.TabIndex = 11;
            // 
            // tuijian
            // 
            this.tuijian.AutoSize = true;
            this.tuijian.Location = new System.Drawing.Point(88, 251);
            this.tuijian.Name = "tuijian";
            this.tuijian.Size = new System.Drawing.Size(72, 16);
            this.tuijian.TabIndex = 12;
            this.tuijian.Text = "推荐商品";
            this.tuijian.UseVisualStyleBackColor = true;
            this.tuijian.CheckedChanged += new System.EventHandler(this.tuijian_CheckedChanged);
            this.tuijian.EnabledChanged += new System.EventHandler(this.tuijian_EnabledChanged);
            // 
            // recomlabel
            // 
            this.recomlabel.AutoSize = true;
            this.recomlabel.Location = new System.Drawing.Point(86, 289);
            this.recomlabel.Name = "recomlabel";
            this.recomlabel.Size = new System.Drawing.Size(41, 12);
            this.recomlabel.TabIndex = 13;
            this.recomlabel.Text = "推荐：";
            // 
            // axShockwaveFlash1
            // 
            this.axShockwaveFlash1.Enabled = true;
            this.axShockwaveFlash1.Location = new System.Drawing.Point(85, 53);
            this.axShockwaveFlash1.Name = "axShockwaveFlash1";
            this.axShockwaveFlash1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash1.OcxState")));
            this.axShockwaveFlash1.Size = new System.Drawing.Size(121, 90);
            this.axShockwaveFlash1.TabIndex = 14;
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 477);
            this.Controls.Add(this.axShockwaveFlash1);
            this.Controls.Add(this.recomlabel);
            this.Controls.Add(this.tuijian);
            this.Controls.Add(this.remark);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Nextbutton);
            this.Controls.Add(this.ItemNumlabel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.TotalPriceLabel);
            this.Controls.Add(this.ItemDescriptionlabel);
            this.Controls.Add(this.ItemPricelabel);
            this.Controls.Add(this.ItemClasslabel);
            this.Controls.Add(this.ItemNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Items";
            this.Text = "Items";
            this.Load += new System.EventHandler(this.Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ItemNameLabel;
        private System.Windows.Forms.Label ItemClasslabel;
        private System.Windows.Forms.Label ItemPricelabel;
        private System.Windows.Forms.Label ItemDescriptionlabel;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label ItemNumlabel;
        private System.Windows.Forms.Button Nextbutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.TextBox remark;
        private System.Windows.Forms.CheckBox tuijian;
        private System.Windows.Forms.Label recomlabel;
        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash1;

    }
}