using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace PacManMulti.Logic
{
    abstract class Board 
    {
        public ObservableCollection<Element> board = new ObservableCollection<Element>();
    }    
}
