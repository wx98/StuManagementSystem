using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Login login = new Login();
            login.ShowDialog();
        }
        ///<summary>
        ///窗口加载事件
        ///</summary>
        public void Form1_Load(object sender, EventArgs e)
        {
            if (Login.login)
            {
                //this.WindowState = FromWindowState.Maximized;
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
           
        }
        ///<summary>
        ///添加学生信息按钮事件
        ///</summary>
        private void ToolStripMenuItem_Stu_Add_Click(object sender, EventArgs e)
        {

        }
        ///<summary>
        ///删除学生信息按钮事件
        ///</summary>
        private void ToolStripMenuItem_Stu_Del_Click(object sender, EventArgs e)
        {

        }
        ///<summary>
        ///更新学生信息按钮事件
        ///</summary>
        private void ToolStripMenuItem_Stu_Update_Click(object sender, EventArgs e)
        {

        }
        ///<summary>
        ///浏览学院信息按钮事件
        ///</summary>
        private void ToolStripMenuItem_Add_depart_Click(object sender, EventArgs e)
        {

        }
        ///<summary>
        ///浏览学院信息按钮事件
        ///</summary> 
        
    }
}
