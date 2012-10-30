﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenEngine.Core;

namespace OpenEngine.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var bootstrapper = new Bootstrapper(new ConsoleLogger());
            bootstrapper.Start();
            System.Console.ReadLine();
            bootstrapper.Stop();
        }
    }

    class ConsoleLogger : ILogger
    {
        public void Write(Exception ex)
        {
            System.Console.WriteLine(ex.ToString());
        }
    }
}
