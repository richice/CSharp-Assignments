using System;
using System.Collections.Generic;
using System.Text;

namespace _25_MultiState
{
    public class MP3:Removable_Storage
    {
        public override void Read()
        {
            Console.WriteLine("MP3读取中");
        }

        public override void Write()
        {
            Console.WriteLine("MP3写入中");
        }

        public void Music()
        {
            Console.WriteLine("Open your music door");
        }
    }
}
