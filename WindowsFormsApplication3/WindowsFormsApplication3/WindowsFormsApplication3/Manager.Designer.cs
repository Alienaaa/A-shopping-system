namespace WindowsFormsApplication3
{
    partial class Manager
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet1 = new WindowsFormsApplication3.DatabaseDataSet1();
            this.feedbackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feedbackTableAdapter = new WindowsFormsApplication3.DatabaseDataSet1TableAdapters.FeedbackTableAdapter();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodsTableAdapter = new WindowsFormsApplication3.DatabaseDataSet1TableAdapters.GoodsTableAdapter();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new WindowsFormsApplication3.DatabaseDataSet1TableAdapters.OrdersTableAdapter();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new WindowsFormsApplication3.DatabaseDataSet1TableAdapters.UsersTableAdapter();
            this.jinhuo = new System.Windows.Forms.Button();
            this.xiaoshou = new System.Windows.Forms.Button();
            this.yonghu = new System.Windows.Forms.Button();
            this.fankui = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.databaseDataSet1;
            this.bindingSource1.Position = 0;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feedbackBindingSource
            // 
            this.feedbackBindingSource.DataMember = "Feedback";
            this.feedbackBindingSource.DataSource = this.bindingSource1;
            // 
            // feedbackTableAdapter
            // 
            this.feedbackTableAdapter.ClearBeforeFill = true;
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataMember = "Goods";
            this.goodsBindingSource.DataSource = this.bindingSource1;
            // 
            // goodsTableAdapter
            // 
            this.goodsTableAdapter.ClearBeforeFill = true;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.bindingSource1;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.bindingSource1;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // jinhuo
            // 
            this.jinhuo.Location = new System.Drawing.Point(679, 23);
            this.jinhuo.Name = "jinhuo";
            this.jinhuo.Size = new System.Drawing.Size(82, 32);
            this.jinhuo.TabIndex = 1;
            this.jinhuo.Text = "进货信息";
            this.jinhuo.UseVisualStyleBackColor = true;
            this.jinhuo.Click += new System.EventHandler(this.jinhuo_Click);
            // 
            // xiaoshou
            // 
            this.xiaoshou.Location = new System.Drawing.Point(679, 108);
            this.xiaoshou.Name = "xiaoshou";
            this.xiaoshou.Size = new System.Drawing.Size(82, 32);
            this.xiaoshou.TabIndex = 2;
            this.xiaoshou.Text = "销售报表";
            this.xiaoshou.UseVisualStyleBackColor = true;
            this.xiaoshou.Click += new System.EventHandler(this.xiaoshou_Click);
            // 
            // yonghu
            // 
            this.yonghu.Location = new System.Drawing.Point(679, 193);
            this.yonghu.Name = "yonghu";
            this.yonghu.Size = new System.Drawing.Size(82, 32);
            this.yonghu.TabIndex = 3;
            this.yonghu.Text = "用户信息";
            this.yonghu.UseVisualStyleBackColor = true;
            this.yonghu.Click += new System.EventHandler(this.yonghu_Click);
            // 
            // fankui
            // 
            this.fankui.Location = new System.Drawing.Point(681, 277);
            this.fankui.Name = "fankui";
            this.fankui.Size = new System.Drawing.Size(82, 32);
            this.fankui.TabIndex = 4;
            this.fankui.Text = "用户反馈";
            this.fankui.UseVisualStyleBackColor = true;
            this.fankui.Click += new System.EventHandler(this.fankui_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(628, 362);
            this.dataGridView1.TabIndex = 5;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 395);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fankui);
            this.Controls.Add(this.yonghu);
            this.Controls.Add(this.xiaoshou);
            this.Controls.Add(this.jinhuo);
            this.Name = "Manager";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private DatabaseDataSet1 databaseDataSet1;
        private System.Windows.Forms.BindingSource feedbackBindingSource;
        private DatabaseDataSet1TableAdapters.FeedbackTableAdapter feedbackTableAdapter;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private DatabaseDataSet1TableAdapters.GoodsTableAdapter goodsTableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private DatabaseDataSet1TableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DatabaseDataSet1TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Button jinhuo;
        private System.Windows.Forms.Button xiaoshou;
        private System.Windows.Forms.Button yonghu;
        private System.Windows.Forms.Button fankui;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}