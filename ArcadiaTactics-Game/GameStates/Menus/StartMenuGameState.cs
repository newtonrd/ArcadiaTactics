using System;
using ArcadiaTactics_Game.GameStates.Abstractions;
using ArcadiaTactics_Tools;

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

            //FileReader.PrintAllFiles_DEBUG();

            Consoler.PrintToConsole(StartMessage);
        }
    }
}
