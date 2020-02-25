using System;
using ArcadiaTactics_Tools.Menus;

namespace ArcadiaTactics_Tools
{
    public static class Consoler
    {
        public static Action HandleMenuSelection(MenuSelectionTool menu)
        {
            Action action;

            PrintToConsole(menu.GenerateMenu());

            do
            {
                var key = Console.ReadKey();
                var keyFound = menu.TryFindMenuSelectionItem(key, out MenuSelectionItem item);

                if (keyFound)
                {
                    action = item.MenuAction;
                    break;
                }

            } while (true);

            return action;
        }

        public static void ReadConsole()
        {
            Console.ReadKey();
        }

        public static void PrintToConsole(string toPrint)
        {
            Console.WriteLine(toPrint);
        }

    }
}
