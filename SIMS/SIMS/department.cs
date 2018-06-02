using SIMS.Common;
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
            //缺少代码

            //缺少代码
        }
        /// <summary>
        /// 确定按钮事件
        /// </summary>
        private void button_OK_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 取消按钮事件
        /// </summary>
        private void button_Cancel_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 获取学院信息表
        /// </summary>
        /// <returns>学员们信息表</returns>
        public static DataTable ShowInfo()
        {
            //缺少代码
            DataTable dt = new DataTable();
            //缺少代码
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
            //缺少代码
            DataTable dt = new DataTable();
            //缺少代码
            //缺少代码
            return dt;
        }
        /// <summary>
        /// 删除学院信息
        /// </summary>
        public static void Delete()
        {
            //缺少代码
            
            //缺少代码
        }
        /// <summary>
        /// 添加学院信息
        /// </summary>
        private void Insert()
        {
            //缺少代码

            //缺少代码
        }
    }
}
