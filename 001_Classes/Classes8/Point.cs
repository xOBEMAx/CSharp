using System;

// Конструктор может вызывать в том же самом объекте другой конструктор с помощью ключевого слова this.

namespace Classes
{
    class Point
    {
        // Поля.

        private int x, y;
        private string name;

        // Свойства.
        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }
        
        public string Name
        {
            get { return name; }
        }

        public Point(int x, int y)
        {
            Console.WriteLine("Конструктор с двумя параметрами.");
            this.x = x;
            this.y = y;
        }

        public Point(string name)
            : this(300, 400)
        {
            Console.WriteLine("Конструктор с одним параметром.");
            this.name = name;
        }
    }
}
