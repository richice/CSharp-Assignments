using System;
using System.Collections.Generic;
using System.Text;

namespace _25_MultiState
{
    public class Computer
    {
        ////法一 通过属性定义
        //private Removable_Storage _ms;
        //public Removable_Storage Ms { get => _ms; set => _ms = value; }//这样需要在main中定义ms然后cpu.Ms=ms

        //法二 传参
        public void CpuRead(Removable_Storage ms)
        {
            ms.Read();//传父类 但会调出子类 因为有多态
        }
        public void CpuWrite(Removable_Storage ms)
        {
            ms.Write();
        }
    }
}