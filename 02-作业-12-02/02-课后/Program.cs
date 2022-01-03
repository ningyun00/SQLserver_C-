using System;

namespace _02_课后
{
    class Program
    {
        static void Main(string[] args)
        {
            //goto lock1;
            //goto lock2;
            //goto lock3;
            //goto lock4;
            //goto lock5;
            //goto lock6;
            //goto lock7;
            //goto lock8;
            //goto lock9;
            //goto lock10;
            //goto lock11;
        //1、循环输出1到100之间的所有偶数。
        lock1: Console.WriteLine("第一题");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + "\t");
                }
            }
            Console.WriteLine();

        //2、循环输出10到100之间所有能被5整除的数。
        lock2: Console.WriteLine("第二题");
            for (int i = 10; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write(i + "\t");
                }
            }
            Console.WriteLine();

        //3、循环输出100到200之间所有能被2和3整除的数。
        lock3: Console.WriteLine("第三题");
            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    Console.Write(i + "\t");
                }
            }
            Console.WriteLine();

        //4、循环输出200到1000之间，既能被5整除，又能被8整除的数。
        lock4: Console.WriteLine("第四题");
            for (int i = 200; i <= 1000; i++)
            {
                if (i % 5 == 0 && i % 8 == 0)
                {
                    Console.Write(i + "\t");
                }
            }
            Console.WriteLine();

        //5、计算1 + 2 + 3 + 4 +……+100的结果。
        lock5: Console.WriteLine("第五题");
            double sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            Console.Write(sum);
            Console.WriteLine();

        //6、计算100 + 101 + 102 +……+200的结果。
        lock6: Console.WriteLine("第六题");
            sum = 0;
            for (int i = 100; i <= 200; i++)
            {
                sum += i;
            }
            Console.Write(sum);
            Console.WriteLine();

        //7、循环输入10个整数，将这10个数字累加，最后输出结果。
        lock7: Console.WriteLine("第七题");
            int A = 0;
            sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("输入第{0}个数：",i);
                A = int.Parse(Console.ReadLine());
                sum += i;
            }
            Console.Write(sum);
            Console.WriteLine();
        //8、循环输入5名同学的成绩，将5名同学的成绩累加，输出总分及平均分
        lock8: Console.WriteLine("第八题");
            double avg = 0;
            sum = 0;
            A = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("请输入第{0}位同学的成绩：",i);
                A = int.Parse(Console.ReadLine());
                sum += A;
            }
            Console.WriteLine("总分为："+sum);
            Console.WriteLine("平均分为："+(sum/5));
            Console.WriteLine();

        //9、使用for循环，接收五个学生的姓名，并输出。格式如下：
        lock9: Console.WriteLine("第九题");
            
            string B = null;
            for (int i = 0; i <= 5; i++)
            {
                Console.Write("请输入第{0}位同学的姓名：", i);
                B = Console.ReadLine();
                if (B.Length == 3)
                {
                    B = B.Replace(B, "***");
                    Console.WriteLine("第" + (i + 1) + "个学生的姓名是：" + B);
                }
                else if (B.Length == 2)
                {
                    B = B.Replace(B,"**");
                    Console.WriteLine("第"+ (i + 1)+"个学生的姓名是："+B);
                }
                else
                {
                    B = B.Replace(B, "**...");
                    Console.WriteLine("第" + (i + 1) + "个学生的姓名是：" + B);
                }
            }
            Console.WriteLine();
            //	请输入第1个学生的姓名：
            //	第1个学生的姓名是：**
            //    请输入第2个学生的姓名：
            //	第2个学生的姓名是：**
            //	…………
            //10、使用for循环与break语句实现：从1一直加到100,但如果累加的和大于500也要结束循环，并输出此时已经加到的数是什么？
        lock10: Console.WriteLine("第十题");
            sum = 0;
            for (int i = 1; i < 100; i++)
            {
                sum += i;
                if (sum > 500)
                {
                    Console.WriteLine(i);
                    break;                    
                }
            }            
            Console.WriteLine();

            //11、循环接收5名学生的成绩,统计有多少人的成绩大于80分,要求使用continue语句完成
        lock11: Console.WriteLine("第11题");
            sum = 0;
            A = 0;            
            for (int i = 1; i <= 5 ; i++)
            {
                Console.Write("请输入第{0}位同学的成绩：",i);
                A = int.Parse(Console.ReadLine());
                if (A > 80)
                {
                    sum++;
                    continue;
                }
            }
            Console.WriteLine("共有{0}位同学的成绩高于80分",sum);
        }
    }
}
