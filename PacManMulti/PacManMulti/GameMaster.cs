using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PacManMulti.UI;
using PacManMulti.Enum;
using PacManMulti.Rules;
using PacManMulti.Controllers;
using PacManMulti.Elements;
using PacManMulti.Logic;

namespace PacManMulti
{
    public class GameMaster
    {
        private Element[] PlayerElements;
        private List<Element> elements = new List<Element>();
        private RulesI rules;
        private Board board;

        public void Start()
        {
            Game game = (new Menu()).getGame();

            if (game.players.Length < 1 || game.players.Length > 4)
                throw new Exception("An invalid game was passed to the GameMaster.\nThe number of players is invalid.");

            //Some logic for creating players.

            switch (game.mode)
            {
                case ModeTypes.Battle:
                    rules = new BattleRules();
                    break;
                case ModeTypes.Classic:
                    rules = new ClassicRules();
                    break;
                case ModeTypes.GhostTag:
                    rules = new TagRules();
                    break;
            }
          //  elements.AddRange(rules.GetElements());
            elements.AddRange(PlayerElements);
            
            board = new Board(elements.ToArray(), rules);
        }
        public static void Main()
        {
            (new GameMaster()).Start();
        }
    }
}
