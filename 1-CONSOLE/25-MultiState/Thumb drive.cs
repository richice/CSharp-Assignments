using System;
using System.Collections.Generic;
using System.Text;

namespace _25_MultiState
{
    public class Thumb_drive: Removable_Storage
    {
        public override void Read()
        {
            Console.WriteLine("移动硬盘读取中");
        }

        public override void Write()
        {
            Console.WriteLine("移动硬盘写入中");
        }
    }
}

