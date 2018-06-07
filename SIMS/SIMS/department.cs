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
    public partial class department : Form
    {
        public int Oper_Flag = Constants.INSERT;
        public String ID = null;
        public department()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void department_Load(object sender, EventArgs e)
        {
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
            if (textBox_ID.Text.Trim() == ""|| textBox_Name.Text.Trim() == ""|| textBox_Direc.Text.Trim() == "" )
            {
                MessageBox.Show("信息不完整！！");
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
        /// <summary>
        /// 取消按钮事件
        /// </summary>
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 填充学院信息
        /// </summary>
        private void Init_Update()
        {
            String CommandText = "select * from t_department where ID = " + ID;
            ArrayList arr = new ArrayList();
            arr =  SQLHelp.ExecuteReArrList(CommandText);
            textBox_ID.Text = arr[0].ToString();
            textBox_ID.ReadOnly = true;
            textBox_Name.Text = arr[1].ToString();
            textBox_Direc.Text = arr[2].ToString();
            textBox_Note.Text = arr[3].ToString();

        }
        /// <summary>
        /// 更新学院信息
        /// </summary>
        private void Update()
        {
            int c = -1;
            SqlParameter[] paras = 
                {
                    new SqlParameter("@ID",Convert.ToInt32(textBox_ID.Text.Trim())),
                    new SqlParameter("@Name",textBox_Name.Text.Trim()),
                    new SqlParameter("@Direc",textBox_Direc.Text.Trim()),
                    new SqlParameter("@Note",textBox_Note.Text.Trim())
                };
            c = SQLHelp.ExecuteProc("proc_department_update", paras);
            if (c > 0)
            {
                MessageBox.Show("修改院系成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("修改院系失败！");
            }
        }
        /// <summary>
        /// 获取学院信息表
        /// </summary>
        /// <returns>学员们信息表</returns>
        public static DataTable ShowInfo()
        {
            String CommadnText = "select * from vi_department_info";
            DataTable dt = new DataTable();
            dt = SQLHelp.ExecuteReTable(CommadnText);
            dt.TableName = "department";
            return dt;
        }
        /// <summary>
        /// 搜索学院信息
        /// </summary>
        /// <param name="col">字段名</param>
        /// <param name="condition">关系运算符</param>
        /// <param name="value">要查询信息的值</param>
        /// <returns>满足要求的学院信息表</returns>
        public static DataTable Search(String col, String condition, String value)
        {
            String CommadnText = "select * from vi_department_info where " + col + "" + condition +"'" +value+"'";
            DataTable dt = new DataTable();
            dt = SQLHelp.ExecuteReTable(CommadnText);
            return dt;
        }
        /// <summary>
        /// 删除学院信息
        /// </summary>
        public void Delete()
        {
            SqlParameter[] paras = 
            {
                new SqlParameter("@ID",Convert.ToInt32(ID))
            };
            SQLHelp.ExecuteProc("proc_major_del", paras);
        }
        /// <summary>
        /// 添加学院信息
        /// </summary>
        private void Insert()
        {
            int c = int.Parse(SQLHelp.ExecuteReArrList("select count(ID) from t_department where ID = " + textBox_ID.Text.Trim())[0].ToString());
            if (c > 0)
            {
                MessageBox.Show("院系编号已存在！！");
            }
            else
            {
                SqlParameter[] paras = 
                {
                     new SqlParameter("@ID",Convert.ToInt32(textBox_ID.Text.Trim())),
                    new SqlParameter("@Name",textBox_Name.Text.Trim()),
                    new SqlParameter("@Direc",textBox_Direc.Text.Trim()),
                    new SqlParameter("@Note",textBox_Note.Text.Trim())
                };
                c = SQLHelp.ExecuteProc("proc_department_insert", paras);
                if (c > 0)
                {
                    MessageBox.Show("添加院系成功！");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加院系失败！");
                }
            }
        }
    }
}
