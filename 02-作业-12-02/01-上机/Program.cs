using System;

namespace _01_上机
{
    class Program
    {
        static void Main(string[] args)
        { 
            //goto look1;
            //goto look2;
            //goto look3;
            //goto look4;
            //goto look5;
            //goto look6;
            //goto look7;
            //goto look8;
            //goto look9;
            //goto look10;
            //goto look11;
            //goto look12;

            //1.输出100以内的数字（条件: 不能同时被3、5、10整除(比如: 30)）
        look1: Console.WriteLine("第一题");
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 != 0 && i % 5 != 0 && i % 10 != 0)
                {
                    Console.Write(i + "\t");
                }
            }
            Console.WriteLine("\n\n\n\n");

            //2.输出100以内的数字（要求：从大到小输出，比如 100 99 98 97……）
        look2: Console.WriteLine("第二题");
            for (int i = 99; i >= 0; i--)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();

            //3.输出100以内的偶数和和奇数和
        look3: Console.WriteLine("第三题");
            int sum = 0;
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 0) //偶数
                {
                    Console.Write(i + "\t");
                }
            }
            Console.WriteLine();
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 != 0) //奇数
                {
                    Console.Write(i + "\t");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < 100; i++)
            {
                sum += i;//求和
            }
            Console.WriteLine(sum);
            Console.WriteLine();

            //4.输出10000到20000的奇数,偶数和,以及全部和
        look4: Console.WriteLine("第四题");
            sum = 0;//总和
            for (int i = 10000; i <= 20000; i++)
            {
                if (i % 2 != 0) //奇数
                {
                    Console.Write(i + "\t");
                }
            }
            Console.WriteLine();
            for (int i = 10000; i <= 20000; i++)
            {
                if (i % 2 == 0) //奇数
                {
                    Console.Write(i + "\t");
                }
            }
            Console.WriteLine();
            for (int i = 10000; i <= 20000; i++)
            {
                sum += i; //求和                   
            }
            Console.WriteLine("10000~20000的总和是" + sum);
            Console.WriteLine();

            //5.输出21世纪（2000年 - 2099年）的闰年（提示：闰年判断条件（year % 4 == 0 && year % 100 != 0）|| year % 400 == 0）
        look5: Console.WriteLine("第五题");
            for (int i = 2000; i <= 2099; i++)
            {
                if (i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
                {
                    Console.Write("2000-2099年的闰年有：" + i + "\t");
                }
            }
            Console.WriteLine();

            //6.定义一个字符串数组，如 string[] a = new string[] {“123”,”333”,”abc”}
        look6: Console.WriteLine("第六题");
            string[] A1 = new string[] { "123", "333", "abc" };
            for (int i = 0; i < A1.Length; i++)
            {
                Console.Write(A1[i] + "\t");
            }
            Console.WriteLine();

            //7.定义一个double数组，如double[] b = { 1.1, 2.2, 3.3, 11.2 }, 然后从后往前输出
         look7: Console.WriteLine("第七题");
            double[] A2 = { 1.1, 2.2, 3.3, 11.2 };
            for (int i = A2.Length - 1; i >= 0; i--)
            {
                Console.Write(A2[i] + "\t");
            }
            Console.WriteLine();

            //8.循环输入5个学生的考试成绩，保存到一个数组中，然后分别求出分数总和和平均分
        look8: Console.WriteLine("第八题");
            double[] A3 = new double[4];
            double Sum = 0;
            double avg = 0;
            for (int i = 0; i < A3.Length; i++)//输入
            {
                Console.Write("请输入第{0}个同学的成绩：", i + 1);
                A3[i] = double.Parse(Console.ReadLine());
                Sum += A3[i];//总分
            }
            Console.WriteLine("总分为：" + Sum);
            avg = Sum / A3.Length;
            Console.WriteLine("平均分为：" + avg);
            Console.WriteLine();

            //9.定义一个数组int[] a ={ 10,30,0,9,2,5,100,33,22} ，求出数组中的最大值和最小值
        look9: Console.WriteLine("第九题");
            int[] A4 = { 10, 30, 0, 9, 2, 5, 100, 33, 22 };
            int max = A4[0], min = A4[0];
            for (int i = 0; i < A4.Length; i++)
            {
                if (A4[i] > max)
                {
                    max = A4[i];
                }
                if (A4[i] < min)
                {
                    min = A4[i];
                }
            }
            Console.WriteLine("最大值：" + max);
            Console.WriteLine("最小值：" + min);
            Console.WriteLine();

            //10.输入5个成绩，保存到一个数组中，然后排序，再使用foreach打印出来
        look10: Console.WriteLine("第十题");
            int[] A5 = new int [5];
            for (int i = 0; i < A5.Length; i++)
            {
                Console.Write("请输入第{0}个成绩:",i+1);
                A5[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(A5);
            foreach (var item in A5)
            {
                Console.Write(item+"\t");
            }
            Console.WriteLine();

            //11.定义一个int数组，长度为5，循环从控制台输入每个元素的值(for) 将输入的值放入至数组内，计算数组所有元素的累加和(foreach)
        look11: Console.WriteLine("第十一题");
            int[] A6 = new int[5];
            sum = 0;
            for (int i = 0; i <A6.Length; i++)
            {
                Console.Write("请输入第{0}个数:", i + 1);
                A6[i] = int.Parse(Console.ReadLine());
                sum += A6[i];
            }
            Console.WriteLine(sum);
            Console.WriteLine();

            //12.提示请输入您的大名,再将大名的每个字符以竖着的方向打印出来,比如: jiedamu.结果如下:j,i,e,d,a,m,u
        look12: Console.WriteLine("第十二题");
            Console.Write("请输入你的大名：");
            string A7 = Console.ReadLine();
            char[] A8 = A7.ToCharArray();
            foreach (var item in A8)
            {
                Console.WriteLine(item);
            }
        }
    }
}
