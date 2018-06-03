namespace SIMS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItem_Stu_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Stu_Del = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Stu_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Stu_browse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItem_class_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_class_Del = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_class_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_class_browse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItem_major_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_major_Del = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_major_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_major_browse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItem_depart_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_depart_Del = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_depart_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_depart_browse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton5 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolStripMenuItem_Admin_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Admin_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.info_pandel = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3,
            this.toolStripDropDownButton4,
            this.toolStripDropDownButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(672, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Stu_Add,
            this.ToolStripMenuItem_Stu_Del,
            this.ToolStripMenuItem_Stu_Update,
            this.ToolStripMenuItem_Stu_browse});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(66, 22);
            this.toolStripDropDownButton1.Text = "学生管理";
            // 
            // ToolStripMenuItem_Stu_Add
            // 
            this.ToolStripMenuItem_Stu_Add.Name = "ToolStripMenuItem_Stu_Add";
            this.ToolStripMenuItem_Stu_Add.Size = new System.Drawing.Size(142, 22);
            this.ToolStripMenuItem_Stu_Add.Text = "添加学生信息";
            this.ToolStripMenuItem_Stu_Add.Click += new System.EventHandler(this.ToolStripMenuItem_Stu_Add_Click);
            // 
            // ToolStripMenuItem_Stu_Del
            // 
            this.ToolStripMenuItem_Stu_Del.Name = "ToolStripMenuItem_Stu_Del";
            this.ToolStripMenuItem_Stu_Del.Size = new System.Drawing.Size(142, 22);
            this.ToolStripMenuItem_Stu_Del.Text = "删除学生信息";
            this.ToolStripMenuItem_Stu_Del.Click += new System.EventHandler(this.ToolStripMenuItem_Stu_Del_Click);
            // 
            // ToolStripMenuItem_Stu_Update
            // 
            this.ToolStripMenuItem_Stu_Update.Name = "ToolStripMenuItem_Stu_Update";
            this.ToolStripMenuItem_Stu_Update.Size = new System.Drawing.Size(142, 22);
            this.ToolStripMenuItem_Stu_Update.Text = "更新学生信息";
            this.ToolStripMenuItem_Stu_Update.Click += new System.EventHandler(this.ToolStripMenuItem_Stu_Update_Click);
            // 
            // ToolStripMenuItem_Stu_browse
            // 
            this.ToolStripMenuItem_Stu_browse.Name = "ToolStripMenuItem_Stu_browse";
            this.ToolStripMenuItem_Stu_browse.Size = new System.Drawing.Size(142, 22);
            this.ToolStripMenuItem_Stu_browse.Text = "浏览学生信息";
            this.ToolStripMenuItem_Stu_browse.Click += new System.EventHandler(this.ToolStripMenuItem_Stu_browse_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_class_Add,
            this.ToolStripMenuItem_class_Del,
            this.ToolStripMenuItem_class_Update,
            this.ToolStripMenuItem_class_browse});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(66, 22);
            this.toolStripDropDownButton2.Text = "班级管理";
            // 
            // ToolStripMenuItem_class_Add
            // 
            this.ToolStripMenuItem_class_Add.Name = "ToolStripMenuItem_class_Add";
            this.ToolStripMenuItem_class_Add.Size = new System.Drawing.Size(142, 22);
            this.ToolStripMenuItem_class_Add.Text = "添加班级信息";
            this.ToolStripMenuItem_class_Add.Click += new System.EventHandler(this.ToolStripMenuItem_class_Add_Click);
            // 
            // ToolStripMenuItem_class_Del
            // 
            this.ToolStripMenuItem_class_Del.Name = "ToolStripMenuItem_class_Del";
            this.ToolStripMenuItem_class_Del.Size = new System.Drawing.Size(142, 22);
            this.ToolStripMenuItem_class_Del.Text = "删除班级信息";
            this.ToolStripMenuItem_class_Del.Click += new System.EventHandler(this.ToolStripMenuItem_class_Del_Click);
            // 
            // ToolStripMenuItem_class_Update
            // 
            this.ToolStripMenuItem_class_Update.Name = "ToolStripMenuItem_class_Update";
            this.ToolStripMenuItem_class_Update.Size = new System.Drawing.Size(142, 22);
            this.ToolStripMenuItem_class_Update.Text = "更改班级信息";
            this.ToolStripMenuItem_class_Update.Click += new System.EventHandler(this.ToolStripMenuItem_class_Update_Click);
            // 
            // ToolStripMenuItem_class_browse
            // 
            this.ToolStripMenuItem_class_browse.Name = "ToolStripMenuItem_class_browse";
            this.ToolStripMenuItem_class_browse.Size = new System.Drawing.Size(142, 22);
            this.ToolStripMenuItem_class_browse.Text = "浏览班级信息";
            this.ToolStripMenuItem_class_browse.Click += new System.EventHandler(this.ToolStripMenuItem_class_browse_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_major_Add,
            this.ToolStripMenuItem_major_Del,
            this.ToolStripMenuItem_major_Update,
            this.ToolStripMenuItem_major_browse});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(66, 22);
            this.toolStripDropDownButton3.Text = "专业管理";
            // 
            // ToolStripMenuItem_major_Add
            // 
            this.ToolStripMenuItem_major_Add.Name = "ToolStripMenuItem_major_Add";
            this.ToolStripMenuItem_major_Add.Size = new System.Drawing.Size(142, 22);
            this.ToolStripMenuItem_major_Add.Text = "添加专业信息";
            this.ToolStripMenuItem_major_Add.Click += new System.EventHandler(this.ToolStripMenuItem_major_Add_Click);
            // 
            // ToolStripMenuItem_major_Del
            // 
            this.ToolStripMenuItem_major_Del.Name = "ToolStripMenuItem_major_Del";
            this.ToolStripMenuItem_major_Del.Size = new System.Drawing.Size(142, 22);
            this.ToolStripMenuItem_major_Del.Text = "删除专业信息";
            this.ToolStripMenuItem_major_Del.Click += new System.EventHandler(this.ToolStripMenuItem_major_Del_Click);
            // 
            // ToolStripMenuItem_major_Update
            // 
            this.ToolStripMenuItem_major_Update.Name = "ToolStripMenuItem_major_Update";
            this.ToolStripMenuItem_major_Update.Size = new System.Drawing.Size(142, 22);
            this.ToolStripMenuItem_major_Update.Text = "更改专业信息";
            this.ToolStripMenuItem_major_Update.Click += new System.EventHandler(this.ToolStripMenuItem_major_Update_Click);
            // 
            // ToolStripMenuItem_major_browse
            // 
            this.ToolStripMenuItem_major_browse.Name = "ToolStripMenuItem_major_browse";
            this.ToolStripMenuItem_major_browse.Size = new System.Drawing.Size(142, 22);
            this.ToolStripMenuItem_major_browse.Text = "浏览专业信息";
            this.ToolStripMenuItem_major_browse.Click += new System.EventHandler(this.ToolStripMenuItem_major_browse_Click);
            // 
            // toolStripDropDownButton4
            // 
            this.toolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_depart_Add,
            this.ToolStripMenuItem_depart_Del,
            this.ToolStripMenuItem_depart_Update,
            this.ToolStripMenuItem_depart_browse});
            this.toolStripDropDownButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton4.Image")));
            this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            this.toolStripDropDownButton4.Size = new System.Drawing.Size(66, 22);
            this.toolStripDropDownButton4.Text = "院系管理";
            // 
            // ToolStripMenuItem_depart_Add
            // 
            this.ToolStripMenuItem_depart_Add.Name = "ToolStripMenuItem_depart_Add";
            this.ToolStripMenuItem_depart_Add.Size = new System.Drawing.Size(142, 22);
            this.ToolStripMenuItem_depart_Add.Text = "添加院系信息";
            this.ToolStripMenuItem_depart_Add.Click += new System.EventHandler(this.ToolStripMenuItem_depart_Add_Click);
            // 
            // ToolStripMenuItem_depart_Del
            // 
            this.ToolStripMenuItem_depart_Del.Name = "ToolStripMenuItem_depart_Del";
            this.ToolStripMenuItem_depart_Del.Size = new System.Drawing.Size(142, 22);
            this.ToolStripMenuItem_depart_Del.Text = "删除院系信息";
            this.ToolStripMenuItem_depart_Del.Click += new System.EventHandler(this.ToolStripMenuItem_depart_Del_Click);
            // 
            // ToolStripMenuItem_depart_Update
            // 
            this.ToolStripMenuItem_depart_Update.Name = "ToolStripMenuItem_depart_Update";
            this.ToolStripMenuItem_depart_Update.Size = new System.Drawing.Size(142, 22);
            this.ToolStripMenuItem_depart_Update.Text = "更新院系信息";
            this.ToolStripMenuItem_depart_Update.Click += new System.EventHandler(this.ToolStripMenuItem_depart_Update_Click);
            // 
            // ToolStripMenuItem_depart_browse
            // 
            this.ToolStripMenuItem_depart_browse.Name = "ToolStripMenuItem_depart_browse";
            this.ToolStripMenuItem_depart_browse.Size = new System.Drawing.Size(142, 22);
            this.ToolStripMenuItem_depart_browse.Text = "浏览院系信息";
            this.ToolStripMenuItem_depart_browse.Click += new System.EventHandler(this.ToolStripMenuItem_depart_browse_Click);
            // 
            // toolStripDropDownButton5
            // 
            this.toolStripDropDownButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Admin_Add,
            this.ToolStripMenuItem_Admin_Update,
            this.ToolStripMenuItem_Close});
            this.toolStripDropDownButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton5.Image")));
            this.toolStripDropDownButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton5.Name = "toolStripDropDownButton5";
            this.toolStripDropDownButton5.Size = new System.Drawing.Size(66, 22);
            this.toolStripDropDownButton5.Text = "系统设置";
            // 
            // ToolStripMenuItem_Admin_Add
            // 
            this.ToolStripMenuItem_Admin_Add.Name = "ToolStripMenuItem_Admin_Add";
            this.ToolStripMenuItem_Admin_Add.Size = new System.Drawing.Size(154, 22);
            this.ToolStripMenuItem_Admin_Add.Text = "增加管理员信息";
            this.ToolStripMenuItem_Admin_Add.Click += new System.EventHandler(this.ToolStripMenuItem_Admin_Add_Click);
            // 
            // ToolStripMenuItem_Admin_Update
            // 
            this.ToolStripMenuItem_Admin_Update.Name = "ToolStripMenuItem_Admin_Update";
            this.ToolStripMenuItem_Admin_Update.Size = new System.Drawing.Size(154, 22);
            this.ToolStripMenuItem_Admin_Update.Text = "更新管理员信息";
            this.ToolStripMenuItem_Admin_Update.Click += new System.EventHandler(this.ToolStripMenuItem_Admin_Update_Click);
            // 
            // ToolStripMenuItem_Close
            // 
            this.ToolStripMenuItem_Close.Name = "ToolStripMenuItem_Close";
            this.ToolStripMenuItem_Close.Size = new System.Drawing.Size(154, 22);
            this.ToolStripMenuItem_Close.Text = "关闭系统";
            this.ToolStripMenuItem_Close.Click += new System.EventHandler(this.ToolStripMenuItem_Close_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(672, 361);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // info_pandel
            // 
            this.info_pandel.Location = new System.Drawing.Point(0, 28);
            this.info_pandel.Name = "info_pandel";
            this.info_pandel.Size = new System.Drawing.Size(672, 70);
            this.info_pandel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 466);
            this.Controls.Add(this.info_pandel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Stu_Add;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Stu_Del;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Stu_Update;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Stu_browse;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_class_Add;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_class_Del;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_class_Update;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_class_browse;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_major_Add;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_major_Del;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_major_Update;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_major_browse;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_depart_Add;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_depart_Del;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_depart_Update;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_depart_browse;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton5;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Admin_Add;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Admin_Update;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Close;
        private System.Windows.Forms.Panel info_pandel;
    }
}