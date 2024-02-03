using System;

namespace _14_Ludo_chess_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Head();

            #region 输入姓名
            Console.BackgroundColor = ConsoleColor.Black;//黄色方框=枚举
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("INPUT NAME A:");
            playername[0] = Console.ReadLine();
            Console.WriteLine("INPUT NAME B:");
            playername[1] = Console.ReadLine();
            while (playername[1] == playername[0])
            {
                Console.WriteLine("REPEATED!!");
                Console.WriteLine("INPUT NAME B:");
                playername[1] = Console.ReadLine();
            }
            #endregion
            Console.Clear();//清屏
            Head();

            InitialMaps();//赋值
            DrawMaps();//值变图

            while (playermap[0]<100&& playermap[1] < 100)
            {
                if (playflag[0]==false)
                {
                    PlayGame(0); 
                }
                else
                {
                    playflag[0] = false;
                }
                if (playflag[1] == false)
                {
                    PlayGame(1);
                }
                else
                {
                    playflag[1] = false;
                    continue;
                }

                if (playermap[0]>=99)
                {
                    Console.WriteLine("{0}赢了", playername[0]);
                    break;
                }
                else if(playermap[1] >= 99)
                {
                    Console.WriteLine("{0}赢了", playername[1]);
                    break;
                }
            }

            Console.ReadKey();
        }



        public static void Head()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;//黄色方框=枚举
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("************************");
            Console.WriteLine("========================");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("*********飞行器*********");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("========================");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("************************");
        }

        public static int[] map = new int[100];//静态字段模拟全局变量 地图长度100
        public static string[] playername = new string[2];//名字
        public static int[] playermap = new int[2];//位置
        public static int playerturn = 0;
        public static bool[] playflag = new bool[2];//默认false

        public static void InitialMaps()
        {
            /*0:普通□
             *1：幸运轮盘◉
             *2：地雷⭐
             *3：暂停▲
             *4：时空隧道下H
             */

            int[] luckyturn = { 6, 23, 40, 55, 69, 83 };
            for (int i = 0; i < luckyturn.Length; i++)
            {
                map[luckyturn[i]] = 1;
            }

            int[] boom = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };
            for (int i = 0; i < boom.Length; i++)
            {
                map[boom[i]] = 2;
            }

            int[] pause = { 9, 27, 60, 93 };
            for (int i = 0; i < pause.Length; i++)
            {
                map[pause[i]] = 3;
            }

            int[] tunnel = { 20, 25, 45, 63, 72, 88, 90 };
            for (int i = 0; i < tunnel.Length; i++)
            {
                map[tunnel[i]] = 4;
            }

        }

        public static void DrawMaps()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("0：普通□\n1：幸运轮盘■\n2：地雷○\n3：暂停▲\n4：时空隧道下∏");

            #region 第一横行
            for (int i = 0; i < 30; i++)
            {
                StringToItem(i);
            }
            #endregion
            Console.WriteLine();

            #region 第一竖行
            for (int i = 30; i < 35; i++)
            {
                for (int j = 0; j < 29; j++)
                {
                    Console.Write("  ");
                }
                StringToItem(i);
                Console.WriteLine();
            }
            #endregion

            #region 第二横行
            for (int i = 64; i >= 35; i--)
            {
                StringToItem(i);
            }
            #endregion
            Console.WriteLine();

            #region 第二竖行
            for (int i = 65; i < 69; i++)
            {
                StringToItem(i);
                Console.WriteLine();
            }
            #endregion

            #region 第三横行
            for (int i = 70; i < 100; i++)
            {
                StringToItem(i);
            }
            #endregion
            Console.WriteLine();
        }

        public static void StringToItem(int i)
        {
            Console.ForegroundColor = ConsoleColor.White;
            if (playermap[0] == playermap[1] && playermap[1] == i)
            {
                Console.Write("∨");
            }
            else if (playermap[0] == i)
            {
                Console.Write("A");
            }
            else if (playermap[1] == i)
            {
                Console.Write("B");
            }
            else
            {
                switch (map[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("□");//可以定义个空字符串然后return
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("■");
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("○");
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("▲");
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("∏");
                        break;
                }
            }
        }

        public static void PlayGame(int playerturn)
        {
            Console.WriteLine("{0}按任意键掷骰子", playername[playerturn]);
            Console.ReadKey(true);//方法-参数-表示输入的数不显示
            Random r = new Random();
            int rNumber = r.Next(1, 7);

            Console.WriteLine("{0}掷出了{1}", playername[playerturn], rNumber);
            playermap[playerturn] += rNumber;
            Console.ReadKey(true);
            Console.WriteLine("{0}按任意键开始行动", playername[playerturn]);
            Console.ReadKey(true);
            Console.WriteLine("{0}行动完成", playername[playerturn]);
            Console.ReadKey(true);
            if (playermap[playerturn] == playermap[1- playerturn])
            {
                Console.WriteLine("玩家{0}踩到了玩家{1},玩家{1}退六格", playername[playerturn], playername[1- playerturn]);
                playermap[1- playerturn] -= 6;
                Console.ReadKey(true);
            }
            else
            {
                switch (map[playermap[playerturn]])
                {
                    case 0:
                        Console.WriteLine("玩家{0}踩到了安全的方块", playername[playerturn]);
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("玩家{0}踩到了幸运轮盘：1-交换位置 2-轰炸对方", playername[playerturn]);
                        string choice = Console.ReadLine();
                        while (true)
                        {
                            if (choice == "1")
                            {
                                Console.WriteLine("玩家{0}与玩家{1}交换位置", playername[playerturn], playername[1 - playerturn]);
                                int temp = playermap[playerturn];
                                playermap[playerturn] = playermap[1- playerturn];
                                playermap[1 - playerturn] = temp;
                                Console.WriteLine("完成！按任意键继续游戏");
                                Console.ReadKey(true);
                                break;
                            }
                            else if (choice == "2")
                            {
                                Console.WriteLine("玩家{0}轰炸玩家{1}使其后退六格", playername[playerturn], playername[1 - playerturn]);
                                playermap[1 - playerturn] -= 6;
                                Console.WriteLine("完成！按任意键继续游戏");
                                Console.ReadKey(true);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("有输入要求。玩家{0}踩到了幸运轮盘：1-交换位置 2-轰炸对方", playername[playerturn]);
                                choice = Console.ReadLine();
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("玩家{0}踩到了危险的地雷", playermap[playerturn]);
                        playermap[playerturn] -= 6;
                        break;
                    case 3:
                        Console.WriteLine("玩家{0}踩到了暂停", playermap[playerturn]);
                        playflag[playerturn] = true;
                        break;
                    case 4:
                        Console.WriteLine("玩家{0}踩到了快活的隧道", playermap[playerturn]);
                        playermap[playerturn] += 10;
                        break;
                }
            }

            Console.Clear();//清屏
            InMaps();//确保不跑出
            DrawMaps();//值变图
        }

        public static void InMaps()
        {
            if (playermap[0]<0)
            {
                playermap[0] = 0;
            }
            if (playermap[1] < 0)
            {
                playermap[1] = 0;
            }
            if (playermap[0] > 100)
            {
                playermap[0] = 99;
            }
            if (playermap[1] > 100)
            {
                playermap[1] = 99;
            }
        }

    }
}
