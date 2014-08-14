using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PacManMulti.Rules;
using PacManMulti.Elements;

namespace PacManMulti
{
    public class Board
    {
        public Board(Element[] elements, RulesI rules)
        {
            this.elements = elements;
            this.rules = rules;
        }

        private Element[] elements;
        private RulesI rules;
    }
}
