using System.Collections.Generic;
using System.Linq;
using ArcadiaTactices_Entities.Abstractions;
using ArcadiaTactices_Entities.Enemies.Basic;
using ArcadiaTactices_Entities.Heroes;
using ArcadiaTactics_Tools;

namespace ArcadiaTactics_Game.GameStates.Levels
{
    public class Level_1
    {
        DiceRoller d_twenty = new DiceRoller(20);
        Queue<BaseCharacter> battleCharacters;


        public Level_1()
        {
            //Levels are battles
            //Consist of a set of monsters
            //Consist of a set of heros

            //Game Battle Loop
            List<BaseCharacter> baseCharacters = new List<BaseCharacter>
            {
                new Goblin("Boblin"),
                new Randall()
            };

            //Roll to determine who goes first
            battleCharacters = DetermineFightOrder(baseCharacters);
        }

        /// <summary>
        /// Execute the battle for the given level
        /// </summary>
        public void Battle()
        {
            //Perform Battle
            while (!IsBattleOver(battleCharacters))
            {
                var activeCharacter = battleCharacters.Dequeue();
                Consoler.PrintToConsole(activeCharacter.ToString());

                //Perform action
                //Hero actions are chosen by the PC
                //Enemy actions are performed by the system

                //Add character back to game loop if they are not dead
                if (!activeCharacter.IsDead())
                {
                    battleCharacters.Append(activeCharacter);
                }
            }
        }


        /// <summary>
        /// Determine the fight order of all characters based on character speed
        /// </summary>
        /// <param name="characters"></param>
        /// <returns></returns>
        public Queue<BaseCharacter> DetermineFightOrder(List<BaseCharacter> characters)
        {
            return new Queue<BaseCharacter>(characters.OrderBy(x => x.Speed));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="characters"></param>
        /// <returns></returns>
        public bool IsBattleOver(Queue<BaseCharacter> characters)
        {
            return characters.Count == 0;
        }
    }
}
