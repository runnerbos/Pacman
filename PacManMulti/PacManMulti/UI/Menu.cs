using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PacManMulti.UI
{
    public class Menu
    {
        public Menu()
        {

        }

        /*
         * This is the game that is created for the Game Master.
         * All elements of the game must be implemented before being passed to the game master. 
         * These elements will be created in the constructor of Menu, which will raise
         * a menu for the user and then create the game from their input. 
         * */
        private Game game = new Game();

        /*
         * This method will return the game to the Game Master. 
         * */
        public Game getGame()
        {
            return game;
        }
    }
}
