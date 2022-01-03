using System;
using System.Collections.Generic;
using System.Text;

namespace _01_上机
{
    /// <summary>
    /// 1.猫类
    /// </summary>
    class Cat
    {
        /// <summary>
        /// 猫的姓名
        /// </summary>
        public string name;
        /// <summary>
        /// 猫的尾巴
        /// </summary>
        public string wd;
        /// <summary>
        /// 猫的品种
        /// </summary>
        public string pz;
        /// <summary>
        /// 猫的毛色
        /// </summary>
        public string ms;
        /// <summary>
        /// 输出
        /// </summary>
        public void CatClass()
        {
            Console.WriteLine("{0}是一只有着{1}的尾巴的{2}的{3}猫", name, wd, ms, pz);
        }
    }
    /// <summary>
    /// 1.汽车类
    /// </summary>
    class cat
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        public string carId;
        /// <summary>
        /// 品牌
        /// </summary>
        public string pp;
        /// <summary>
        /// 价值
        /// </summary>
        public int maney;
        /// <summary>
        /// 输出
        /// </summary>
        public void catClass()
        {
            Console.WriteLine("那是一辆{0}的{1}价值{2}万元", carId, pp, maney);
        }
    }
    /// <summary>
    /// 2.医生类
    /// </summary>
    class YiSheng
    {
        /// <summary>
        /// 医生名称
        /// </summary>
        public string name;
        /// <summary>
        /// 医生科系
        /// </summary>
        public string kl;
        /// <summary>
        /// 所属医院
        /// </summary>
        public string suoshu;
        /// <summary>
        /// 医生类
        /// </summary>
        public void Doucert()
        {
            Console.WriteLine("在{0}医院，有一个{1}医生，名叫{2}", suoshu, kl, name);
        }
    }
    /// <summary>
    /// 2.医生类
    /// </summary>
    class YiSheng2
    {
        /// <summary>
        /// 医生名称
        /// </summary>
        public string name;
        /// <summary>
        /// 医生科系
        /// </summary>
        public string kl;
        /// <summary>
        /// 所属医院
        /// </summary>
        public string suoshu;
        /// <summary>
        /// 医生类
        /// </summary>
        public void Doucert()
        {
            Console.WriteLine("有一个{0}医生，叫{1}，你知道它是哪一个哪一个医院的吗？", kl, name);
            //方法二
            //if (A == "曹操" || A == "知道")
            //{
            //    Console.WriteLine("你真牛，这你都知道。");
            //}
            //else
            //{
            //    Console.WriteLine("你真水，就知道你答不出来。");
            //}
        }
    }
    /// <summary>
    /// 3.游戏类
    /// </summary>
    class games
    {
        /// <summary>
        /// 游戏公司
        /// </summary>
        public string gamesname;
        /// <summary>
        /// 游戏名称
        /// </summary>
        public string name;
        /// <summary>
        /// 在线人数
        /// </summary>
        public int zxrs;
        /// <summary>
        /// 输出
        /// </summary>
        public void form()
        {
            Console.WriteLine("{0}游戏公司的新网游《{1}》上线,每天都有{2}位战友在等你上线。", gamesname, name, zxrs);
        }

    }
    /// <summary>
    /// 4.电子钟类
    /// </summary>
    class colock
    {
        /// <summary>
        /// 时区
        /// </summary>
        public string shiqu;
        /// <summary>
        /// 小时
        /// </summary>
        public int time;
        /// <summary>
        /// 分钟
        /// </summary>
        public int min;
        /// <summary>
        /// 方法
        /// </summary>
        public void Main()
        {
            Console.WriteLine("时区：{0},小时：{1}点,分钟：{2}分", shiqu, time, min);
        }
    }
    /// <summary>
    /// 5.商品类
    /// </summary>
    class shangpinlei
    {
        /// <summary>
        /// 商品名称
        /// </summary>
        public string pingming;
        /// <summary>
        /// 商品价格
        /// </summary>
        public int jiage;
        /// <summary>
        /// 商品用途
        /// </summary>
        public string yongtu;
    }
    /// <summary>
    /// 6.计算机类
    /// </summary>
    class conpuerte
    {
        /// <summary>
        /// 电脑编号
        /// </summary>
        public int bianhao;
        /// <summary>
        /// CPU主频
        /// </summary>
        public string cpufps;
        /// <summary>
        /// 内存容量
        /// </summary>
        public int nc;
        /// <summary>
        /// 硬盘容量
        /// </summary>
        public string yingpan;
        public void A()
        {
            conpuerte[] conpuerte = new conpuerte[10];
            Random random = new Random();
            for (int i = 0; i < conpuerte.Length; i++)
            {
                conpuerte[i] = new conpuerte();
                conpuerte[i].bianhao = 26 + i;
                conpuerte[i].cpufps = "2.6G";
                conpuerte[i].nc = random.Next(1, 5);
                if (conpuerte[i].nc == 1)
                {
                    conpuerte[i].yingpan = "100G";
                }
                else if (conpuerte[i].nc == 2)
                {
                    conpuerte[i].yingpan = "200G";
                }
                else if (conpuerte[i].nc == 3)
                {
                    conpuerte[i].yingpan = "300G";
                }
                else if (conpuerte[i].nc == 4)
                {
                    conpuerte[i].yingpan = "400G";
                }
            }
            for (int i = 0; i < conpuerte.Length; i++)//for输出
            {
                Console.WriteLine("电脑编号：" + conpuerte[i].bianhao + "G。CPU主频：" + conpuerte[i].cpufps + "。电脑内存容量：" + conpuerte[i].nc + "G。电脑硬盘容量：" + conpuerte[i].yingpan);
            }
        }
    }
    /// <summary>
    /// 7.学生类
    /// </summary>
    class student
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string name;
        /// <summary>
        /// 零花钱
        /// </summary>
        public int money;
        /// <summary>
        /// 方法：吃宵夜
        /// </summary>
        public void main()
        {
            Random random = new Random();
            money = random.Next(10, 51);
            Console.Write("请输入姓名：");
            name = Console.ReadLine();
            Console.WriteLine("{0}要去夜宵了，花了{1}元。", name, money);
            name = "王大宝";
            money = 200;
            for (int i = 1; i <= 3; i++)
            {
                money = money - random.Next(10, 51);
            }
            Console.WriteLine("{0}还有{1}元零花钱",name,money);
        }
    }
}

