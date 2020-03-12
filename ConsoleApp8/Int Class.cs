using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    class Int_Class
    {
        public int Num1;
        public int Num2;
        private int Num3;

        public Int_Class(int aNum, int bNum, int cNum)
        {
            Num1 = aNum;
            Num2 = bNum;
            NUM3 = cNum; 
        }
        public int NUM3
        {
            get { return Num3; }
            set
            {
                if(value <= 10 && value >= 0)
                {
                    Num3 = value; 
                }
                else
                {
                    Console.WriteLine("type in a number between 0-10");     
                }
            }
        }

    }
}
