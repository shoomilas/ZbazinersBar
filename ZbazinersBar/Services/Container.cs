using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ZbazinersBar.Services
{
    public sealed class Container
    {
        private static readonly Container instance = new Container();
        public int counter = 0;

        static Container()
        {
        }

        private Container()
        {
        }

        public static Container Instance => instance;

        public void IncreaseCount()
        {
            counter++;
        }

        public int getCount()
        {
            Console.WriteLine(counter);
            return counter;
        }
        
    }

}

