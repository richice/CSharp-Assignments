using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _28_MD5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = GetMD5("123fffg");
            Console.WriteLine(s);
            Console.ReadKey();
        }


        public static string GetMD5(string s)
        {
            //创建MD5 对象
            MD5 md5 = MD5.Create();
            //开始加密 字符串转换成字节数组
            byte[] buffer = Encoding.Default.GetBytes(s);
            //返回加密 返回加密好的字节
            byte[] md5buffer = md5.ComputeHash(buffer);
            //返回字符串 方法：1.字节数组每个元素编码解析  2.数组ToString()  3.数组每个元素ToString()
            //1. return Encoding.Default.GetString(md5buffer);
            //2. 
            string str = "";
            for (int i = 0; i < md5buffer.Length; i++)
            {
                str += md5buffer[i].ToString("x");//x表示十进制转十六-ToString()的格式
            }
            return str;
        }
    }
}
