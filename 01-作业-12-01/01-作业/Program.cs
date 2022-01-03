using System;

namespace _01_作业
{
    class Program
    {
        static void Main(string[] args)
        {

            /*一、输入输出：题目1：输入3个数，输出其中的最大数*/
            Console.WriteLine("输入第一个数");
            int A = int.Parse(Console.ReadLine());//接收第一个数                  
            Console.WriteLine("输入第二个数");
            int B = int.Parse(Console.ReadLine());//接收第二个数                  
            Console.WriteLine("输入第三个数");
            int C = int.Parse(Console.ReadLine());//接收第三个数                  
            if (A > B && A > C) //当A大于B并且A大于C--则A最大                  
            {
                Console.WriteLine(A);
            }
            else if (B > A && B > C) //当B大于A并且B大于C--则B最大                 
            {
                Console.WriteLine(B);
            }
            else //否则                  
            {
                Console.WriteLine(C);
            }

            /*题目2：在控制台提示输入姓名、年龄、身高、性别并分别存放至四个变量内,最后组成一句完整的话打印在控制台内:大名xxx,姓名xxx,年龄xxx,身高xxx,性别xxx。*/

            Console.Write("请输入姓名:");//提示                
            string name = Console.ReadLine();//接收数据字符串                  
            Console.Write("请输入年龄:");
            int age = int.Parse(Console.ReadLine());//整型                  
            Console.Write("请输入身高:");
            float heath = float.Parse(Console.ReadLine());//浮点数                  
            Console.Write("请输入性别:");
            char sex = char.Parse(Console.ReadLine()); //单字符                 
            Console.WriteLine("我是 {0} 今年 {1} 岁,身高 {2} 性别 {3}", name, age, heath, sex);//汇总运用占位符                    

            /*题目3：提示输入二个整数,请将两个整数进行交换位置，再分别将两个整数打印在控制台内:*/
            Console.Write("请输入第一个整数：");
            int D = int.Parse(Console.ReadLine());//接收                  
            Console.Write("请输入第二个整数：");
            int E = int.Parse(Console.ReadLine());//接收                  
                                                  //交换前的n1和n2的值分别为: xxx和xxx
            Console.WriteLine("改之前：n1 = {0},n2 = {1}", D, E);
            //交换后的n1和n2的值分别为:xxx和xxx
            int F = 0; F = E; E = D;
            Console.WriteLine("改之后：n1 = {0},n2 = {1}", F, D);

            /*二、if练习,题目4：*/
            /*在控制台上输出以下一行文本:
                    甲和乙比大小游戏开始!!!
            随机产生两个10 - 30之间的数字，作为甲和乙的大小，并输出以下两行文本:
                    甲的大小为: 19(随机产生的数字)
                    乙的大小为: 18(随机产生的数字)
            然后根据两两大小，输出结果(甲赢 / 乙赢 / 不分上下)甲赢*/

            Random RD = new Random();//随机数对象                    
            Console.WriteLine("甲和乙比大小游戏开始!!!");
            int jia = RD.Next(10, 31);//随机数1                    
            int yi = RD.Next(10, 31);//随机数2                    
            if (jia > yi)//甲>乙,甲赢                    
            {
                Console.WriteLine("甲赢");
            }
            else if (yi > jia)//乙>甲,乙赢                    
            {
                Console.WriteLine("乙赢");
            }
            else
            {
                Console.WriteLine("不分上下");
            }
            Console.WriteLine(jia + "\n" + yi);//查看随机数            

            /*题目5：
             * 老豆对李明的考试成绩的反应,如果低于60，
             * 打印老豆很生气，后果很严重
             * 如果高于或等于60，低于80，打印则翻白眼
             * 如果高于或等于80，低于90，打印奖励宝马跑车一辆
             * 如果高于或等于90，低于100，打印奖励美女一个
             * 如果等于100，老豆很开心，打印想要啥给啥*/

            Console.Write("输入你的成绩：");
            int Result = int.Parse(Console.ReadLine());//储存成绩
            if (Result >= 60 && Result < 80)
            {
                Console.WriteLine("老豆翻了个白眼");
            }
            else if (Result >= 80 && Result < 90)
            {
                Console.WriteLine("老豆奖励一辆宝马");
            }
            else if (Result >= 90 && Result < 100)
            {
                Console.WriteLine("老豆奖励一个美女");
            }
            else if (Result == 100)
            {
                Console.WriteLine("想要啥要啥");
            }
            else
            {
                Console.WriteLine("你咋不去*,考这么点分");
            }

            /*三、switch练习
            题目6：
            请输入一串字符: 采用switch完成
             要求:
            ”小人” – 输出小力气
            ”大人” – 输出大力气
            ”老人” – 输出少力气
            ”死人” – 输出没力气*/

            Console.WriteLine("请输入以下其中的字符串：\t'小人'\t'大人'\t'老人'\t'死人'");
            string pipoer = Console.ReadLine();//接收数据                    
            switch (pipoer)
            {
                case "小人":
                    Console.WriteLine("小力气");
                    break;
                case "大人":
                    Console.WriteLine("大力气");
                    break;
                case "老人":
                    Console.WriteLine("少力气");
                    break;
                case "死人":
                    Console.WriteLine("没力气");
                    break;
                default:
                    Console.WriteLine("输入错误");//其它                            
                    break;
            }
            /*题目7：提示输入: 要买彩票吗 ? (y / n)
             * 如果输入”n” – 打印: 没钱咯，回老家!
             * 如果输入”y”再在0 - 1中随机产生一个数,
             * 如果该数为0打印: 手气不好，明天再买!
             * 如果该数为1打印: 恭喜您中了个五百万，开始买房，开始买车，开始买老婆!*/

            int number = RD.Next(0, 2);
            Console.Write("买彩票吗?(Y/N)");
            string Y = Console.ReadLine();//录入
            if (Y == "Y" || Y == "y")//判断
            {
                if (number == 0)//随机
                {
                    Console.WriteLine("手气不好，明天再买!");
                }
                else
                {
                    Console.WriteLine("恭喜您中了个五百万，开始买房，开始买车，开始买老婆!");
                }
            }
            else if (Y == "N" || Y == "n")//判断
            {
                Console.WriteLine("没钱咯，回老家!");
            }
            else
            {
                Console.WriteLine("输入错误");
            }

            /*题目8：
            测试你下辈子是什么 
            1 : 一个伟大的人       2:一头好吃懒做的猪
            3:一颗敲不碎的石头   4:一颗长不高的松树
            1)提示输入您的大名:
                        2)随机产生一个(1 - 4)之间的数字
            3)打印: xxx原来下辈子是xxx*/

            Console.Write("输入你的姓名：");
            string sexName = Console.ReadLine();
            int number2 = RD.Next(1, 5);
            string nameBer = null;
            switch (number2)
            {
                case 1:
                    nameBer = "一个伟大的人";
                    break;

                case 2:
                    nameBer = "一头好吃懒做的猪";
                    break;

                case 3:
                    nameBer = "一颗敲不碎的石头";
                    break;

                case 4:
                    nameBer = "一颗长不高的松树";
                    break;
                default:
                    nameBer = "一个死人";
                    break;
            }
            Console.WriteLine("{0}原来下辈子是{1}", sexName, nameBer);

        }
    }
}
