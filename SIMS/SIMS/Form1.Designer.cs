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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.浏览学生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加学生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除学生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新学生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSplitButton4 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSplitButton5 = new System.Windows.Forms.ToolStripSplitButton();
            this.浏览学院信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除学院信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新学院信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加专业信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加班级信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新班级信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.浏览班级信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.浏览专业信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除班级信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除专业信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "浏览学生信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ToolStripMenuItem_Stu_browse_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "添加学生信息";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ToolStripMenuItem_Stu_Add_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(37, 443);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "删除学生信息";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ToolStripMenuItem_Stu_Del_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(37, 472);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "更新学生信息";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ToolStripMenuItem_Stu_Update_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(132, 384);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "浏览学院信息";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ToolStripMenuItem_Add_depart_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSplitButton3,
            this.toolStripSplitButton2,
            this.toolStripSplitButton4,
            this.toolStripSplitButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(762, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.浏览学生ToolStripMenuItem,
            this.添加学生ToolStripMenuItem,
            this.删除学生ToolStripMenuItem,
            this.更新学生ToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(72, 22);
            this.toolStripSplitButton1.Text = "学生管理";
            // 
            // 浏览学生ToolStripMenuItem
            // 
            this.浏览学生ToolStripMenuItem.Name = "浏览学生ToolStripMenuItem";
            this.浏览学生ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.浏览学生ToolStripMenuItem.Text = "浏览学生信息";
            // 
            // 添加学生ToolStripMenuItem
            // 
            this.添加学生ToolStripMenuItem.Name = "添加学生ToolStripMenuItem";
            this.添加学生ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.添加学生ToolStripMenuItem.Text = "添加学生信息";
            // 
            // 删除学生ToolStripMenuItem
            // 
            this.删除学生ToolStripMenuItem.Name = "删除学生ToolStripMenuItem";
            this.删除学生ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.删除学生ToolStripMenuItem.Text = "删除学生信息";
            // 
            // 更新学生ToolStripMenuItem
            // 
            this.更新学生ToolStripMenuItem.Name = "更新学生ToolStripMenuItem";
            this.更新学生ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.更新学生ToolStripMenuItem.Text = "更新学生信息";
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加班级信息ToolStripMenuItem,
            this.更新班级信息ToolStripMenuItem,
            this.浏览班级信息ToolStripMenuItem,
            this.删除班级信息ToolStripMenuItem});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(72, 22);
            this.toolStripSplitButton2.Text = "班级管理";
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加专业信息ToolStripMenuItem,
            this.浏览专业信息ToolStripMenuItem,
            this.删除专业信息ToolStripMenuItem});
            this.toolStripSplitButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton3.Image")));
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(72, 22);
            this.toolStripSplitButton3.Text = "专业管理";
            // 
            // toolStripSplitButton4
            // 
            this.toolStripSplitButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.浏览学院信息ToolStripMenuItem,
            this.删除学院信息ToolStripMenuItem,
            this.更新学院信息ToolStripMenuItem});
            this.toolStripSplitButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton4.Image")));
            this.toolStripSplitButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton4.Name = "toolStripSplitButton4";
            this.toolStripSplitButton4.Size = new System.Drawing.Size(72, 22);
            this.toolStripSplitButton4.Text = "院系管理";
            // 
            // toolStripSplitButton5
            // 
            this.toolStripSplitButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton5.Image")));
            this.toolStripSplitButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton5.Name = "toolStripSplitButton5";
            this.toolStripSplitButton5.Size = new System.Drawing.Size(72, 22);
            this.toolStripSplitButton5.Text = "系统设置";
            // 
            // 浏览学院信息ToolStripMenuItem
            // 
            this.浏览学院信息ToolStripMenuItem.Name = "浏览学院信息ToolStripMenuItem";
            this.浏览学院信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.浏览学院信息ToolStripMenuItem.Text = "浏览学院信息";
            // 
            // 删除学院信息ToolStripMenuItem
            // 
            this.删除学院信息ToolStripMenuItem.Name = "删除学院信息ToolStripMenuItem";
            this.删除学院信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.删除学院信息ToolStripMenuItem.Text = "删除学院信息";
            // 
            // 更新学院信息ToolStripMenuItem
            // 
            this.更新学院信息ToolStripMenuItem.Name = "更新学院信息ToolStripMenuItem";
            this.更新学院信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.更新学院信息ToolStripMenuItem.Text = "更新学院信息";
            // 
            // 添加专业信息ToolStripMenuItem
            // 
            this.添加专业信息ToolStripMenuItem.Name = "添加专业信息ToolStripMenuItem";
            this.添加专业信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.添加专业信息ToolStripMenuItem.Text = "添加专业信息";
            // 
            // 添加班级信息ToolStripMenuItem
            // 
            this.添加班级信息ToolStripMenuItem.Name = "添加班级信息ToolStripMenuItem";
            this.添加班级信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.添加班级信息ToolStripMenuItem.Text = "添加班级信息";
            // 
            // 更新班级信息ToolStripMenuItem
            // 
            this.更新班级信息ToolStripMenuItem.Name = "更新班级信息ToolStripMenuItem";
            this.更新班级信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.更新班级信息ToolStripMenuItem.Text = "更新班级信息";
            // 
            // 浏览班级信息ToolStripMenuItem
            // 
            this.浏览班级信息ToolStripMenuItem.Name = "浏览班级信息ToolStripMenuItem";
            this.浏览班级信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.浏览班级信息ToolStripMenuItem.Text = "浏览班级信息";
            // 
            // 浏览专业信息ToolStripMenuItem
            // 
            this.浏览专业信息ToolStripMenuItem.Name = "浏览专业信息ToolStripMenuItem";
            this.浏览专业信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.浏览专业信息ToolStripMenuItem.Text = "浏览专业信息";
            // 
            // 删除班级信息ToolStripMenuItem
            // 
            this.删除班级信息ToolStripMenuItem.Name = "删除班级信息ToolStripMenuItem";
            this.删除班级信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.删除班级信息ToolStripMenuItem.Text = "删除班级信息";
            // 
            // 删除专业信息ToolStripMenuItem
            // 
            this.删除专业信息ToolStripMenuItem.Name = "删除专业信息ToolStripMenuItem";
            this.删除专业信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.删除专业信息ToolStripMenuItem.Text = "删除专业信息";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 503);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem 浏览学生ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加学生ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除学生ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新学生ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton4;
        private System.Windows.Forms.ToolStripMenuItem 添加专业信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 浏览专业信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除专业信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加班级信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新班级信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 浏览班级信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除班级信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 浏览学院信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除学院信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新学院信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton5;
    }
}