using SIMS.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SIMS
{
    public partial class Class : Form
    {
        public int Oper_Flag = Constants.INSERT;
        public String ID = null;
        public Class()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void Class_Load(object sender, EventArgs e)
        {
            String CommandText = "select Name from t_major";
            ArrayList arr = new ArrayList();
            arr = SQLHelp.ExecuteReArrList(CommandText);
            foreach (Object a in arr)
            {
                comboBox_Major.Items.Add(a.ToString());
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
            if (textBox_Name.Text.Trim() == ""
                || textBox_ID.Text.Trim() == ""
                || comboBox_Major.Text.Trim() == ""
                || textBox_Couns.Text.Trim() == "")
            {
                //Showlable();
                MessageBox.Show("信息不完整！！");
            }
            else
            {
                String CommandTex = "select ID from t_major where Name  = '" + comboBox_Major.Text.Trim() + "'";
                ArrayList arr = SQLHelp.ExecuteReArrList(CommandTex);
                if (arr.Count <= 0)
                {
                    if (MessageBox.Show("专业信息不存在是否添加此专业？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        this.Visible = false;
                        major major_insert = new major();
                        major_insert.Oper_Flag = Constants.INSERT;
                        major_insert.ShowDialog();
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
        /// 通过专业名称获取专业ID
        /// </summary>
        /// <param name="MajorName">专业名称</param>
        /// <returns>转而编号</returns>
        private int getMajorID(String MajorName)
        {
            int MajorID = -1;
            String CommandText = "select ID from t_major where Name ='" + MajorName + "'";
            MajorID = Convert.ToInt32(SQLHelp.ExecuteReArrList(CommandText)[0]);
            return MajorID;
        }
        /// <summary>
        /// 通过专业编号获得专业名称
        /// </summary>
        /// <param name="MagorID">专业编号</param>
        /// <returns>专业名称</returns>
        private String getMajorName(int MagorID)
        {
            String MajorName = null;
            //缺少代码
            String CommandText = "select Name from t_major where ID =" + MagorID;
            MajorName = SQLHelp.ExecuteReArrList(CommandText)[0].ToString();
            //缺少代码
            return MajorName;
        }
        /// <summary>
        /// 获取班级信息表
        /// </summary>
        /// <returns>学生信息表</returns>
        public static DataTable ShowInfo()
        {
            String CommadnText = "select * from vi_class_info";
            DataTable dt = new DataTable();
            dt = SQLHelp.ExecuteReTable(CommadnText);
            return dt;
        }
        /// <summary>
        /// 搜索班级信息
        /// </summary>
        /// <param name="col">字段名</param>
        /// <param name="condition">关系运算符</param>
        /// <param name="value">要查询的值</param>
        /// <returns>满足要求的半截信息表</returns>
        public static DataTable Search(String col, String condition, String value)
        {
            String CommandText = "select * from t_major";
            DataTable dt = new DataTable();
            dt = SQLHelp.ExecuteReTable(CommandText);
            return dt;
        }
        /// <summary>
        /// 删除班级信息
        /// </summary>
        /// <param name="ID">班级编号</param>
        public static void Delete(String ID)
        {
            SqlParameter[] paras = 
            {
                new SqlParameter("@ID",Convert.ToInt32(ID))
            };
            SQLHelp.ExecuteProc("proc_class_del",paras);
        }
        /// <summary>
        /// 取消按钮事件
        /// </summary>
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 填充班级信息
        /// </summary>
        private void Init_Update()
        {
            String CommandText = "select * from t_class where ID = " + ID;
            ArrayList arr = SQLHelp.ExecuteReArrList(CommandText);
            textBox_ID.Text = arr[0].ToString();
            textBox_ID.ReadOnly = true;
            textBox_Name.Text = arr[1].ToString();
            comboBox_Major.Text = getMajorName(Convert.ToInt32(arr[2].ToString()));
            textBox_Couns.Text = arr[3].ToString();
        }
        /// <summary>
        /// 添加班级信息
        /// </summary>
        private void Insert()
        {
            int c = int.Parse(SQLHelp.ExecuteReArrList("select count(ID) from t_class where ID = " + textBox_ID.Text.Trim())[0].ToString());
            if (c > 0)
            {
                MessageBox.Show("班级已存在！！");
            }
            else
            {
                SqlParameter[] paras = 
                {
                    new SqlParameter("@UNo",Convert.ToInt32(textBox_ID.Text.Trim())),
                    new SqlParameter("@Name",Convert.ToInt32(textBox_Name.Text.Trim())),
                    new SqlParameter("@major",Convert.ToInt32(comboBox_Major.Text.Trim())),
                    new SqlParameter("@Couns",Convert.ToInt32(textBox_Couns.Text.Trim())),
                };
                c = SQLHelp.ExecuteProc("proc_class_insert", paras);
                if (c > 0)
                {
                    MessageBox.Show("添加班级成功！");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加班级失败！");
                }
            }
        }
        /// <summary>
        /// 更新班级信息
        /// </summary>
        private void Update()
        {
            int c = -1;
            SqlParameter[] paras = 
                {
                    new SqlParameter("@UNo",Convert.ToInt32(textBox_ID.Text.Trim())),
                    new SqlParameter("@Name",Convert.ToInt32(textBox_Name.Text.Trim())),
                    new SqlParameter("@major",Convert.ToInt32(comboBox_Major.Text.Trim())),
                    new SqlParameter("@Couns",Convert.ToInt32(textBox_Couns.Text.Trim())),
                };
            c = SQLHelp.ExecuteProc("proc_class_update", paras);
            if (c > 0)
            {
                MessageBox.Show("修改班级成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("修改班级失败！");
            }
        }
    }
}
