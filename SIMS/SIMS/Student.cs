using System;
using System.Collections;
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
            String CommandText = "select Name from t_class";
            ArrayList arr = new ArrayList();
            arr = SQLHelp.ExecuteReArrList(CommandText);
            foreach (Object a in arr)
            {
                comboBox_Class.Items.Add(a.ToString());
            }
            if (Oper_Flag.Equals(Constants.UPDATE))
            {
                Init_Update();
            }   
        }
        /// <summary>
        /// 确定按钮事件
        /// </summary>
        private void button_OK_Click(object sender, EventArgs e)
        {
            if (textBox_UNo.Text.Trim() == ""
                || textBox_Name.Text.Trim() == ""
                || textBox_Birth.Text.Trim() == ""
                || textBox_ID.Text.Trim() == ""
                || textBox_Origin.Text.Trim() == ""
                || comboBox_Class.Text.Trim() == ""
                || textBox_IYear.Text.Trim() == "")
            {
                Showlable();
                MessageBox.Show("信息不完整！！");
            }
            else
            {
                String CommandTex = "select ID from t_class where Name  = '" + comboBox_Class.Text.Trim() + "'";
                ArrayList arr = SQLHelp.ExecuteReArrList(CommandTex);
                if (arr.Count <= 0)
                {
                    if (MessageBox.Show("班级信息不存在是否添加此班级？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        this.Visible = false;
                        Class class_insert = new Class();
                        class_insert.Oper_Flag = Constants.INSERT;
                        class_insert.ShowDialog();
                        this.Visible = true;
                    }
                    else
                    {
                        switch (Oper_Flag)
                        {
                            case Constants.INSERT: Insert(); break;
                            case Constants.UPDATE: Update(); break;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 显示非空字段后面的提示
        /// </summary>
        private void Showlable()
        {
            
        }
        /// <summary>
        /// '取消按钮事件'
        /// </summary>
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 添加学生信息
        /// </summary>
        private void Insert()
        {
            String Sex = null;
            if (radioButton_Female.Checked == true)
            {
                Sex = "女";
            }
            else
            {
                Sex = "男";
            }
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
            String CommadnText = "select * from t_student";
            DataTable dt = new DataTable();
            dt = SQLHelp.ExecuteReTable(CommadnText);
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
            String CommadnText = "select * from t_student";
            DataTable dt = new DataTable();
            dt = SQLHelp.ExecuteReTable(CommadnText);
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
