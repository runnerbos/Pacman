using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PacManMulti.Controllers
{
    public class KeyboardController : Controller
    {
        public KeyboardController(ControllerScheme scheme)
        {
            this.scheme = scheme;
        }
        private ControllerScheme scheme;
    }
}
