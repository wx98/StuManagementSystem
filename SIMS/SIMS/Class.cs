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
        /// 通过专业名称获取专业ID
        /// </summary>
        /// <param name="MajorName">专业名称</param>
        /// <returns>转而编号</returns>
        private int getMajorID(String MajorName)
        {
            int MajorID = -1;
            //缺少代码

            //缺少代码
            return MajorID;
        }
        /// <summary>
        /// 通过专业编号获得专业名称
        /// </summary>
        /// <param name="MagorID">专业编号</param>
        /// <returns>专业名称</returns>
        private String getMajorName(int MagorID)
        {
            String MajorID = null;
            //缺少代码

            //缺少代码
            return MajorID;
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
            //缺少代码
            DataTable dt = new DataTable();
            //缺少代码
            return dt;
        }
        /// <summary>
        /// 删除班级信息
        /// </summary>
        /// <param name="ID">班级编号</param>
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
        /// 填充班级信息
        /// </summary>
        private void Init_Update()
        {
            //缺少代码

            //缺少代码
        }
        /// <summary>
        /// 添加班级信息
        /// </summary>
        private void Insert()
        {
            //缺少代码

            //缺少代码
        }
        /// <summary>
        /// 更新班级信息
        /// </summary>
        private void Update()
        {
            //缺少代码

            //缺少代码
        }
    }
}
