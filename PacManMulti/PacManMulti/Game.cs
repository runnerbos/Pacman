using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PacManMulti.Enum;

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
         * 
         * */
        private Players[] players;

        private Controllers[] controls;

        private Mode mode;
    }
}
