using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Path
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"C:\Users\ICE\Documents\Visual Studio 2019\Templates\ProjectTemplates\20-Hashtable2.txt";
            //Console.WriteLine(Path.GetFileName(str));

            ////文件名-不扩展名
            //Console.WriteLine(Path.GetFileNameWithoutExtension(str));
            ////仅扩展名 
            //Console.WriteLine(Path.GetExtension(str));
            ////还有文件夹名 全路径 连接路径

            ////File.Create(@"C:\Users\ICE\Documents\Visual Studio 2019\Templates\ProjectTemplates\20-Hashtable.txt");
            ////Console.WriteLine("OK1");

            //File.Copy(@"C:\Users\ICE\Documents\Visual Studio 2019\Templates\ProjectTemplates\20-Hashtable.txt", @"C:\Users\ICE\Documents\Visual Studio 2019\Templates\ProjectTemplates\20-Hashtable3.txt");
            //Console.WriteLine("OK2");

            //File.Delete(@"C:\Users\ICE\Documents\Visual Studio 2019\Templates\ProjectTemplates\20-Hashtable3.txt");
            //Console.WriteLine("OK3"); 
            //Console.ReadKey();


            //编码
            byte[] byt = File.ReadAllBytes(@"C:\Users\ICE\Documents\Visual Studio 2019\Templates\ProjectTemplates\20-Hashtable.txt");//读取了文件的所有字节
            //将字节数组中的每一个元素都按照指定的编码格式解码成字符串
            // UTF-8   GB2312简   GBK繁简   ASCII   Unicode
            string s = Encoding.GetEncoding("UTF-8").GetString(byt);
            //string s = Encoding.Default.GetString(byt);//将字节数组解码为字符串
            File.WriteAllBytes(str, byt);//将相同的字节数组写回到文件中
            Console.WriteLine("ok");

            string[] collection=  File.ReadAllLines(str, Encoding.Default);
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            string content = File.ReadAllText(str, Encoding.Default);
            Console.WriteLine(content);
            Console.WriteLine();

            File.WriteAllLines(str, new string[] { "Dex", "EMILY" });//覆盖
            File.WriteAllText(str,  "DEXXX");//覆盖
            content = File.ReadAllText(str, Encoding.Default);
            Console.WriteLine(content);
            Console.WriteLine();

            File.AppendAllLines(str, new string[] { "Dex", "EMILY" });//不覆盖
            File.AppendAllText(str, "DEXXX");//不覆盖
            content = File.ReadAllText(str, Encoding.Default);
            Console.WriteLine(content);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
