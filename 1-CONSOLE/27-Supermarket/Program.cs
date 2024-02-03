using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建超市
            OpenSupermarket os = new OpenSupermarket();
            //展示货物
            os.ShowPros();
            //跟用户交互
            os.Purchase();
            //展示货物
            os.ShowPros();
            Console.ReadKey();
        }
    }
}
