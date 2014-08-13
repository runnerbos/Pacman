using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PacManMulti.Enum;
using PacManMulti.Controllers;

namespace PacManMulti
{
    /// <summary>
    /// The element is essesntially a moving sprite on a board.
    /// In our Pacman game application, this may be a ghost or a 
    /// PacPerson. The constructor will determine whether or not
    /// the element is human, which AI to use if not human, what
    /// kind of controller to use for this human, and the scheme
    /// for the controller.
    /// </summary>
    public class Element
    {
        public Element(PlayerTypes PlayerType, ControllerTypes ControllerType, ControllerScheme scheme)
        {
            this.PlayerType = PlayerType;
            this.ControllerType = ControllerType;

           Logic(scheme);
        }
        private PlayerTypes PlayerType;
        private ControllerTypes ControllerType;
        private Controller controller;

        private void Logic(ControllerScheme scheme)
        {
            switch (ControllerType)
            {
                case ControllerTypes.Keyboard:
                    controller = new KeyboardController(scheme);
                    break;
                case ControllerTypes.Xbox:
                    controller = new XboxController(scheme);
                    break;
                case ControllerTypes.GhostAI:
                    controller = new GhostAIController();
                    break;
                case ControllerTypes.PacAI:
                    controller = new PacplayerAIController();
                    break;
            }
        }
         
    }
}
