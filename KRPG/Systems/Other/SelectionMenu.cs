using System;
using System.Collections.Generic;
using System.Text;

namespace KRPG.Systems.Other
{
    public class SelectionMenu
    {
        private readonly string _title;
        private readonly List<string> _selectionOptions;

        public SelectionMenu(string title, List<string> selectionOptions)
        {
            _title = title;
            _selectionOptions = selectionOptions;
        }
        public SelectionMenu(string title, params string[] selectionOptions)
        {
            _title = title;
            _selectionOptions = selectionOptions.ToList();
        }

        public int Show()
        {
            int index = 0;

            while(true)
            {
                if (index > _selectionOptions.Count - 1)
                    index = 0;

                if (index < 0)
                    index = _selectionOptions.Count - 1;

                Console.Clear();
                Console.WriteLine(_title);
                Console.WriteLine();
                for (int i = 0; i < _selectionOptions.Count; i++)
                {
                    if (i == index)
                    {
                        Console.WriteLine($"> {_selectionOptions[i]}");
                    }
                    else
                    {
                        Console.WriteLine($"\t{_selectionOptions[i]}");
                    }
                }

                ConsoleKey key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        index--;
                        break;
                    case ConsoleKey.DownArrow:
                        index++;
                        break;
                    case ConsoleKey.Enter:
                        return index;
                    default:
                        break;
                }
            }
        }
    }
}
