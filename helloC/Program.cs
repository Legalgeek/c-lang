using System;
using System.Diagnostics;
using System.Text;

namespace helloC
{
    class Program
    {
        static void Main(string[] args)
        {

            
            // 统计程序运行时间
            //Stopwatch timeCump = new Stopwatch();  //首先需要引入System.Diagnostics模块
            //timeCump.Start(); //开始计时

            //// 这里放待运行的代码

            //timeCump.Stop();  // 结束计时

            //Console.WriteLine(timeCump.ElapsedMilliseconds); // 打印统计时长
            //-----------



            //测试运行效率方式一：字符串方式
            //string str01 = string.Empty;
            //for (int i = 0; i < 100000; i++)
            //{
            //    str01 += i.ToString();
            //}
            //-----------

            //测试字符串运行效率方式二：StringBuilder 
            //StringBuilder sb = new StringBuilder();  //需要先引入 System.Text;
            //for (int num = 0; num < 100000; num++)
            //    sb.Append(num.ToString());
            //-----------

            //两种字符串空值方式
            //string str02 = null;
            //string str03 = string.Empty;
            //-----------


            //捕获键盘输入内容，并使用int.Parse方法转换成数字
            //var input01 = Console.ReadLine();
            //var input02 = Console.ReadLine();

            //Console.WriteLine(input01 + input02);  //不转换，错误输出
            //Console.WriteLine(int.Parse(input01) + int.Parse(input02));  //转换后正确输出
            //-----------


            //使用 TryParse方法转换成数字，并提示报错
            //var input03 = Console.ReadLine();
            //int a03;

            //if (int.TryParse(input03, out a03))
            //{
            //    Console.WriteLine(a03);
            //}
            //else
            //{
            //    Console.WriteLine("解析失败，非数字！");
            //}

            //-----------






            // double num = 1.1111122222333334444455555; 
            // Console.WriteLine(num);  //观察到部分数据丢失
            // Console.WriteLine("1111111111111111111111111111");

            // string str = "hello\n";
            // str = str.ToUpper();  //字符的不可变性，需要赋值后替换

            // Console.WriteLine(str);
            Console.Read();








        }
    }
}
