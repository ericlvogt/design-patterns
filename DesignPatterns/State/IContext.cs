using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public interface IContext
    {
        public bool ShouldITurnLightsOn();
        public void SetTime(int hour);
    }
}
