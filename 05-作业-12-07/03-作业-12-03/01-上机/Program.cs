using System;

namespace _01_上机
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
            goto lock7;
        /*1.编写猫类和汽车类
         *猫具有姓名、尾巴、品种、毛色四个字段，修饰符是public
         *汽车具有车牌号、品牌、价值三个字段，修饰符是public
         *创建对象，最终输出：
         *爱丽斯是一只有着长长的尾巴的白色的波丝猫
         *碧池是一只有着细细的尾巴的黑色的贵妃猫
         *那辆湘A99999的法拉利价值3000万元。
         *那辆京A88888的劳斯莱斯价值9600万元。*/
        lock1: Console.WriteLine("第一题");
            Cat Cat = new Cat();//实例化对象 调用Cat猫类
            Cat.name = "爱丽丝";
            Cat.wd = "长长";
            Cat.pz = "波斯";
            Cat.ms = "白";
            Cat.CatClass();//输出
            Cat.name = "碧池";
            Cat.wd = "细细";
            Cat.pz = "贵妃";
            Cat.ms = "黑";
            Cat.CatClass();//输出

            cat cat = new cat();//实例化对象 调用cat车类
            cat.carId = "湘A99999";
            cat.pp = "法拉利";
            cat.maney = 3000;
            cat.catClass();//输出
            cat.carId = "京A88888";
            cat.pp = "劳斯莱斯";
            cat.maney = 9600;
            cat.catClass();//输出
            Console.WriteLine();//换行

        /*2.编写医生类，具有名称、科系、所属医院三个字段，修饰符是public
            *创建对象，最终输出：
            *在北京新东方医院，有一个整形医生，名叫东方不败
            *在山东蓝翔医院，有一个跌打医生，名叫霸天虎
            *在湖南新睿医院，有一个精神科医生，名叫游哥
            *练习
            *再创建一个医生，名称为：华佗，科系为：外科，所属医院为：曹操
            *请先输出以下信息：
            *有一个外科医生，叫华佗，你知道它是哪一个哪一个医院的吗？(外科和华佗应为占位符)
            *如果回答正确(曹操)则输出：
            *你真牛，这你都知道。
            *如果回答错误则输出：
            *你真水，就知道你答不出来。*/
        lock2: Console.WriteLine("第二题");
            //一问
            YiSheng yiSheng = new YiSheng();
            yiSheng.suoshu = "北京新东方";
            yiSheng.kl = "整形";
            yiSheng.name = "东方不败";
            yiSheng.Doucert();
            yiSheng.suoshu = "山东蓝翔";
            yiSheng.kl = "跌打";
            yiSheng.name = "霸天虎";
            yiSheng.Doucert();
            yiSheng.suoshu = "湖南新睿";
            yiSheng.kl = "精神科";
            yiSheng.name = "游哥";
            yiSheng.Doucert();
            //二问
            YiSheng2 yiSheng2 = new YiSheng2();
            yiSheng2.name = "华佗";
            yiSheng2.kl = "外科";
            yiSheng2.suoshu = "曹操";
            yiSheng2.Doucert();
            string A = Console.ReadLine();//调用方法
            if (A == yiSheng2.suoshu || A == "知道")
            {
                Console.WriteLine("你真牛，这你都知道。");
            }
            else
            {
                Console.WriteLine("你真水，就知道你答不出来。");
            }
            Console.WriteLine();//换行

        /*3.游戏公司要出新游戏了，请创建游戏类。
          游戏类具有以下三个字段：游戏公司、游戏名称、在线人数，修饰符是public
          创建一个游戏类的对象，给三个字段赋值(使用输入)
          最终输出：XXX游戏公司的新网游《XXXX》上线了，每天都有XX位战友在等你上线。*/
        lock3: Console.WriteLine("第三题");
            games games = new games();
            Console.Write("请输入游戏公司的名称：");
            games.gamesname = Console.ReadLine();
            Console.Write("请输入游戏名称：");
            games.name = Console.ReadLine();
            Console.Write("请输入在线人数：");
            games.zxrs = int.Parse(Console.ReadLine());
            games.form();//调用方法
            Console.WriteLine();//换行

        //4.编写电子钟类，具有以下字段，修饰符是public
        //   * 时区   *小时 * 分钟
        //   具有以下方法
        //   * 报时
        //   最后，请在Main方法中创建一个电子钟，时区：巴黎，小时：5点，分钟：12分
        //   并调用报时方法进行报时，将输出：现在时间，巴黎时间5点12分。
        lock4: Console.WriteLine("第四题");
            colock colock = new colock();
            colock.shiqu = "巴黎";
            colock.time = 5;
            colock.min = 12;
            colock.Main();//调用方法
            Console.WriteLine();//换行

        //5.对象数组题，编写商品类
        //  商品类具有字段：商品名，价格，用途。修饰符是public
        //  创建一个商品数组，这个数组包含3个对象，分别为下列三个对象
        //    商品名  价格 用途
        //  *肥皂,    4,    可以用来捡
        // * 黄瓜,    2,    有两种作用
        // * 盗版碟, 10,    请在家长陪同下观看
        // 求出价格最贵的对象
        lock5: Console.WriteLine("第五题");
            shangpinlei[] shangpinlei = new shangpinlei[3];
            for (int i = 0; i < shangpinlei.Length; i++)
            {
                shangpinlei[i] = new shangpinlei();
                Console.Write("请输入商品名：");
                shangpinlei[i].pingming = Console.ReadLine();
                Console.Write("请输入商品价格：");
                shangpinlei[i].jiage = int.Parse(Console.ReadLine());
                Console.Write("请输入商品用途：");
                shangpinlei[i].yongtu = Console.ReadLine();
            }
            for (int i = 0; i < shangpinlei.Length; i++)//循环输出存储的数据
            {
                shangpinlei C = shangpinlei[i];//方便判断
                if (C != null)
                {
                    Console.WriteLine("{0},{1},{2}", shangpinlei[i].pingming, shangpinlei[i].jiage, shangpinlei[i].yongtu);
                }
            }
            shangpinlei max = shangpinlei[0];//假设最大值
            for (int i = 0; i < shangpinlei.Length; i++)//循环比较最大值
            {
                if (shangpinlei[i].jiage > max.jiage)
                {
                    max.jiage = shangpinlei[i].jiage;
                }
            }
            Console.WriteLine("最贵的是{0},价格是{1}",max.pingming,max.jiage);
            Console.WriteLine();//换行

        //6.对象数组题，编写电脑类
        //  电脑类有以下字段：电脑编号（如C26），CPU主频，内存容量，硬盘容量
        //  * 现在要批量生产10台电脑(使用对象数组创建10个电脑对象)
        //  *电脑的编号从C26开始编号，依次是C27、C28、C29...
        //  *电脑的主频全部统一是 2.6G
        // * 电脑的内存容量随机产生，有些是1G的，有些是2G的，有些是3G的，有些是4G的。
        //  *电脑的硬盘容量是内存容量的100倍。如果说内存容量是2G，则硬盘容量是200G。
        //  最后，要求使用foreach循环，输出每一台电脑的信息。
        lock6: Console.WriteLine("第六题");
            conpuerte conpuerte1 = new conpuerte();
            conpuerte[] conpuerte = new conpuerte[10];//实力化对象 
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
            foreach (var item in conpuerte)//forecah输出
            {
                Console.WriteLine("电脑编号：" + item.bianhao + "G。CPU主频：" + item.cpufps + "。电脑内存容量：" + item.nc + "G。电脑硬盘容量：" + item.yingpan);
            }
            //conpuerte1.A();//方法类型调用
            Console.WriteLine();

        //7.编写学生类，有以下字段，修饰符是public
        //   * 姓名     字符串类型
        //   * 零花钱   整数类型
        //   有以下方法
        //   * 吃夜宵的方法
        //     {
        //                学生每次夜宵，都要花费10 - 50元（随机产生）
        //       在控制台输出：张三要去夜宵了，花了33元。（张三和33应为占位符）
        //       从零花钱中扣除夜宵钱
        //     }
        //            请在Main方法中创建一个叫王大宝的学生，刚开始时他有200元零花钱。
        //   让他吃3次夜宵，最后输出看看他还有多少零花钱。
        //   最终输出：王大宝还有112元零花钱。（王大宝和112应为占位符）
        lock7: Console.WriteLine("第七题");
            student student = new student();
            student.main();
            Console.WriteLine();
        }
    }
}
