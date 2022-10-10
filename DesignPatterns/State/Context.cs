using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class Context : IContext
    {
        private IState _state;

        public void SetTime(int hour)
        {
            if (hour < 0 || hour > 24)
                return;
            else if (hour >= 6 && hour <= 18)
                _state = new DayState();
            else
                _state = new NightState();

        }

        public bool ShouldITurnLightsOn()
        {
            return _state.TurnLightsOn();
        }
    }
}
