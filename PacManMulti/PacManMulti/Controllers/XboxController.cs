using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PacManMulti.Controllers
{
    public class XboxController : Controller
    {
        public XboxController(ControllerScheme scheme)
        {
            this.scheme = scheme;
        }
        private ControllerScheme scheme;
    }
}
