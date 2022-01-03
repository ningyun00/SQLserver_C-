using System;

namespace _01_作业
{
    class Program
    {
        static void Main(string[] args)
        {
            //字符串函数:
            {
                //1.使用Equals，比较string str1 = "123"; string str2 = "321";如果相等，打印相等；否则，不相等
                Console.WriteLine("第一题");
                {
                    string str1 = "123", str2 = "321";//声明赋值
                    if (str1 == str2)//内容比较
                    {
                        Console.WriteLine("等于");
                    }
                    else
                    {
                        Console.WriteLine("不等于");
                    }
                    if (str1.Equals(str2))//地址比较
                    {
                        Console.WriteLine("等于");
                    }
                    else
                    {
                        Console.WriteLine("不等于");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                //2.string str = "192.168.1.2", 请用”.”符号Split方法将其分割成4块，并将4块都打印出来
                Console.WriteLine("第二题");
                {
                    string str = "192.168.1.2";
                    string[] A = str.Split(".");//依照"."经行截取 储存进数组中
                    foreach (var item in A)
                    {
                        Console.Write(item + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                //3.string str = "wry@163.com", 请用”@” 符号Split方法将其分割成2块，并打印出第一块
                Console.WriteLine("第三题");
                {
                    string str = "wry@163.com";
                    string[] str1 = str.Split("@");//依照"@"进行截取 
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(str[i]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                //4.string str = "wry@163.c@om", 请用IndexOf方法获取第一个@的索引,请用LastIndexOf获取最后一个 @的索引
                Console.WriteLine("第四题");
                {
                    string str = "wry@163.c@om";
                    int A = str.IndexOf('@');//@的下标
                    int B = str.LastIndexOf("@");//最后一个@的下标
                    Console.Write("第一个@：" + A + "\t第二个@：" + B);
                    Console.WriteLine();
                }
                Console.WriteLine();

                //5.string str =”james_peng1028 @hotmail.com” ,截取用户名(@前面的为用户名)，截取域名(小数点后面)
                Console.WriteLine("第五题");
                {
                    string str = " james_peng1028 @hotmail.com";//28
                    str = str.Substring(0, str.IndexOf("@"));//从零开始到@的下标,不包括@
                    Console.WriteLine("用户名：{0}", str);
                    str = " james_peng1028 @hotmail.com";//重新赋值
                    str = str.Substring(str.IndexOf(".") + 1, str.Length - (str.IndexOf(".") + 1));//从@后第一位下标开始,到总长度-@下标前的后一位结束.
                    Console.WriteLine("域名：{0}", str);
                }
                Console.WriteLine();

                //6.string str = "hello   "; 请打印字符串中字符的个数(串.Length)。
                Console.WriteLine("第六题");
                {
                    string str = "hello";
                    Console.WriteLine("字符串长度：", str.Length);
                }
                Console.WriteLine();

                //7.请将"我们","欢迎","你"3个字符串用"-"连接，最后输出结果为"我们" - "欢迎" - "你",请使用Join方法
                Console.WriteLine("第七题");
                {
                    string str1 = "我们";
                    string str2 = "欢迎";
                    string str3 = "你";
                    str1 = string.Join("-", str1, str2, str3);
                    Console.WriteLine(str1);
                }
                Console.WriteLine();

                //8.定义一个字符串数组,保存三个字符串 “我”,”爱”,”你”，将此字符串数组中的数据,用 @连接起来，得到一个新的字符串  “我 @爱@你”
                Console.WriteLine("第八题");
                {
                    /*string str1 = "我", str2 = "爱", str3 = "你"; str1 = string.Join("@", str1, str2, str3);Console.WriteLine(str1);*/
                    string[] str = { "我", "爱", "你" };
                    string A = string.Join("@", str);
                    Console.WriteLine(A);
                }
                Console.WriteLine();
            }

            //Format格式化方法:
            {
                //语法:
                //       string temp = string.Format(含占位符的字符串，变量值列表)
                //1.输出个人信息
                //提示用户输入姓名、年龄、身高并定义三个变量接受输入的值
                //采用Format方法将三个变量组成一串值:”我的大名: XX,年龄XX,身高XX”并赋给一个字符串变量msg
                // 打印变量msg值
                Console.WriteLine("第一题");
                {
                    Console.Write("请输入你的姓名：");
                    string name = Console.ReadLine();
                    Console.Write("请输入你的年龄：");
                    int age = int.Parse(Console.ReadLine());
                    Console.Write("请输入你的身高：");
                    double heigth = double.Parse(Console.ReadLine());
                    string str = string.Format("我的大名：{0}，年龄{1}，身高{2}", name, age, heigth);
                    Console.WriteLine(str);
                }
                Console.WriteLine();

                //2.还钱
                //提示XXX请还我XXX钱,并定义二个变量接受控制台输入的值
                //使用string.Format对含有占位符的字符串进行格式化并赋给变量money
                //打印变量moeny值
                Console.WriteLine("第二题");
                {
                    Console.WriteLine("XXX请还我XXX钱");
                    Console.Write("请输入欠钱人：");
                    string name = Console.ReadLine();
                    Console.WriteLine("请输入欠了多少钱：");
                    string money = Console.ReadLine();
                    name = string.Format("{0}请还我{1}钱", name, money);
                    money = string.Format("{0}请还我{1}钱", name, money);
                    Console.WriteLine(money);
                }
            }
            Console.WriteLine();

            //字符串补充
            {
                //1.有一个文件地址(D: -73class-MyKTV-projecc-项目所需图片-image-qq.jpg)保存在字符串变量中。
                Console.WriteLine("第一题");
                {
                    string str = "D: -73class-MyKTV-projecc-项目所需图片-image-qq.jpg";
                    //要求：
                    //获取图片的扩展名(jpg)
                    string A = str.Substring(str.IndexOf(".") + 1, 3);
                    char[] B = A.ToCharArray();
                    Console.WriteLine(B);
                    //获取图片的名字(qq)
                    A = str.Substring(str.LastIndexOf("-") + 1, 2);
                    B = A.ToCharArray();
                    Console.WriteLine(B);
                }
                Console.WriteLine();

                //2.有一串ID   12,34,56,79,100,
                Console.WriteLine("第二题");
                {
                    string str = "12,34,56,79,100,";
                    //将所有的数相加，求和
                    string[] A = str.Split(",");
                    int sum = 0;
                    for (int i = 0; i < A.Length - 1; i++)
                    {
                        sum += int.Parse(A[i]);
                        Console.WriteLine(sum);
                    }
                    Console.WriteLine();
                    //输出偶数
                    for (int i = 0; i < A.Length - 1; i++)
                    {
                        if (int.Parse(A[i]) % 2 == 0)
                        {
                            Console.WriteLine(int.Parse(A[i]));
                        }
                    }
                }
                //3.有一个时间 通过datetime获取系统当前时间
                Console.WriteLine("第三题");
                {
                    DateTime dateTime = DateTime.Now;
                    //分别求出年，月，日，时，分，秒
                    DateTime dt = DateTime.Now;
                    Console.WriteLine(dt);
                    //获取年：dt.Year
                    Console.WriteLine(dt.Year);
                    //获取月：dt.Month
                    Console.WriteLine(dt.Month);
                    //获取日：dt.Day
                    Console.WriteLine(dt.Day);
                    //获取小时：dt.Hour
                    Console.WriteLine(dt.Hour);
                    //获取分钟：dt.Minute
                    Console.WriteLine(dt.Minute);
                    //获取秒：dt.Second
                    Console.WriteLine(dt.Second);
                    Console.WriteLine("{0}年{1}月{2}日{3}时{4}分{5}秒", dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second);
                    //要求将此时间显示为2011年9月16日10时30分31秒
                    string str = dt.ToString("yyyy年MM月dd日");//2021年12月06日
                    Console.WriteLine(str);
                }
            }
        }
    }
}
