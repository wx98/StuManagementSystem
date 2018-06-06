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
    public partial class major : Form
    {
        public int Oper_Flag = Constants.INSERT;
        public String ID = null;
        public major()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void major_Load(object sender, EventArgs e)
        {
            String CommandText = "select Name from t_department";
            ArrayList arr = new ArrayList();
            arr = SQLHelp.ExecuteReArrList(CommandText);
            foreach (Object a in arr)
            {
                comboBox_depart.Items.Add(a.ToString());
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
            if (textBox_ID.Text.Trim() == ""
                || textBox_Name.Text.Trim() == ""
                || comboBox_depart.Text.Trim() == ""
               )
            {
                //Showlable();
                MessageBox.Show("信息不完整！！");
            }
            else
            {
                String CommandTex = "select ID from t_department where Name  = '" + comboBox_depart.Text.Trim() + "'";
                ArrayList arr = SQLHelp.ExecuteReArrList(CommandTex);
                if (arr.Count <= 0)
                {
                    if (MessageBox.Show("学院信息不存在是否添加此班级？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        this.Visible = false;
                        department dep_insert = new department();
                        dep_insert.Oper_Flag = Constants.INSERT;
                        dep_insert.ShowDialog();
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
        /// 通过专业编号获取专业名称
        /// </summary>
        /// <param name="DepartNaem">学院名称</param>
        /// <returns>学院编号</returns>
        private int getDepartID(String DepartNaem)
        {
            int DepartID = -1;
            String CommandText = "select ID from t_department where Name ='" + DepartNaem + "'";
            DepartID = Convert.ToInt32(SQLHelp.ExecuteReArrList(CommandText)[0]);
            return DepartID;
        }
        /// <summary>
        /// 通过学院编号获取学院名称
        /// </summary>
        /// <param name="DepartId">学院编号</param>
        /// <returns>学院名称</returns>
        private String getDepartName(int DepartId)
        {
            String DepartName = null;
            String CommandText = "select Name from t_department where ID =" + DepartId;
            DepartName = SQLHelp.ExecuteReArrList(CommandText)[0].ToString();
            return DepartName;
        }
        /// <summary>
        /// 获取专业信息表
        /// </summary>
        /// <returns>专业信息表</returns>
        public static DataTable ShowInfo()
        {
            String CommadnText = "select * from vi_major_info";
            DataTable dt = new DataTable();
            dt = SQLHelp.ExecuteReTable(CommadnText);
            return dt;
        }
        /// <summary>
        /// 搜索专业信息
        /// </summary>
        /// <param name="col">字段名</param>
        /// <param name="condition">关系运算符</param>
        /// <param name="value">要查询的值</param>
        /// <returns>满足要求的专业信息表</returns>
        public static DataTable Search(String col, String condition, String value)
        {
            String CommadnText = "select * from t_department";
            DataTable dt = new DataTable();
            dt = SQLHelp.ExecuteReTable(CommadnText);
            return dt;
        }
        /// <summary>
        /// 删除专业信息
        /// </summary>
        /// <param name="ID">专业编号</param>
        public static void Delete(String ID)
        {
            SqlParameter[] paras = 
            {
                new SqlParameter("@UNo",Convert.ToInt32(ID))
            };
            SQLHelp.ExecuteProc("proc_student_del", paras);
        }
        /// <summary>
        /// 取消按钮事件
        /// </summary>
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 填充专业信息
        /// </summary>
        private void Init_Update()
        {
            String CommandText = "select * from t_major where UNo = " + ID;
            ArrayList arr = SQLHelp.ExecuteReArrList(CommandText);
            textBox_ID.Text = arr[0].ToString();
            textBox_ID.ReadOnly = true;
            textBox_Name.Text = arr[1].ToString();
            comboBox_depart.Text = getDepartName(Convert.ToInt32(arr[2].ToString()));
            textBox_Note.Text = arr[3].ToString();
        }
        /// <summary>
        /// 更新专业信息
        /// </summary>
        private void Update()
        {
            int c = -1;
            SqlParameter[] paras = 
                {
                    new SqlParameter("@ID",Convert.ToInt32(textBox_ID.Text.Trim())),
                    new SqlParameter("@Name",textBox_Name.Text.Trim()),
                    new SqlParameter("@depart",getDepartID( comboBox_depart.Text.Trim())),
                    new SqlParameter("@Note",textBox_Note.Text.Trim()),
                };
            c = SQLHelp.ExecuteProc("proc_major_update", paras);
            if (c > 0)
            {
                MessageBox.Show("修改专业成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("修改专业失败！");
            }
        }
        /// <summary>
        /// 添加专业信息
        /// </summary>
        private void Insert()
        {
            int c = int.Parse(SQLHelp.ExecuteReArrList("select count(ID) from t_major where ID = " + textBox_ID.Text.Trim())[0].ToString());
            if (c > 0)
            {
                MessageBox.Show("专业已存在！！");
            }
            else
            {
                SqlParameter[] paras = 
                {
                     new SqlParameter("@ID",Convert.ToInt32(textBox_ID.Text.Trim())),
                    new SqlParameter("@Name",textBox_Name.Text.Trim()),
                    new SqlParameter("@depart",getDepartID( comboBox_depart.Text.Trim())),
                    new SqlParameter("@Note",textBox_Note.Text.Trim()),
                };
                c = SQLHelp.ExecuteProc("proc_major_insert", paras);
                if (c > 0)
                {
                    MessageBox.Show("添加专业成功！");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加专业失败！");
                }
            }
        }
    }
}
