using System;
using System.Linq;
using ArcadiaTactics_Game.GameStates.Abstractions;
using ArcadiaTactics_Tools;
using ArcadiaTactics_Tools.Menus;

namespace ArcadiaTactics_Game.GameStates.Menus
{
    public class StartMenuGameState : BaseGameState
    {
        string StartMessage;

        public StartMenuGameState()
        {
            //It's weird the game state has to know about the location of the file?
            StartMessage = FileReader.ReadFile(FileReader.FileType.STORY, "game_introduction.txt");
        }

        public override void Activate()
        {
            base.Activate();

            Consoler.PrintToConsole(StartMessage);

            var newGameMenuItem = new MenuSelectionItem()
            {
                MenuSelectionText = "New Game",
                MenuAction = delegate () { Console.WriteLine("NEW GAME"); }
            };

            var exitGameMenuItem = new MenuSelectionItem()
            {
                MenuSelectionText = "Exit Game",
                MenuAction = delegate () { Console.WriteLine("EXIT GAME"); }
            };

            var menu = new MenuSelectionTool(2)
            {
                [0] = newGameMenuItem,
                [1] = exitGameMenuItem
            };

            Consoler.HandleMenuSelection(menu)();
        }
    }

}
