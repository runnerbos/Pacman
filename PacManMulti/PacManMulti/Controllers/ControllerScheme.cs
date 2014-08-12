using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PacManMulti.Enum;

namespace PacManMulti.Controllers
{
    /// <summary>
    /// This class is responsible for defining the buttons
    /// or key presses, keyboards, or controllers for the controller
    /// of each player. A reference or object of the XNA controller
    /// or just specific keys can be set. Uneccessary for AI.
    /// </summary>
    public class ControllerScheme
    {
        public ControllerScheme(ControllerTypes controller)
        {
            this.controller = controller;
            Logic();
        }

        private ControllerTypes controller;

        private void Logic()
        {
            switch (controller)
            {
                case ControllerTypes.GhostAI:
                    break;
                case ControllerTypes.PacAI:
                    break;
                case ControllerTypes.Keyboard:
                    break;
                case ControllerTypes.Xbox:
                    break;
            }
        }
    }
}
