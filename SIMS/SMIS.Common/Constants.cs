using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMS.Common
{    
    public class Constants
    {
        public const int UPDATE = 1;            //更新操作的值
        public const int INSERT = 2;            //添加操作的值
        public const int Department = 3;        //学院模块的值
        public const int Major = 4;             //专业模块的值
        public const int Class = 5;             //班级模块的值
        public const int Student = 6;           //学生模块的值
        public const int Admin = 7;             //管理模块的值


        public static int NowMoudel = Student;  //当前操作的模块
        public static string AdminID = null;    //当前登录的模块
    }
}

        //此段程序的说明
        // UPDATE = 1;            //更新操作的值
        // INSERT = 2;            //添加操作的值
        // Department = 3;        //学院模块的值
        // Major = 4;             //专业模块的值
        // Class = 5;             //班级模块的值
        // Student = 6;           //学生模块的值
        // Admin = 7;             //管理模块的值