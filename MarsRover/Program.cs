﻿using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new MarsRover(args[0]).Execute(args[1]));
        }
    }
}
