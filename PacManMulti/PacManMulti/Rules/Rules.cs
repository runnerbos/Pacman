using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PacManMulti.Rules
{
    /// <summary>
    /// This abstract class defines the methods and logic for which 
    /// a board will play the game. A board (or whatever object) will
    /// ask the rules what is and what is not acceptable based on specific
    /// conditions. These conditions will be custom made for each game mode.
    /// </summary>
    public abstract class Rules
    {
        //sets how many increments the ghost will move with each move input
        public int GhostMoveSpeed;
        //This will say how many increments the player will move when given input
        public int PackPlayerSpeed;
        //This will say how many human players can controll a pacman
        public int MaxHumanPac;
        //This will say how many human players can controll a ghost
        public int MaxHumanGhost;
        //this will say how many humans must controll a pacman
        public int MinHumanPac;
        //this will say how many humans must controll a ghost
        public int MinHumanGhost;
        //tells how many total ghosts there must be minimum
        public int totalMinGhost;
        //tels how many total max ghosts there can be
        public int totalMaxGhost;
        //the minimum packmen that can exist
        public int totalMinPac;
        //the maximum packmen that can exist
        public int totalMaxPac;
        //This will allow or disalow the powering up of a pacman
        public bool PackPlayerCanPowerup;
        //this will allow or disalow the powering up of ghosts
        public bool GhostCanPowerup;
        //this will allow or disallow packplayers eating dots
        public bool PackPlayerCanEatdots;
        //this will allo or disallow ghosts eating dots
        public bool GhostCanEatDots;
        //this will allow or dissalow a ghost eating pacman
        public bool GhostCanEatPackPlayer;
        //this will allow or dissalow packman eating ghosts
        public bool PackPlayerCanEatGhost;
        //this will allow or disallow a ghost/pacman from eating other ghost/pacman when powered
        public bool CanEatSamewhenPowered;

        public void GameLogic(Rules m, int GhostHuman, int GhostAI, int PackPlayerHuman, int PackPlayerAI, Board b, BoardLayout bl)
        {

        }

    }
}
