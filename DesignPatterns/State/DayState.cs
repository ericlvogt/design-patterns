using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class DayState : IState
    {
        public bool TurnLightsOn()
        {
            return false;
        }
    }
}
