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
using System.Data.SqlClient;

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
            //label_UNo.Visible = true;
            //label_Name.Visible = true;
            //label_Birth.Visible = true;
            //label_Class.Visible = true;
            //label_ID.Visible = true;
            //label_IYear.Visible = true;
            //label_Origin.Visible = true;
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
            int c = int.Parse(SQLHelp.ExecuteReArrList("select count(ID) from t_student where ID = " + textBox_ID.Text.Trim())[0].ToString());
            if (c > 0)
            {
                MessageBox.Show("学号已存在！！");
            }
            else
            {
                SqlParameter[] paras = 
                {
                    new SqlParameter("@UNo",Convert.ToInt32(textBox_ID.Text.Trim())),
                    new SqlParameter("@Name",Convert.ToInt32(textBox_Name.Text.Trim())),
                    new SqlParameter("@Sex",Sex),
                    new SqlParameter("@Birth",Convert.ToInt32(textBox_Birth.Text.Trim())),
                    new SqlParameter("@Origin",Convert.ToInt32(textBox_Origin.Text.Trim())),
                    new SqlParameter("@Addr",Convert.ToInt32(textBox_Addr.Text.Trim())),
                    new SqlParameter("@Tel",Convert.ToInt32(textBox_Tel.Text.Trim())),
                    new SqlParameter("@IYera",Convert.ToInt32(textBox_IYear.Text.Trim())),
                    new SqlParameter("@class",Convert.ToInt32(comboBox_Class.Text.Trim())),
                    new SqlParameter("@Note",Convert.ToInt32(textBox_Note.Text.Trim())),
                };
                c = SQLHelp.ExecuteProc("proc_student_insert", paras);
                if (c > 0)
                {
                    MessageBox.Show("添加信息成功！");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加信息失败！");
                }
            }
        }
        /// <summary>
        /// 更新学生信息
        /// </summary>
        public void Update()
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
            SqlParameter[] paras = 
                {
                    new SqlParameter("@UNo",Convert.ToInt32(textBox_ID.Text.Trim())),
                    new SqlParameter("@Name",Convert.ToInt32(textBox_Name.Text.Trim())),
                    new SqlParameter("@Sex",Sex),
                    new SqlParameter("@Birth",Convert.ToInt32(textBox_Birth.Text.Trim())),
                    new SqlParameter("@Origin",Convert.ToInt32(textBox_Origin.Text.Trim())),
                    new SqlParameter("@Addr",Convert.ToInt32(textBox_Addr.Text.Trim())),
                    new SqlParameter("@Tel",Convert.ToInt32(textBox_Tel.Text.Trim())),
                    new SqlParameter("@IYera",Convert.ToInt32(textBox_IYear.Text.Trim())),
                    new SqlParameter("@class",Convert.ToInt32(comboBox_Class.Text.Trim())),
                    new SqlParameter("@Note",Convert.ToInt32(textBox_Note.Text.Trim())),
                };
            int c = SQLHelp.ExecuteProc("proc_class_update", paras);
            if (c > 0)
            {
                MessageBox.Show("修改学生信息成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("修改学生信息失败！");
            }
        }
        /// <summary>
        /// 填充学生信息
        /// </summary>
        public void Init_Update()
        {
            String CommandText = "select * from t_Student where UNo = " + ID;
            ArrayList arr = SQLHelp.ExecuteReArrList(CommandText);
            textBox_UNo.Text = arr[0].ToString();
            textBox_UNo.ReadOnly = true;
            textBox_Name.Text = arr[1].ToString();
            if (arr[2].Equals("男"))
                radioButton_Male.Checked = true;
            else
                radioButton_Female.Checked = true;
            textBox_Birth.Text = arr[3].ToString();
            textBox_ID.Text = arr[4].ToString();
            textBox_Origin.Text = arr[5].ToString();
            textBox_Addr.Text = arr[6].ToString();
            textBox_Tel.Text = arr[7].ToString();
            textBox_IYear.Text = arr[8].ToString();
            comboBox_Class.Text = getClassName(Convert.ToInt32(arr[9].ToString()));
            textBox_Note.Text = arr[10].ToString();
        }
        /// <summary>
        /// 通过班级名称获取班级编号
        /// </summary>
        /// <param name="ClassName">班级名称</param>
        /// <returns>班级编号</returns>
        public int getClassID(String ClassName)
        {
            int ClassID = -1;
            String CommandText = "select ID from t_class where Name ='" + ClassName + "'";
            ClassID = Convert.ToInt32(SQLHelp.ExecuteReArrList(CommandText)[0]);
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
            String CommandText = "select Name from t_class where ID =" + ClassID ;
            ClassName = SQLHelp.ExecuteReArrList(CommandText)[0].ToString();
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
            return dt;
        }
        /// <summary>
        /// 删除学学生信息
        /// </summary>
        /// <param name="UNo">学号</param>
        public static void Delete(String UNo)
        {
          SqlParameter[] paras = 
          {
              new SqlParameter("@UNo",Convert.ToInt32(UNo))
          };
          SQLHelp.ExecuteProc("proc_student_del",paras);
        }
    }
}
