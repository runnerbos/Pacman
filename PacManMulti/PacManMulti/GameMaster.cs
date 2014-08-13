using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PacManMulti.UI;
using PacManMulti.Enum;
using PacManMulti.Rules;
using PacManMulti.Controllers;

namespace PacManMulti
{
    public class GameMaster
    {
        private Element[] elements;
        private RulesI rules;
        private Board board;

        public void Start()
        {
            Game game = (new Menu()).getGame();

            if (game.players.Length < 1 || game.players.Length > 4)
                throw new Exception("An invalid game was passed to the GameMaster.\nThe number of players is invalid.");

            elements = new Element[game.players.Length];

            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = new Element(game.players[i], game.controls[i], game.schemes[i]);
            }

            switch (game.mode)
            {
                case ModeTypes.Battle:
                    rules = new BattleRules();
                    break;
                case ModeTypes.Classic:
                    rules = new ClassRules();
                    break;
                case ModeTypes.GhostTag:
                    rules = new TagRules();
                    break;
            }
            board = new Board(elements, rules);
        }
        public static void Main()
        {
            (new GameMaster()).Start();
        }
    }
}
