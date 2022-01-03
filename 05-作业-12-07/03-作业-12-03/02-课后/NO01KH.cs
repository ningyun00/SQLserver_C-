using System;
using System.Collections.Generic;
using System.Text;

namespace _02_课后
{
    /// <summary>
    /// 1.狗类
    /// </summary>
    class dog
    {
        /// <summary>
        /// 狗的名字
        /// </summary>
        public string name;
        /// <summary>
        /// 狗的尾巴
        /// </summary>
        public string wb;
        /// <summary>
        /// 狗的的怕品种
        /// </summary>
        public string pz;
        /// <summary>
        /// 狗的毛色
        /// </summary>
        public string ms;

        public void main()
        {
            Console.WriteLine("{0}是一只有着{1}的尾巴的{2}的{3}", name, wb, ms, pz);
        }
    }
    /// <summary>
    /// 1.书类
    /// </summary>
    class book
    {
        /// <summary>
        /// 书名
        /// </summary>
        public string name;
        /// <summary>
        /// 书的作者
        /// </summary>
        public string zuozhe;
        /// <summary>
        /// 书的页数
        /// </summary>
        public int yeshu;
        /// <summary>
        /// 书的方法
        /// </summary>
        public void mian()
        {
            Console.WriteLine("《{0}》的作者是{1}，共有{2}页。", name, zuozhe, yeshu);
        }
    }
    /// <summary>
    /// 2.植物类
    /// </summary>
    class zhiwulei
    {
        /// <summary>
        /// 名称 
        /// </summary>
        public string name;
        /// <summary>
        /// 科系
        /// </summary>
        public string kexi;
        /// <summary>
        /// 生长地区
        /// </summary>
        public string diqu;
        /// <summary>
        /// 方法
        /// </summary>         
        public void main()
        {
            Console.WriteLine("在{0}，有一种{1}类植物，叫{2}", diqu, kexi, name);
        }
    }
    /// <summary>
    /// 2.植物类
    /// </summary>
    class zhiwulei1
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string name;
        /// <summary>
        /// 科系
        /// </summary>
        public string kexi;
        /// <summary>
        /// 生长地区
        /// </summary>
        public string diqu;
        /// <summary>
        /// 方法
        /// </summary>        
        public void main()
        {
            Console.WriteLine("有一种{0}植物，叫{1}，你知道它主要生长在哪里吗？", kexi, name);
            string A = Console.ReadLine();
            if (A == diqu)
            {
                Console.WriteLine("你真牛，这你都知道");
            }
            else
            {
                Console.WriteLine("你真水，就知道你答不出来");
            }
        }

    }
    /// <summary>
    /// 3.人工类
    /// </summary>
    class rengolei
    {
        public string name;
        public int cunkuan;
        public void main()
        {
            Random random = new Random();
            Console.Write("请输入你的姓名：");
            name = Console.ReadLine();
            Console.Write("请输入你的存款：");
            cunkuan = int.Parse(Console.ReadLine());
            int A = random.Next(100, 301);
            Console.WriteLine("{0}参加了工作，得到{1}元工资。", name, A);
            cunkuan += A;
            name = "王大炮";
            Console.Write("请输入王大炮的存款：");
            int cunkuan_wangdapao = int.Parse(Console.ReadLine());
            for (int i = 0; i < 3; i++)
            {
                cunkuan_wangdapao += random.Next(100, 301);
            }
            Console.WriteLine("{0}现在有{1}元存款", name, cunkuan_wangdapao);
        }
    }
    /// <summary>
    /// 4.熊猫类
    /// </summary>
    class pander
    {
        /// <summary>
        /// 熊猫姓名
        /// </summary>
        public string name;
        /// <summary>
        /// 熊猫最大寿命
        /// </summary>
        public int maxage;
        /// <summary>
        /// 熊猫当前寿命
        /// </summary>
        public int age;
        /// <summary>
        /// 出生
        /// </summary>
        public void chusheng()
        {
            Console.Write("输入熊猫的姓名：");
            name = Console.ReadLine();
            Console.Write("输入熊猫的年龄：");
            age = int.Parse(Console.ReadLine());
            Random random = new Random();
            maxage = random.Next(3, 10);
            Console.WriteLine("{0}出生了，它好可爱啊。", name);
        }
        /// <summary>
        /// 生日
        /// </summary>
        public void daty()
        {
            age = age + 1;

            if (age <= maxage)
            {
                Console.WriteLine("{0}{1}岁了，快来给它过生日吧。", name, age);
            }
            else
            {
                Console.WriteLine("{0}太老了，它死了，享年{1}岁。", name, age);
            }
        }
    }
    /// <summary>
    /// 5.小朋友类
    /// </summary>
    class xiaopy
    {
        /// <summary>
        /// 小朋友姓名
        /// </summary>
        public string name;
        /// <summary>
        /// 苹果蓝中的苹果
        /// </summary>
        public int pgl;
        /// <summary>
        /// 在苹果的方法
        /// </summary>
        public void main()
        {
            Console.Write("请输入姓名：");
            name = Console.ReadLine();
            Random random = new Random();
            int zhaipingguo = random.Next(0, 5);
            Console.Write("输入苹果蓝内的苹果：");
            pgl = int.Parse(Console.ReadLine());
            int sum = 0;
            sum += pgl;
            if (zhaipingguo == 0)
            {
                Console.WriteLine("{0}一个苹果也没摘到。", name);
            }
            else
            {
                Console.WriteLine("{0}摘了{1}个苹果", name, zhaipingguo);
            }
            xiaopy[] xp = new xiaopy[3];
            for (int i = 0; i < xp.Length; i++)
            {
                xp[i] = new xiaopy();
                Console.Write("请输入第{0}个人的姓名：", i + 1);
                xp[i].name = Console.ReadLine();
                xp[i].pgl = random.Next(0, 5);
            }
            foreach (var item in xp)
            {
                sum += item.pgl;
                //Console.WriteLine(item.pgl);//摘了多少苹果
            }
            Console.WriteLine("今天总共摘了{0}个苹果。", sum);
        }
    }
}
