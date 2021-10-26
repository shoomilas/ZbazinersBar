using System;

namespace ZbazinersBar.Services
{
	public sealed class Container {
        private static readonly Container instance = new Container();
        public int counter = 0;

        static Container() { }

        private Container() { }

        public static Container Instance => instance;

        public void IncreaseCount() {
            counter++;
        }

        public int GetCount() {
            Console.WriteLine(counter);
            return counter;
        }

    }

}