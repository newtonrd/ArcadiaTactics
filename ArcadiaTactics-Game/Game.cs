using System;
using ArcadiaTactics_Game.GameStates.Levels;
using ArcadiaTactics_Game.GameStates.Menus;

namespace ArcadiaTactics_Game
{
    public class Game
    {

        public static void Start()
        {
            //var activeGameState = new StartMenuGameState();
            //activeGameState.Activate();

            var level = new Level_1();
            level.Battle();
        }
    }
}
