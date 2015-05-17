using System;

namespace ApokPT.RocketPlugins
{
    class Category
    {

        public Category(string name, ConsoleColor color)
        {
            Name = name;
            Color = color;
        }

        public string Name { get; private set; }

        public ConsoleColor Color { get; private set; }
    }
}
