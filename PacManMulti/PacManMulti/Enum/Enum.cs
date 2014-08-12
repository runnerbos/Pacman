using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// This namespace defines the enums that will be used througout 
/// the game to identify certain characteristics of the game.
/// Such as: player types, controller types, and mode types. 
/// </summary>
namespace PacManMulti.Enum
{
    public enum PlayerTypes { Human, AI };
    public enum ControllerTypes { Keyboard, Xbox, GhostAI, PacAI };
    public enum ModeTypes { Classic, GhostTag, Battle };
}
