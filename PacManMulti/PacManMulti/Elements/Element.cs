using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PacManMulti.Elements
{
    public abstract class Element
    {
        /// <summary>
        /// Adjusts the position of the element
        /// </summary>
        /// <param name="x">Amount to increase the horizontal position</param>
        /// <param name="y">Amount to increase the vertical position</param>
        void Move(int x, int y)
        {
            XPos += x;
            YPos += y;
        }

        /// <summary>
        /// Moves the element back to its previous position
        /// </summary>
        void UnMove()
        {
            XPos = lastMove.X;
            YPos = lastMove.Y;
        }

        /// <summary>
        /// Represents the hoizontal position of the element
        /// </summary>
        int XPos { get; set; }

        /// <summary>
        /// Represents the vertical position of the element
        /// </summary>
        int YPos { get; set; }

        /// <summary>
        /// A point that represents the previous position of the element
        /// </summary>
        Point lastMove { get; set; }
    }
}
