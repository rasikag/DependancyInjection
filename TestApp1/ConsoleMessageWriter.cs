﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1
{
    public class ConsoleMessageWriter : IMessageWriter
    {
        public void write(string args)
        {
            Console.WriteLine(args);
        }
    }
}
