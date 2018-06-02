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
    public partial class Student : Form
    {
        public int Oper_Flag = Constants.INSERT;
        public String ID = null;
        public Student()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 学生信息加载事件
        /// </summary>
        private void Student_Load(object sender, EventArgs e)
        {
            //缺少代码

            //缺少代码
        }
        /// <summary>
        /// 确定按钮事件
        /// </summary>
        private void button_OK_Click(object sender, EventArgs e)
        {
            //缺少代码

            //缺少代码
        }
        /// <summary>
        /// 显示非空字段后面的提示
        /// </summary>
        private void Showlable()
        {
            //缺少代码

            //缺少代码
        }
        /// <summary>
        /// '取消按钮事件'
        /// </summary>
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            //缺少代码

            //缺少代码
        }
        /// <summary>
        /// 添加学生信息
        /// </summary>
        private void Insert()
        {
            //缺少代码

            //缺少代码
        }
        /// <summary>
        /// 更新学生信息
        /// </summary>
        public void Update()
        {
            //缺少代码

            //缺少代码
        }
        /// <summary>
        /// 填充学生信息
        /// </summary>
        public void Init_Update()
        {
            //缺少代码

            //缺少代码
        }
        /// <summary>
        /// 通过班级名称获取班级编号
        /// </summary>
        /// <param name="ClassName">班级名称</param>
        /// <returns>班级编号</returns>
        public int getClassID(String ClassName)
        {
            int ClassID = -1;
            //缺少代码

            //缺少代码
            return ClassID;
        }
        /// <summary>
        /// 通过班级编号获取班级名称
        /// </summary>
        /// <param name="ClassID">班级编号</param>
        /// <returns>班级名称</returns>
        private String getClassName(int ClassID)
        {
            String ClassName = null;
            //缺少代码

            //缺少代码
            return ClassName;
        }
        /// <summary>
        /// 获取学生信息表
        /// </summary>
        /// <returns>学生信息表</returns>
        public static DataTable ShowInfo()
        {
            //缺少代码
            DataTable dt = new DataTable();
            //缺少代码
            return dt;
        }
        /// <summary>
        /// 搜索学生信息
        /// </summary>
        /// <param name="col">字段名</param>
        /// <param name="condition">关系运算符</param>
        /// <param name="value">要查询的值</param>
        /// <returns>满足要求的学生信息表</returns>
        public static DataTable Search(String col, String condition, String value)
        {
            //缺少代码
            DataTable dt = new DataTable();
            //缺少代码
            return dt;
        }
        /// <summary>
        /// 删除学学生信息
        /// </summary>
        /// <param name="UNo">学号</param>
        public static void Delete(String UNo)
        {
            //缺少代码

            //缺少代码  
        }
    }
}
