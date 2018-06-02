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
        /// 通过专业编号获取专业名称
        /// </summary>
        /// <param name="DepartNaem">学院名称</param>
        /// <returns>学院编号</returns>
        private int getDepartID(String DepartNaem)
        {
            int DepartID = -1;
            //缺少代码

            //缺少代码
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
            //缺少代码

            //缺少代码
            return DepartName;
        }
        /// <summary>
        /// 获取专业信息表
        /// </summary>
        /// <returns>专业信息表</returns>
        public static DataTable ShowInfo()
        {
            //缺少代码
            DataTable dt = new DataTable();
            //缺少代码
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
            //缺少代码
            DataTable dt = new DataTable();
            //缺少代码
            return dt;
        }
        /// <summary>
        /// 删除专业信息
        /// </summary>
        /// <param name="ID">专业编号</param>
        public static void Delete(String ID)
        {
            //缺少代码 
             
            //缺少代码
        }
        /// <summary>
        /// 取消按钮事件
        /// </summary>
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            //缺少代码

            //缺少代码
        }
        /// <summary>
        /// 填充专业信息
        /// </summary>
        private void Init_Update()
        {
            //缺少代码 

            //缺少代码
        }
        /// <summary>
        /// 更新专业信息
        /// </summary>
        private void Update()
        {
            //缺少代码 

            //缺少代码
        }
        /// <summary>
        /// 添加专业信息
        /// </summary>
        private void Insert()
        {
            //缺少代码 

            //缺少代码
        }
    }
}
