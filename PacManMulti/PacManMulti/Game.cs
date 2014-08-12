using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PacManMulti.Enum;
using PacManMulti.Controllers;

namespace PacManMulti
{
    /// <summary>
    /// This class is the data construct in which the game will be played.
    /// It defines the number of players and their types, the controllers
    /// for these players, the controller scheme for those controllers,
    /// and the game mode.
    /// </summary>
    public class Game
    {
        /*
         * This is an array of the Players enum describing
         * what each player type will be. Naturally the number
         * of players will be derived from this. The values of this
         * array will need to be declared during instantiation due
         * to the readonly keyword. We only want this to be set once.
         * Should a player change their minds, a new Game class can be created.
         * This design can change later if needed. This construct is the same
         * for controls and mode.
         * */
        public readonly PlayerTypes[] players;

        /*
         * The array indecies from controls and players wil correspond
         * to each other. For example players[0] will hold the controller[0]. 
         * However, these are enums! The actual classes will later be created
         * in the GameMaster with this construct.
         * */
        public readonly ControllerTypes[] controls;

        /*
         * This array defines the array of schemes to be passed into the controller
         * for each player. AI players will not be passed in this scheme, so the indecy
         * in the array for AI will be null.
         * */
        public readonly ControllerScheme[] schemes;

        /*
         * Simply the mode of the game that will later determine what the rules are.
         * */
        public readonly ModeTypes mode;
    }
}
