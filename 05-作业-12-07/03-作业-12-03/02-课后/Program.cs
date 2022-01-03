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
        /*把课堂案例练习一遍：        1.编写狗类和书类        狗具有姓名、尾巴、品种、毛色四个字段        书具有书名、作者、总页数三个字段        创建对象，最终输出：        旺财是一只有着短短的尾巴的黑白相间的哈士奇        大黄是一只有着卷卷的尾巴的黄颜色的柴犬        《葵花宝典》的作者是东方不败，共有392页。        《C#入门》的作者是游哥，共有634页。*/
        lock1: Console.WriteLine("第一题");
            {
                dog dog = new dog();
                dog.name = "旺财";
                dog.wb = "短短";
                dog.pz = "哈士奇";
                dog.ms = "黑白相间";
                dog.main();
                dog.name = "大黄";
                dog.wb = "卷卷";
                dog.pz = "柴犬";
                dog.ms = "黄颜色";
                dog.main();
                book book = new book();
                book.name = "葵花宝典";
                book.zuozhe = "东方不败";
                book.yeshu = 392;
                book.mian();
                book.name = "C#入门";
                book.zuozhe = "游哥";
                book.yeshu = 634;
                book.mian();
                Console.WriteLine();
            }

        //2.编写植物类，具有名称、植物科系、生长地区三个字段
        //  创建对象，最终输出：
        //  *在中国华南地区，有一种根茎类植物，叫红人参
        // * 在天山之颠，有一种花卉类植物，叫天山雪莲
        // * 在中国北方，有一种神奇类植物，叫菊花
        // 练习
        //   创建一个植物类，名称：狗尾巴草，植物科系：草本类，生长地区：亚热带
        //  请先输出以下信息：

        //      *有一种草本类植物，叫狗尾巴草，你知道它主要生长在哪里吗？
        //  如果回答正确则输出：
        //  	*你真牛，这你都知道。
        //  如果回答错误则输出：
        //  	*你真水，就知道你答不出来。
        lock2: Console.WriteLine("第二题");
            {
                zhiwulei zhiwulei = new zhiwulei();
                zhiwulei.name = "红人参";
                zhiwulei.kexi = "根茎";
                zhiwulei.diqu = "中国华南地区";
                zhiwulei.main();
                zhiwulei.name = "天山雪莲";
                zhiwulei.kexi = "花卉";
                zhiwulei.diqu = "北方之巅";
                zhiwulei.main();
                zhiwulei.name = "菊花";
                zhiwulei.kexi = "神奇";
                zhiwulei.diqu = "中国北方";
                zhiwulei.main();
                //练习
                zhiwulei1 zhiwulei1 = new zhiwulei1();
                zhiwulei1.name = "狗尾巴草";
                zhiwulei1.kexi = "草本类";
                zhiwulei1.diqu = "亚热带";
                zhiwulei1.main();
                Console.WriteLine();
            }

        //3.编写工人类，有以下字段
        //   * 姓名  字符串类型
        //   * 存款  整数类型
        //   有以下方法
        //   * 工作的方法
        //     {
        //             工人每次工作，都可以得到100 - 300元不等的工资（随机产生）
        //   在控制台输出：张三参加了工作，得到137元工资。（张三和137应为占位符）
        //   将工资累加到存款中。
        //     }
        //            请在Main方法中创建一个叫王大炮的工人。
        //   让他工作3次，最后输出看看他有多少存款。
        //   最终输出：王大炮现在有479元存款（王大炮和479应为占位符）
        lock3: Console.WriteLine("第三题");
            {
                rengolei rengolei = new rengolei();
                rengolei.main();
                Console.WriteLine();
            }

        //4.编写熊猫类，有以下字段
        //   * 姓名
        //   *最长寿命  int
        //  * 年龄
        //   有以下方法
        //   * 出生
        //     {
        //                熊猫出生时就确定了它的最长寿命3 - 9年（随机产生）
        //	 输出：撸撸出生了，它好可爱啊。（撸撸应为占位符）
        //     }
        //            *过生日
        //     {
        //                熊猫的年龄加一，并输出：
        //	 撸撸1岁了，快来给它过生日吧。（撸撸和1应为占位符）
        //	 但如果熊猫的年龄超出了最长寿命，则输出：
        //	 撸撸太老了，它死了，享年7岁。（撸撸和7应为占位符）
        //     }
        lock4: Console.WriteLine("第四题");
            {
                pander pander = new pander();
                pander.chusheng();
                pander.daty();
                Console.WriteLine();
            }

        //5.编写小朋友类，具有以下字段：
        //   *姓名
        //   * 苹果蓝里的苹果个数 int
        //   具有以下方法：
        //   *摘苹果
        //     {
        //                小朋友每次可以摘0~4个苹果不等（随机产生）
        //	 如果没摘到苹果，
        //		则应输出：华华一个苹果也没摘到。
        //	否则
        //        输出：华华摘了3(3是随机的数字)个苹果（华华和3应为占位符）
        //     }
        //            在Main方法创建对象数组，创建3个小朋友：
        //   *华华 * 小明 * 妮妮
        //   循环让他们去摘苹果。
        //   等他们都摘完苹果之后，再用foreach循环统计总共有多少个苹果
        //   最后输出：今天总共摘了8个苹果。（8应为占位符）
        lock5: Console.WriteLine("第五题");
            {
                xiaopy xiaopy = new xiaopy();
                xiaopy.main();
                Console.WriteLine();
            }
        }
    }
}
