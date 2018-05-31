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
            //Login login = new Login();
            //login.ShowDialog();
        }
        ///<summary>
        ///窗口加载事件
        ///</summary>
        public void Form1_Load(object sender, EventArgs e)
        {
            if (Login.login)
            {
                this.WindowState = FormWindowState.Maximized;
                this.ToolStripMenuItem_Stu_browse_Click(sender, null);
            }
            else
            {
                this.Close();
            }
        }
        ///<summary>
        ///浏览学生信息按钮事件
        ///</summary>
        private void ToolStripMenuItem_Stu_browse_Click(object sender, EventArgs e)
        {
            Constants.NowMoudel = Constants.Student;
            DataTable dt = Student.ShowInfo();
            this.dataGridView1.DataSource = dt;
            this.Init_InfoPande_Label_TexeBox();
        }
        ///<summary>
        ///添加学生信息按钮事件
        ///</summary>
        private void ToolStripMenuItem_Stu_Add_Click(object sender, EventArgs e)
        {
            Student SI = new Student();
            SI.Oper_Flag = Constants.INSERT;
            SI.ShowDialog();
        }
        ///<summary>
        ///删除学生信息按钮事件
        ///</summary>
        private void ToolStripMenuItem_Stu_Del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认删除？", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxButtons.Button2) == DialogResult.OK)
            {
                Student.Delete(GetId());
            }
        }
        ///<summary>
        ///更新学生信息按钮事件
        ///</summary>
        private void ToolStripMenuItem_Stu_Update_Click(object sender, EventArgs e)
        {
            Student SI = new Student();
            SI.ID = GetId();
            SI.Oper_Flag = Constants.UPDATE;
            SI.ShowDialog();
        }
        ///<summary>
        ///浏览学院信息按钮事件
        ///</summary>
        private void ToolStripMenuItem_Add_depart_Click(object sender, EventArgs e)
        {
            department dt = new department();
            dt.Oper_Flag = Constants.INSERT;
            dt.ShowDialog();
        }
        ///<summary>
        ///删除学院信息按钮事件
        ///</summary> 
        private void ToolStripMenuItem_Del_depart_Click(object sender, EventArgs e)
        {
            department dt = new department();
            dt.Oper_Flag = Constants.UPDATE;
            dt.ID = GetId();
            dt.ShowDialog();
        }
        /// <summary>
        /// 添加专业信息按钮事件
        /// </summary>
        private void ToolStripMenuItem_Add_Major_Click(object sender, EventArgs e)
        {
            major m = new major();
            m.Oper_Flag = Constants.INSERT;
            m.ShowDialog();
        }
        /// <summary>
        /// 更新学院信息按钮事件
        /// </summary>
        private void ToolStripMenuItem_major_update_Click(object sender, EventArgs e)
        {
            major m = new major();
            m.Oper_Flag = Constants.UPDATE;
            m.ShowDialog();
        }
        /// <summary>
        /// 添加班级按钮事件
        /// </summary>
        private void ToolStripMenuItem_Add_Class_Click(object sender, EventArgs e)
        {
            Class c = new Class();
            c.Oper_Flag = Constants.INSERT;
            c.ID = GetId();
            c.ShowDialog();

        }
        /// <summary>
        /// 更新班级按钮事件
        /// </summary>
        private void ToolStripMenuItem_Update_Class_Click(object sender, EventArgs e)
        {
            Class c = new Class();
            c.Oper_Flag = Constants.UPDATE;
            c.ID = GetId();
            c.ShowDialog();
        }
        /// <summary>
        /// 浏览班级按钮事件
        /// </summary>
        private void ToolStripMenuItem_class_browse_Click(object sender, EventArgs e)
        {
            Constants.NowMoudel = Constants.Class;
            DataTable dt = new DataTable();
            this.dataGridView1.DataSource = dt;
            this.Init_Infopande_Label_TextBox();
        }
        /// <summary>
        /// 浏览专业信息按钮事件
        /// </summary>
        private void ToolStripMenuItem_major_browse_Click(object sender, EventArgs e)
        {
            Constants.NowMoudel = Constants.Major;
            DataTable dt = department.ShowInFo();
            this.dataGridView1.DataSource = dt;
            this.Init_Infopande_Label_TextBox();
        }
        /// <summary>
        /// 浏览学院信息学按钮事件
        /// </summary>
        private void ToolStripMenuItem_department_depart_Click(object sender, EventArgs e)
        {
            Constants.NowMoudel = Constants.Department;
            DataTable dt = department.ShowInfo();
            this.dataGridView1.DataSource = dt;
            this.Init_Infopande_Label_TextBox();
        }
    

        
        



    }
}
