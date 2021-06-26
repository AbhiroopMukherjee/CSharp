﻿using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            var container = ContainerConfig.ConfigureContainer();

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }

            Console.ReadLine();
        }
    }
}
