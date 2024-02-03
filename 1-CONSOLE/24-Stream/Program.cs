using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Stream
{
    class Program
    {
        private const string V = @"C:\Users\ICE\Documents\Visual Studio 2019\Templates\ProjectTemplates\20-Hashtable2.txt";

        static void Main(string[] args)
        {
            //操作字节 FileStream 优点：减少内存压力 所有文件 大文件也可以
            //1.创建对象
            FileStream fsRead = new FileStream(V, FileMode.OpenOrCreate, FileAccess.Read);
            byte[] buffer = new byte[1024 * 1024 * 5];//5M
            int res = fsRead.Read(buffer,0,buffer.Length);//返回读取到的有效字节数
            Console.WriteLine(res);
            string s = Encoding.Default.GetString(buffer);//数据转到字符串            
            fsRead.Close();//关闭流
            fsRead.Dispose();//释放资源
            Console.WriteLine(s);

            //2.写入数据
            //创建流写在using中自动释放
            using (FileStream fsWrite = new FileStream(V, FileMode.OpenOrCreate, FileAccess.Write))
            {
                string str = "umich ann bor";
                fsWrite.Write(Encoding.Default.GetBytes(str),0,str.Length);
            }


            //3.多媒体文件复制： 先读取 再写入

            string source = @"D:\论文\留学申请\面试\MEETING ANN ARBOR.pptx";
            string target = @"D:\论文\留学申请\面试\MEETING ANN ARBOR2.pptx";
            //CopyFile(source,target);
           


            //操作字符文本 StreamReader 
            using (StreamReader sr = new StreamReader(V))//创建读取对象
            {
                while (!sr.EndOfStream)//没读完
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
            //            StreamWriter
            using (StreamWriter sw = new StreamWriter(V,true))//表示不覆盖
            {
                sw.Write("I got Annnor bor");
            }
            Console.WriteLine("Write");//按字节的覆盖
            Console.ReadKey();
        }

        public static void CopyFile(string s, string t)
        {
            using (FileStream fileS = new FileStream(s, FileMode.OpenOrCreate, FileAccess.Read))//读取流
            {
                using (FileStream fileW = new FileStream(t, FileMode.OpenOrCreate, FileAccess.Write))//写入流
                {
                    byte[] buffer = new byte[1024 * 1024 * 5];//5M
                    //循环读大文件
                    while (true)
                    {
                        int r = fileS.Read(buffer, 0, buffer.Length);//返回读取到的有效字节数
                        if (r==0)//表示读完了
                        {
                            break;
                        }
                        fileW.Write(buffer, 0, r);
                    }


                }
            }
        }
        
    }
}
