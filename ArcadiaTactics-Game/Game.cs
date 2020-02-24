using System;
using ArcadiaTactics_Game.GameStates.Menus;

namespace ArcadiaTactics_Game
{
    public class Game
    {

        public static void Start()
        {
            var activeGameState = new StartMenuGameState();
            activeGameState.Activate();
        }
    }
}
