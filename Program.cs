﻿using System;
using System.Collections.Generic;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            IChapter c1 = new Chapter1();
            //c1.Run();

            IChapter c2 = new Chapter2();
            c2.Run();
        }
    }
}
