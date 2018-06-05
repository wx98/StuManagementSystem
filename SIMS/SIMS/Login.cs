using SIMS;
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
    public partial class Login : Form
    {
        public static Boolean login = false;
        public Login()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 取消按钮事件
        /// </summary>
        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            login = false;
            this.Close();
        }
        /// <summary>
        /// '登录'按钮事件
        /// </summary>
        private void bt_Login_Click(object sender, EventArgs e)
        {
            ArrayList arr = new ArrayList();
            String CommandText = "select  count(ID) from t_admin where UName = '" + textBox_UserName.Text.Trim() + "'";
            arr = SQLHelp.ExecuteReArrList(CommandText);
            if (arr[0].ToString().Equals("0"))
            {
                MessageBox.Show("用户名不存在！");
            }
            else
            {
                CommandText = "select * from t_admin where UName = '"+textBox_UserName.Text.Trim()+"'";
                arr = SQLHelp.ExecuteReArrList(CommandText);
                if (TextBox_Pass.Text.Trim().Equals(arr[2]))
                {
                    Constants.AdminID = textBox_UserName.Text.Trim();
                    this.Close();
                    login = true;
                }
                else
                {
                    MessageBox.Show("密码不正确！！");
                }
            }

        }

        
    }
}
