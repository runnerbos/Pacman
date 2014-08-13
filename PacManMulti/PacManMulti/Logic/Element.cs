using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace PacManMulti.Logic
{
    /// <summary>
    /// This class is the abstract version  of all elements that will exist in the board
    /// </summary>
    abstract class Element : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //This bool keeps track of whether or not this element is under the influence of a powerup
        private bool _ip;

        //This method will notify those who chare about a change in the powerup state
        public bool isPowered
        {
            get { return _ip; }
            set{
                _ip = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Powered"));
                }
            }
        }
        
        //This enum will identfy the type of element this element is
        public ElementType et { get; set; }
        //This will determine at what point the rectangle will be centered
        private Point _p;
        //This int is the number of points the element will move every time it recives a move directive
        public int squaresPermove { get; set; }

        //This will allow the object to notify anyone subscribed to it when it moves
        public Point P
        {
            get { return _p; }
            set
            {
                _p = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Moved"));
            }
        }

        //This method will update the elements location for its initial starting point (used to lay out the board)
        public void setStart(Point st)
        {
            this.P = st;
        }
        //This will move the element by one point and then update anyone who cares about the change
        public void move(Direction d)
        {
            Point tempPoint = this.P;
            if (d == Direction.Left)
            {
                tempPoint.X -= squaresPermove;
                this.P = tempPoint;
            }
            if (d == Direction.Right)
            {
                tempPoint.X += squaresPermove;
                this.P = tempPoint;
            }
            if (d == Direction.Up)
            {
                tempPoint.Y += squaresPermove;
                this.P = tempPoint;
            }
            if (d == Direction.Down)
            {
                tempPoint.Y -= squaresPermove;
                this.P = tempPoint;
            }
        }
    }
}
