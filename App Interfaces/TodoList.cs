using System;

namespace AppInterfaces
{
    class TodoList : IDisplayable, IResetable
    {
        public string[] Todos
        { get; private set; }

        public char HeaderSymbol
        { get; set; }

        public void Display()
        {
            char HeaderSymbol = '-';
            string Header = new string(HeaderSymbol, 10);
            Console.WriteLine(Header);
            Console.WriteLine("Todos:");
            int i = 0;
            foreach (string todo in Todos)
            {
                bool empty = String.IsNullOrEmpty(Todos[i]);
                if (!empty)
                {
                    Console.WriteLine(Todos[i]);
                    i++;
                }
                else if (empty)
                {
                    Console.WriteLine("[]");
                }
            }
        }

        public void Reset()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }

        private int nextOpenIndex;

        public TodoList()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }

        public void Add(string todo)
        {
            if (nextOpenIndex < 5)
            {
                Todos[nextOpenIndex] = todo;
                nextOpenIndex++;
            }
        }
    }
}