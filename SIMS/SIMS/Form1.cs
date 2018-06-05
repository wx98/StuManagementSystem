
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIMS.Common;

namespace SIMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Login login = new Login();  //实例化登录模块
            login.ShowDialog();         //显示登录模块
        }
        ///<summary>
        ///窗口加载事件
        ///</summary>
        public void Form1_Load(object sender, EventArgs e)
        {
            if (Login.login)
            {
               // 最大化界面
                //this.WindowState = FormWindowState.Maximized;
               // 模拟单击浏览信息按钮从而显示学生信息
               this.ToolStripMenuItem_Stu_browse_Click(sender, null);
            }
            else
            {
                this.Close();   //关闭系统
            }
        }
        /*--------------------------检查完成------------------------------------------------*/
        ///<summary>
        ///增加学生信息按钮事件
        ///</summary>
        private void ToolStripMenuItem_Stu_Add_Click(object sender, EventArgs e)
        {
            //实例化一个学生模块
            Student SI = new Student();
            //设置操作标记为添加信息
            SI.Oper_Flag = Constants.INSERT;
            //显示学生信息模块
            SI.ShowDialog();
        }
        ///<summary>
        ///删除学生信息按钮事件 
        ///</summary>
        private void ToolStripMenuItem_Stu_Del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认删除？","删除信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Student.Delete(GetId());
            }
        }
        ///<summary>
        ///更改学生信息按钮事件
        ///</summary>
        private void ToolStripMenuItem_Stu_Update_Click(object sender, EventArgs e)
        {
            Student SI = new Student();
            SI.ID = GetId();
            SI.Oper_Flag = Constants.UPDATE;
            SI.ShowDialog();
        }
        ///<summary>
        ///浏览学生信息按钮事件
        ///</summary>
        private void ToolStripMenuItem_Stu_browse_Click(object sender, EventArgs e)
        {
            //设置正在执行的模块为学生信息模块
            Constants.NowMoudel = Constants.Student;
            //获取学生信息
            DataTable dt = Student.ShowInfo();
            this.dataGridView1.DataSource = dt;
            //重新布局详细信息面板
            //this.Init_InfoPande_Label_TextBox();
        }
        /*--------------------------检查完成------------------------------------------------*/
        /// <summary>
        /// 增加专业信息按钮事件
        /// </summary>
        private void ToolStripMenuItem_major_Add_Click(object sender, EventArgs e)
        {
            //实例化专业信息模块
            major m = new major();
            //设置操作标记为添加信息
            m.Oper_Flag = Constants.INSERT;
            //显示专业信息模块
            m.ShowDialog();
        }
        /// <summary>
        /// 删除专业信息按钮事件
        /// </summary>
        private void ToolStripMenuItem_major_Del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认删除？", "删除信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Student.Delete(GetId());
            }
        }
        /// <summary>
        /// 更改学院信息按钮事件
        /// </summary>
        private void ToolStripMenuItem_major_Update_Click(object sender, EventArgs e)
        {
            //实例化专业模块
            major m = new major();
            //设置操作标记为添加信息
            m.Oper_Flag = Constants.UPDATE;
            //显示班级信息模块
            m.ShowDialog();
        }
        /// <summary>
        /// 浏览专业信息按钮事件
        /// </summary>
        private void ToolStripMenuItem_major_browse_Click(object sender, EventArgs e)
        {
            //设置正在执行的模块为专业信息模块
            Constants.NowMoudel = Constants.Major;
            //获取班级专业信息
            DataTable dt = department.ShowInfo();
            this.dataGridView1.DataSource = dt;
            //重新布局详细信息面板
           // this.Init_InfoPande_Label_TextBox();
        }
        /*--------------------------检查完成------------------------------------------------*/
        ///<summary>
        /// 增加学院信息按钮事件
        ///</summary>
        private void ToolStripMenuItem_depart_Add_Click(object sender, EventArgs e)
        {
            //实例化学院信息模块
            department dt = new department();
            //实际操作标记更新为添加信息
            dt.Oper_Flag = Constants.INSERT;
            //显示学院信息模块
            dt.ShowDialog();
        }
        ///<summary>
        /// 删除学院信息按钮事件
        ///</summary> 
        private void ToolStripMenuItem_depart_Del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认删除？ ", "删除信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Class.Delete(GetId());
            }
        }
        /// <summary>
        /// 更改学院信息按钮事件
        /// </summary>
        private void ToolStripMenuItem_depart_Update_Click(object sender, EventArgs e)
        {
            //实例化专业信息模块
            department dt = new department();
            //设置操作标记为更新信息
            dt.Oper_Flag = Constants.UPDATE;
            //设置学院信息的学院编号变量为当前所选学院的编号
            dt.ID = GetId();
            //显示学院信息的模块
            dt.ShowDialog();
        }
        /// <summary>
        /// 浏览学院信息按钮事件
        /// </summary>
        private void ToolStripMenuItem_depart_browse_Click(object sender, EventArgs e)
        {
            //设置正在执行的模块为学院信息模块
            Constants.NowMoudel = Constants.Department;
            //获取班级学院信息
            DataTable dt = department.ShowInfo();
            this.dataGridView1.DataSource = dt;
            //重新布局详细信息面板
            //this.Init_InfoPande_Label_TextBox();
        }
        /*--------------------------检查完成------------------------------------------------*/
        /// <summary>
        /// 增加班级按钮事件
        /// </summary>
        private void ToolStripMenuItem_class_Add_Click(object sender, EventArgs e)
        {
            //实例化班级信息模块
            Class c = new Class();
            //设置操作标记为添加信息
            c.Oper_Flag = Constants.INSERT;
            //显示班级信息模块
            c.ShowDialog();
        }
        /// <summary>
        /// 删除班级信息按钮事件
        /// </summary>
        private void ToolStripMenuItem_class_Del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认删除？ ", "删除信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Class.Delete(GetId());
            }
        }
        /// <summary>
        /// 更改班级按钮事件
        /// </summary>
        private void ToolStripMenuItem_class_Update_Click(object sender, EventArgs e)
        {
            //示例化一个班级信息模块
            Class c = new Class();
            //设置标记操作为更新信息
            c.Oper_Flag = Constants.UPDATE;
            //设置班级信息模块的班级编号变量为当前所选班级的编号
            c.ID = GetId();
            //显示班级信息模块
            c.ShowDialog();
        }
        /// <summary>
        /// 浏览班级按钮事件
        /// </summary>
        private void ToolStripMenuItem_class_browse_Click(object sender, EventArgs e)
        {
            //设置正在执行的模块为班级信息模块
            Constants.NowMoudel = Constants.Class;
            //获取班级信息
            DataTable dt = new DataTable();
            this.dataGridView1.DataSource = dt;
            //重新布局详细面板信息
            //this.Init_InfoPande_Label_TextBox();
        }
        /*-------------------------------------------------------------------------*/
        /// <summary>
        /// 获取当前dataGridView所选取的信息编号
        /// </summary>
        /// <returns>当前所选信息的ID</returns>
        private String GetId()
        {
            String ID = null;
            ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            return ID;
        }
        /// <summary>
        /// 单击DataGridView触发的事件
        /// </summary>
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //Init_InfoPande_Label_TextBox();
        }
        ComboBox cb = null;             //搜索字段
        ComboBox condition = null;      //关系运算符
        TextBox value = null;           //值
        /// <summary>
        ///初始化详细面板信息
        /// </summary>
        //private void Init_InfoPande_Label_TextBox()
        //{
        //    //清空详细信息面板
        //    this.info_pandel.Controls.Clear();
        //    //获得字段数量
        //    int ColCount = this.dataGridView1.ColumnCount;
        //    //控制x轴坐标
        //    int x = 10;
        //    //控制y轴坐标
        //    int y = 5;
        //    //根据字段数量实例化Label数组
        //    Label[] labels = new Label[ColCount];
        //    //根据字段数量实例化TextBox数组
        //    TextBox[] textbox = new TextBox[ColCount];
        //    //根据字段名为Label赋值
        //    for (int i = 0; i < ColCount; i++)
        //    {
        //        labels[i] = new Label();
        //        //设置Label的大小为自适应
        //        labels[i].AutoSize = true;
        //        //设置Label的值为对应的字段名
        //        labels[i].Text = this.dataGridView1.Columns[i].Name + "";
        //        //将Label添加到面板中
        //        this.info_pandel.Controls.Add(labels[i]);
        //    }
        //    //若是超过总字段数量的1/2将y轴坐标下移
        //    for (int i = 0; i < ColCount / 2; i++)
        //    {
        //        //设置上方 Label 与下方Label右对齐
        //        int diff = labels[i].Text.Length - labels[i + ColCount / 2].Text.Length;
        //        if (diff > 0)
        //        {
        //            for(int j = 0;j > diff ; j++)
        //                labels[i+ColCount / 2].Text = "  "+ labels[i+ColCount / 2].Text;
        //        }
        //        if (diff < 0)
        //        {
        //            for (int j = 0; j > diff; j --)
        //            {
        //                labels[i].Text = "  " + labels[i].Text;
        //                continue;
        //            }
        //        }
        //    }
        //    for (int i = 0; i < ColCount; i++)
        //    {
        //        if (i == (ColCount / 2))
        //        {
        //            x = 10;
        //            y = 30;
        //        }

        //        labels[i].Location = new Point(x, y);
        //        x+=labels[i].Width;

        //        textbox[i] = new TextBox();
        //        //设置 TextBox的坐标
        //        textbox[i].Location = new Point(x, y - 5);
        //        //s设置 TextBox 为只读
        //        textbox[i].ReadOnly = true;
        //        //填充 TextBox 为对应值
        //        textbox[i].Text = dataGridView1.SelectedRows[0].Cells[i].Value.ToString();
        //        //添加TextBox 到信息面板中
        //        this.info_pandel.Controls.Add(textbox[i]);
        //        x += textbox[i].Width;
        //    }
        //    x += 20;
        //    y = 5;
        //    //添加搜索的字段 Label
        //    Label col = new Label();
        //    col.AutoSize = true;
        //    col.Text = "字段：";
        //    this.info_pandel.Controls.Add(col);
        //    x += col.Width;
        //    //添加字段名的ComboBox
        //    cb = new ComboBox();
        //    cb.Location = new Point(x, y - 5);
        //    cb.DropDownStyle = ComboBoxStyle.DropDownList;
        //    for (int i = 0; i < ColCount; i++)
        //    {
        //        cb.Items.Add(this.dataGridView1.Columns[i].Name);
        //    }
        //    cb.SelectedIndex = 0;
        //    this.info_pandel.Controls.Add(cb);

        //    x += cb.Width;
        //    //添加条件Label
        //    Label condi = new Label();
        //    condi.Location = new Point(x, y);
        //    condi.AutoSize = true;
        //    condi.Text = "条件";
        //    this.info_pandel.Controls.Add(condi);
        //    x += condi.Width;
        //    //添加关系运算符的ComboBox
        //    condition = new ComboBox();
        //    condition.Location = new Point(x, y - 5);
        //    condition.Size = new Size(40, 20);
        //    condition.DropDownStyle = ComboBoxStyle.DropDownList;
        //    condition.Items.Add("=");
        //    condition.Items.Add(">");
        //    condition.Items.Add("<");
        //    condition.Items.Add(">=");
        //    condition.Items.Add("<=");
        //    condition.SelectedIndex = 0;
        //    this.info_pandel.Controls.Add(condition);
        //    y = 30;
        //    x = col.Location.X;
        //    //添加值Label
        //    Label var = new Label();
        //    var.Location = new Point(x, y);
        //    var.AutoSize = true;
        //    var.Text = "  值： ";
        //    this.info_pandel.Controls.Add(var);
        //    x += var.Width;

        //    //添加值TextBox
        //    value = new TextBox();
        //    value.Location = new Point(x, y - 5);
        //    this.info_pandel.Controls.Add(value);
        //    x += value.Width;
        //    //添加查询按钮Button
        //    Button Search = new Button();
        //    Search.Location = new Point(x + 30, y - 5);
        //    Search.Text = "查询";
        //    //为查询按钮添加单击事件
        //    Search.Click += new EventHandler(Search_Click);
        //    this.info_pandel.Controls.Add(Search);
        //    //锁定与激活相应的删除与更新按钮
        //    Init_menuStrip1();
        //}
        /// <summary>
        /// 查询按钮事件
        /// </summary>
        private void Search_Click(object sender, EventArgs e)
        {
            switch (Constants.NowMoudel)
            {
                case Constants.Department: // 搜索学院信息
                    this.dataGridView1.DataSource = department.Search(cb.Text.Trim(),condition.Text.Trim(),value.Text.Trim());
                    break;
                case Constants.Major:     // 搜索专业信息
                    this.dataGridView1.DataSource = major.Search(cb.Text.Trim(), condition.Text.Trim(), value.Text.Trim());
                    break;
                case Constants.Class:     // 搜索班级信息
                    this.dataGridView1.DataSource = Class.Search(cb.Text.Trim(), condition.Text.Trim(), value.Text.Trim());
                    break;
                case Constants.Student :  // 搜索学生信息
                    this.dataGridView1.DataSource = Student.Search(cb.Text.Trim(), condition.Text.Trim(), value.Text.Trim());
                    break;
            }
        }
        /// <summary>
        /// 锁定与激活相应的删除修改按钮
        /// </summary>
        private void Init_menuStrip1()
        {
            //锁定删除与更新班级按钮
            this.ToolStripMenuItem_class_Del.Enabled = false;
            this.ToolStripMenuItem_class_Update.Enabled = false;
            
            //锁定删除与更新学院按钮
            this.ToolStripMenuItem_depart_Update.Enabled = false;
            this.ToolStripMenuItem_depart_Del.Enabled = false;

            //锁定删除与更新专业按钮
            this.ToolStripMenuItem_major_Del.Enabled = false;
            this.ToolStripMenuItem_major_Update.Enabled = false;

            //锁定删除与更新学生按钮
            this.ToolStripMenuItem_Stu_Del.Enabled = false;
            this.ToolStripMenuItem_Stu_Update.Enabled = false;
            switch (Constants.NowMoudel)
            {
                case Constants.Department:
                     this.ToolStripMenuItem_depart_Update.Enabled = true;
                     this.ToolStripMenuItem_depart_Del.Enabled = true;
                     break;
                case Constants.Major:
                     this.ToolStripMenuItem_major_Del.Enabled = true;
                     this.ToolStripMenuItem_major_Update.Enabled = true;
                     break;
                case Constants.Class:
                     this.ToolStripMenuItem_class_Del.Enabled = true;
                     this.ToolStripMenuItem_class_Update.Enabled = true;
                     break;
                case Constants.Student:
                     this.ToolStripMenuItem_Stu_Del.Enabled = true;
                     this.ToolStripMenuItem_Stu_Update.Enabled = true;
                     break;
            }
        }
        /// <summary>
        /// 增加管理员信息按钮事件 √
        /// </summary>
        private void ToolStripMenuItem_Admin_Add_Click(object sender, EventArgs e)
        {
            //示例化管理员模块
            Admin ad = new Admin();
            //设置模块操作标记为插入信息
            ad.Oper_Flag = Constants.INSERT;
            //显示管理员模块
            ad.ShowDialog();
        }
        /// <summary>
        /// 更新管理员信息模块 √
        /// </summary>
        private void ToolStripMenuItem_Admin_Update_Click(object sender, EventArgs e)
        {
            //示例化管理员模块
            Admin ad = new Admin();
            //设置模块操作标记为更新信息
            ad.Oper_Flag = Constants.UPDATE;
            //显示管理员模块
            ad.ShowDialog();
        }
        /// <summary>
        /// 关闭程序按钮事件 √
        /// </summary>
        private void ToolStripMenuItem_Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认退出系统？ ", "退出系统", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
