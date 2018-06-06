using SIMS.Common;
using System;
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
    public partial class Admin : Form
    {
        public int Oper_Flag = Constants.INSERT;
        public String ID = null;
        public Admin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void Admin_Load(object sender, EventArgs e)
        {
            if (Oper_Flag.Equals(Constants.UPDATE))
            {
                textBox_ID.Text = Constants.AdminID;
                textBox_ID.ReadOnly = true;
            }
        }
        /// <summary>
        /// 添加管理员信息
        /// </summary>
        private void Insert()
        {
            if (textBox_ID.Text.Trim() == "")
            {
                MessageBox.Show("用户名不能为空");
            }
            else
            {
                int c = int.Parse(SQLHelp.ExecuteReArrList("select count(UName) from t_admin where UName = '" + textBox_ID.Text.Trim() + "'")[0].ToString());
                if (c > 0)
                {
                    MessageBox.Show("管理员账号已存在！！");
                }
                else
                {
                    if(maskedTextBox_Pass.Text.Trim() != maskedTextBox_RePass.Text.Trim())
                    {
                        MessageBox.Show("两次密码不一致！！");
                    }
                    else
                    {
                        if (maskedTextBox_Pass.Text.Trim() == "")
                        {
                            MessageBox.Show("密码不能为空！！");
                        }
                        else
                        {
                            SqlParameter[] paras = 
                            {
                                new SqlParameter("@UName",textBox_ID.Text.Trim()),
                                new SqlParameter("@Pass",maskedTextBox_Pass.Text.Trim())
                            };
                            c = SQLHelp.ExecuteProc("proc_admin_insert", paras);
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
                    
                }
            }
        }
        /// <summary>
        /// 更改管理员密码
        /// </summary>
        private void Update()
        {
            if (maskedTextBox_Pass.Text.Trim() != maskedTextBox_RePass.Text.Trim())
            {
                MessageBox.Show("两次密码不一致！！");
            }
            else
            {
                if (maskedTextBox_Pass.Text.Trim() == "")
                {
                    MessageBox.Show("密码不能为空！！");
                }
                else
                {
                    SqlParameter[] paras = 
                            {
                                new SqlParameter("@UName",textBox_ID.Text.Trim()),
                                new SqlParameter("@Pass",maskedTextBox_Pass.Text.Trim())
                            };
                    int c = SQLHelp.ExecuteProc("proc_admin_update", paras);
                    if (c > 0)
                    {
                        MessageBox.Show("更改信息成功！");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("更改信息失败！");
                    }
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
        /// 确定按钮事件
        /// </summary>
        private void button_OK_Click(object sender, EventArgs e)
        {
            switch (Oper_Flag)
            {
                case Constants.INSERT: Insert(); break;
                case Constants.UPDATE: Update(); break;
            }
        }
    }
}
