using System;
using System.Linq;
using System.Text;

namespace ArcadiaTactics_Tools.Menus
{
    public class MenuSelectionItem
    {
        public string MenuSelectionText { get; set; }
        public Action MenuAction { get; set; }

        public MenuSelectionItem()
        { }

        public MenuSelectionItem(string selectionText, Action menuAction)
        {
            MenuSelectionText = selectionText;
            MenuAction = menuAction;
        }

        public override string ToString()
        {
            
            return MenuSelectionText;
        }
    }

    public class MenuSelectionTool
    {
        private MenuSelectionItem[] MenuSelectionItems;

        public MenuSelectionTool(int size)
        {
            MenuSelectionItems = new MenuSelectionItem[size];
        }

        public MenuSelectionItem this[int position]
        {
            get { return MenuSelectionItems[position]; }
            set { MenuSelectionItems[position] = value; }
        }

        /// <summary>
        /// Generate a string representation of the menu
        /// </summary>
        public string GenerateMenu()
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < MenuSelectionItems.Length; i++)
            {
                builder.Append($"> {i + 1} {MenuSelectionItems[i].ToString()}");
                builder.AppendLine();
            }

            return builder.ToString();
        }

        /// <summary>
        /// Get the given MenuSelectionItem if it exists in the MenuSelectionTool
        /// </summary>
        /// <param name="consoleKey"></param>
        /// <param name="selectedItem"></param>
        /// <returns></returns>
        public bool TryFindMenuSelectionItem(ConsoleKeyInfo consoleKeyInfo, out MenuSelectionItem selectedItem)
        {

            int selection = consoleKeyInfo.KeyChar - '0' - 1;

            if (selection >= 0 && selection < MenuSelectionItems.Length)
            {
                selectedItem = MenuSelectionItems[selection];
                return true;
            }

            selectedItem = null;
            return false;

        }
    }

}
